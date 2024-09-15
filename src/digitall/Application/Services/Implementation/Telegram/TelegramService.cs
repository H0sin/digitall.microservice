using System.Collections.Specialized;
using System.Web;
using Application.Extensions;
using Application.Factory;
using Application.Helper;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Marzban;
using Application.Services.Interface.Notification;
using Application.Services.Interface.Order;
using Application.Services.Interface.Telegram;
using Application.Services.Interface.Transaction;
using Application.Sessions;
using Application.Static.Template;
using Application.Utilities;
using Data.DefaultData;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Marzban;
using Domain.DTOs.Notification;
using Domain.DTOs.Telegram;
using Domain.DTOs.Transaction;
using Domain.Entities.Marzban;
using Domain.Entities.Telegram;
using Domain.Entities.Transaction;
using Domain.Enums.Marzban;
using Domain.Enums.Notification;
using Domain.Enums.Transaction;
using Domain.Exceptions;
using Domain.IRepositories.Account;
using Domain.IRepositories.Telegram;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using File = Telegram.Bot.Types.File;
using User = Domain.Entities.Account.User;


namespace Application.Services.Implementation.Telegram;

public class TelegramService(
    ITelegramBotRepository telegramBotRepository,
    ITelegramGroupTopicRepository telegramGroupTopicRepository,
    IUserRepository userRepository,
    INotificationService notificationService,
    IAgentService agentService,
    IMarzbanService marzbanService,
    ITransactionService transactionService,
    TelegramBotClientFactory botClientFactory,
    IOrderService orderService,
    IWebHostEnvironment webHostEnvironment)
    : ITelegramService
{
    public async Task<Message> StartedTelegramBotAsync(ITelegramBotClient botClient, Message message,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = message.Chat.Id;

        telegramUser.State = TelegramMarzbanVpnSessionState.None;
        telegramUser.UserSubscribeId = null;
        telegramUser.Id = 0;

        User? user = await userRepository.GetQuery()
            .SingleOrDefaultAsync(x => x.ChatId == chatId, cancellationToken: cancellationToken);

        AgentDto? agent = await CreateUserAfterStartedBot(botClient.BotId ?? 0, message, user);

        return await botClient.SendTextMessageAsync(
            chatId: message.Chat.Id,
            text: TelegramHelper.WelcomeMessage(null, agent.User.TelegramUsername),
            replyMarkup: TelegramHelper.CreateStartMenu(user),
            cancellationToken: cancellationToken);
    }

    public async Task SendMainMenuAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        telegramUser.UserSubscribeId = null;
        telegramUser.State = TelegramMarzbanVpnSessionState.None;
        telegramUser.Id = 0;
        telegramUser.MessageId = 0;

        User? user = await userRepository.GetQuery()
            .SingleOrDefaultAsync(x => x.ChatId == chatId, cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            try
            {
                await botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
            }
            catch
            {
                await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: TelegramHelper.BackToHomeMessage,
                    replyMarkup: TelegramHelper.CreateMainMenu(user!),
                    cancellationToken: cancellationToken);
                return;
            }
        }

        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: TelegramHelper.BackToHomeMessage,
            replyMarkup: TelegramHelper.CreateMainMenu(user!),
            cancellationToken: cancellationToken);
    }

    public async Task<AgentDto?> CreateUserAfterStartedBot(long botId, Message message, User? user)
    {
        User? newUser = null;
        AgentDto? agent = null;
        long agentCode = 0;

        if (user is null)
        {
            if (message.Text != null && message.Text.StartsWith("/start"))
            {
                Int64.TryParse((message.Text.Substring(6)), out agentCode);
            }

            if (agentCode != 0)
            {
                agent = await agentService.GetAgentByCode(agentCode);
            }

            TelegramBotDto? telegramBot = null;

            if (agentCode == 0)
            {
                telegramBot = await GetTelegramBotByBotIdAsync(botId);
                agent = await agentService.GetAgentByIdAsync(telegramBot.AgentId ?? 0);
            }


            newUser = new User()
            {
                Balance = 0,
                AgentId = agent?.Id ?? telegramBot?.AgentId ?? AgentItems.Agents.First().Id,
                FirstName = message.From?.FirstName,
                LastName = message.From?.LastName,
                Password = PasswordHelper.EncodePasswordMd5(message.Chat.Id.ToString()),
                EmailActiveCode = Guid.NewGuid().ToString("N"),
                ChatId = message.Chat.Id,
                BotId = botId,
                TelegramUsername = message.From?.Username,
                MessageId = message.MessageId
            };

            await userRepository.AddEntity(newUser);
            await userRepository.SaveChanges(newUser.Id);

            await notificationService.AddNotificationAsync(
                NotificationTemplate
                    .StartedBotNotification(
                        agent?.AgentAdminId ?? AgentItems.Agents.First().AgentAdminId,
                        newUser.TelegramUsername ?? "NOUSERNAME",
                        newUser.CardToCardPayment,
                        newUser.Id,
                        newUser.ChatId ?? 0),
                user?.Id ?? newUser.Id);
        }
        else
        {
            agent = await agentService.GetAgentByUserIdAsync(user.Id);
            user.MessageId = message.MessageId;
            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(user.Id);
        }

        return agent;
    }

    public async Task<User?> GetUserByChatIdAsync(long chatId)
    {
        User? user = await userRepository.GetQuery()
            .SingleOrDefaultAsync(x => x.ChatId == chatId);

        if (user != null && user.IsBlocked)
            throw new ApplicationException("کاربری بلاک شده است");

        return user;
    }

    public Task<Message> StartedTelegramBotAsync(ITelegramBotClient botClient, Message message,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<AddTelegramBotDto> AddTelegramBotAsync(AddTelegramBotDto bot, long userId)
    {
        TelegramBot telegramBot = bot._GenerateTelegramBot();

        if (await telegramBotRepository.GetQuery().AnyAsync(x => x.Token == bot.Token))
            throw new ExistsException("این بات از قبل ثبت شده است");

        ITelegramBotClient botClient = botClientFactory.GetOrAdd(bot?.Token!);

        var webhookAddress = $"{bot?.HostAddress}{bot?.Route}";

        await telegramBotRepository.AddEntity(telegramBot);
        await telegramBotRepository.SaveChanges(userId);

        await botClient.SetWebhookAsync(
            url: webhookAddress,
            allowedUpdates: Array.Empty<UpdateType>(),
            secretToken: bot!.SecretToken,
            cancellationToken: default);

        return bot;
    }

    public async Task<List<TelegramBot>?> GetAllTelegramBotAsync()
    {
        return await telegramBotRepository
            .GetQuery()
            .Include(x => x.TelegramGroup)
            .ThenInclude(x => x.TelegramGroupTopics)
            .ThenInclude(x => x.TelegramTopic)
            .ToListAsync();
    }

    public async Task<TelegramBotDto> GetTelegramBotByBotIdAsync(long botId)
    {
        return new TelegramBotDto(await telegramBotRepository
            .GetQuery()
            .SingleOrDefaultAsync(x => x.BotId == botId));
    }

    public async Task SendListVpnHaveTestAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        List<MarzbanVpnTestDto> marzbanVpnTest = await marzbanService.GetListMarzbanVpnsTest();

        TelegramHelper telegramHelper = new TelegramHelper();

        await botClient!.EditMessageTextAsync(
            chatId: chatId,
            messageId: callbackQuery.Message.MessageId,
            text: " موقعیت سرویس را انتخاب نمایید. 📌",
            replyMarkup: telegramHelper.CreateListVpnButton(marzbanVpnTest),
            cancellationToken: cancellationToken);
    }

    public async Task SendListVpnAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        List<MarzbanVpnBotDto> marzbanVpnTest = await marzbanService.GetListMarzbanVpns();

        TelegramHelper telegramHelper = new TelegramHelper();

        await botClient!.EditMessageTextAsync(
            chatId: chatId,
            messageId: callbackQuery.Message.MessageId,
            text: " موقعیت سرویس را انتخاب نمایید. 📌",
            replyMarkup: telegramHelper.CreateListVpnButton(marzbanVpnTest),
            cancellationToken: cancellationToken);
    }


    public async Task SendListVpnTemplateAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        TelegramHelper telegramHelper = new TelegramHelper();

        long id = 0;
        long subscribeId = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');
        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
            Int64.TryParse(queryParameters["subscribeId"], out subscribeId);
        }

        User? user = await GetUserByChatIdAsync(chatId);

        List<MarzbanVpnTemplateDto>
            templates = await marzbanService.GetMarzbanVpnTemplateByVpnIdAsync(id, user!.Id);

        await botClient!.EditMessageTextAsync(
            chatId: chatId,
            messageId: callbackQuery.Message.MessageId,
            text: " نوع سرویس خود را انتخاب کنید. 📌",
            replyMarkup: telegramHelper.CreateListVpnTemplateButton(templates, subscribeId),
            cancellationToken: cancellationToken);
    }

    public async Task SendVpnGbAndPriceAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        TelegramHelper telegramHelper = new TelegramHelper();

        long id = 0;
        long vpnId = 0;
        int days = 0;
        long subscribeId = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');
        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
            Int64.TryParse(queryParameters["vpnId"], out vpnId);
            Int64.TryParse(queryParameters["subscribeId"], out subscribeId);
            Int32.TryParse(queryParameters["days"], out days);
        }

        User? user = await GetUserByChatIdAsync(chatId);

        List<MarzbanVpnTemplateDto>
            templates = await marzbanService.GetMarzbanVpnTemplateByVpnIdAsync(vpnId, user!.Id);

        await botClient!.EditMessageTextAsync(
            chatId,
            messageId: callbackQuery.Message.MessageId,
            "یکی از آیتم هایه زیر را انتخاب کنید",
            replyMarkup: telegramHelper.CreateListGbAndPriceButton(templates, days, subscribeId),
            cancellationToken: cancellationToken);
    }

    public async Task SendFactorVpnAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        TelegramHelper telegramHelper = new TelegramHelper();

        long id = 0;
        long vpnId = 0;
        long subscribeId = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
            Int64.TryParse(queryParameters["vpnId"], out vpnId);
            Int64.TryParse(queryParameters["subscribeId"], out subscribeId);
        }

        BuyMarzbanVpnDto buy = new();

        buy.MarzbanVpnTemplateId = id;
        buy.MarzbanVpnId = vpnId;
        buy.Count = 1;

        User? user = await GetUserByChatIdAsync(chatId);

        SubscribeFactorBotDto factor = new();

        factor.Title = buy.Title ?? "خرید سرویس کاهش پینگ";
        factor.Balance = user.Balance;
        CountingVpnPrice countingVpnPrice = new();

        MarzbanVpnTemplateDto? template =
            await marzbanService.GetMarzbanVpnTemplateByIdAsync(buy.MarzbanVpnTemplateId ?? 0);

        long templatePrice =
            await countingVpnPrice.CalculateFinalPrice(agentService, user.Id, template.Price);

        factor.Days = template.Days;
        factor.Gb = template.Gb;
        factor.Price = (templatePrice!) * buy.Count;
        factor.Count = buy.Count;

        if ((buy.MarzbanVpnTemplateId ?? 0) == 0)
        {
            factor.Count = buy.Count == 0 ? 1 : buy.Count;
            MarzbanVpnDto? marzbanVpn = await marzbanService.GetMarzbanVpnByIdAsync(buy.MarzbanVpnId);

            long daysPrice = (factor.Days *
                              await countingVpnPrice.CalculateFinalPrice(agentService, user.Id, marzbanVpn.DayPrice)) *
                             factor.Count;

            long gbsPrice = (factor.Gb *
                             await countingVpnPrice.CalculateFinalPrice(agentService, user.Id, marzbanVpn.GbPrice)) *
                            factor.Count;

            marzbanVpn.DayPrice = gbsPrice;
            marzbanVpn.GbPrice = gbsPrice;

            factor.Price = buy.CountingPrice(marzbanVpn);
            factor.Days = buy.TotalDay;
            factor.Gb = buy.TotalGb;
        }

        await botClient!.EditMessageTextAsync(
            chatId: chatId,
            messageId: callbackQuery.Message.MessageId,
            text: telegramUser?.UserSubscribeId != null ? factor.GetRenewalInfo() : factor.GetInfo(),
            replyMarkup: telegramHelper.CreateFactorButton(id, vpnId, subscribeId),
            cancellationToken: cancellationToken);
    }

    public async Task SendSubscriptionTestAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        long id = 0;

        TelegramHelper telegramHelper = new TelegramHelper();

        Message message = await
            botClient.SendTextMessageAsync(chatId, "در حال ساخت سرویس  تست شما 🙏",
                cancellationToken: cancellationToken);

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
        }

        MarzbanUser? marzbanUser = await marzbanService.BuyMarzbanTestVpnAsync(id, user!.Id);

        MarzbanUserInformationDto userInformation =
            await marzbanService.GetMarzbanUserInformationAsync(marzbanUser.Username);

        MarzbanVpnDto? vpn = await marzbanService.GetMarzbanVpnByIdAsync(id, user.Id);

        byte[] QrImage = await GenerateQrCode
            .GetQrCodeAsync(userInformation.Subscription_Url);

        string caption = $@"
            ✅ سرویس با موفقیت ایجاد شد
            👤 نام کاربری سرویس: `\{userInformation.Username.TrimEnd()}`\
            🌿 نام سرویس: {vpn.Name.TrimEnd()}
            ⏳ مدت زمان: {vpn.Test_Days} روز
            🗜 حجم سرویس: {vpn.Test_TotalGb} مگابایت
            لینک اتصال:
            `\{userInformation.Subscription_Url.TrimEnd()}`\
            ";

        using (var qr = new MemoryStream(QrImage))
        {
            await botClient.SendPhotoAsync(
                chatId: callbackQuery.Message.Chat.Id,
                photo: new InputFileStream(qr, userInformation.Subscription_Url),
                parseMode: ParseMode.MarkdownV2,
                replyMarkup: telegramHelper.CreateSeeLearn(userInformation.Subscription_Url),
                caption: caption,
                cancellationToken: cancellationToken);
        }

        await botClient.DeleteMessageAsync(chatId, message.MessageId, cancellationToken: cancellationToken);
        await SendMainMenuAsync(botClient, callbackQuery, cancellationToken, telegramUser);
    }

    public async Task SendSubscriptionAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        TelegramHelper telegramHelper = new TelegramHelper();

        Message message = await
            botClient.SendTextMessageAsync(chatId, "در حال ساخت سرویس شما 🙏", cancellationToken: cancellationToken);

        long templateId = 0;
        long vpnId = 0;
        int days = 0;
        int gb = 0;
        long subscribeId = 0;

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');
        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["templateId"], out templateId);
            Int64.TryParse(queryParameters["vpnId"], out vpnId);
            Int32.TryParse(queryParameters["days"], out days);
            Int32.TryParse(queryParameters["gb"], out gb);
            Int64.TryParse(queryParameters["subscribeId"], out subscribeId);
        }

        BuyMarzbanVpnDto buy = new();

        buy.MarzbanVpnId = vpnId;
        buy.MarzbanVpnTemplateId = templateId;
        buy.Count = 1;
        buy.TotalDay = days;
        buy.TotalGb = gb;
        buy.MarzbanUserId = telegramUser?.UserSubscribeId;

        MarzbanVpnTemplateDto? template = null;

        User? user = await GetUserByChatIdAsync(chatId);

        if (templateId != 0)
            template =
                await marzbanService.GetMarzbanVpnTemplateByIdAsync(buy.MarzbanVpnTemplateId ?? 0);

        List<MarzbanUser> marzbanUsers = new List<MarzbanUser>();

        if (buy.MarzbanUserId != null && buy.MarzbanUserId != 0)
        {
            await marzbanService.RenewalMarzbanVpnAsync(buy, user?.Id ?? 0);
        }
        else
            marzbanUsers = await marzbanService.BuyMarzbanVpnAsync(buy, user?.Id ?? 0);

        if (subscribeId == 0)
        {
            foreach (MarzbanUser marzbanUser in marzbanUsers)
            {
                byte[] QrImage = await GenerateQrCode
                    .GetQrCodeAsync(marzbanUser?.Subscription_Url);

                string caption = $@"
                    ✅ سرویس با موفقیت ایجاد شد

👤 نام کاربری سرویس: `\{marzbanUser.Username.TrimEnd()}`\
🌿 نام سرویس: {template?.Title ?? "خرید اشتراک"}
⏳ مدت زمان: {template?.Days ?? days} روز
👥 حجم سرویس: {((template?.Gb ?? gb) > 200 ? "نامحدود" : (template?.Gb ?? gb) + "گیگ")}
لینک اتصال:
                    `\{marzbanUser.Subscription_Url.TrimEnd()}`\
                    ";

                using (var Qr = new MemoryStream(QrImage))
                {
                    await botClient.DeleteMessageAsync(chatId: callbackQuery.Message.Chat.Id,
                        messageId: callbackQuery.Message.MessageId,
                        cancellationToken: cancellationToken);

                    await botClient.SendPhotoAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        photo: new InputFileStream(Qr, marzbanUser.Subscription_Url),
                        parseMode: ParseMode.MarkdownV2,
                        replyMarkup: telegramHelper.CreateSeeLearn(marzbanUser.Subscription_Url),
                        caption: caption,
                        cancellationToken: cancellationToken);
                }

                await botClient.DeleteMessageAsync(chatId, message.MessageId, cancellationToken: cancellationToken);
            }
        }
        else if (subscribeId > 0 && marzbanUsers.Count == 0)
        {
            await botClient.EditMessageTextAsync(
                chatId,
                messageId: message.MessageId,
                """
                🙏 با تشکر از تمدید سرویس خود.
                ✅ تمدید شما با موفقیت انجام شد.
                ⬅️ برای بازگشت به لیست سرویس‌های خود یا مشاهده اطلاعات، روی دکمه‌های زیر کلیک کنید.
                """,
                replyMarkup: telegramHelper.CreateRenewalButtons(subscribeId, vpnId),
                cancellationToken: cancellationToken);
        }

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        await SendMainMenuAsync(botClient, callbackQuery, cancellationToken, telegramUser);
    }

    public async Task SendListServicesAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, string? username = null)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        int page = 1;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int32.TryParse(queryParameters["page"], out page);
        }

        FilterMarzbanUser filter = new FilterMarzbanUser();
        User? user = await GetUserByChatIdAsync(chatId);

        filter.UserId = user.Id;
        filter.Page = page;
        filter.Username = username;

        FilterMarzbanUser users = await marzbanService.FilterMarzbanUsersAsync(filter);

        try
        {
            await botClient!.EditMessageTextAsync(
                chatId: chatId,
                messageId: callbackQuery.Message.MessageId,
                text: TelegramHelper.ListServicesMessage,
                replyMarkup: TelegramHelper.CreateListServices(filter, page),
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: TelegramHelper.ListServicesMessage,
                replyMarkup: TelegramHelper.CreateListServices(filter, page),
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendSubscribeInformationAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long id = 0;
        long vpnId = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
            Int64.TryParse(queryParameters["vpnId"], out vpnId);
        }

        User? user = await GetUserByChatIdAsync(chatId);

        MarzbanUserDto? marzbanUser = await marzbanService.GetMarzbanUserByUserIdAsync(id, user.Id);
        if (vpnId == 0) vpnId = marzbanUser.MarzbanVpnId;
        SubescribeStatus.ServiceStatus subescribeStatus = new SubescribeStatus.ServiceStatus(marzbanUser);

        telegramUser.UserSubscribeId = id;
        telegramUser.MessageId = callbackQuery.Message.MessageId;

        try
        {
            await botClient!.EditMessageTextAsync(
                chatId: chatId,
                messageId: callbackQuery.Message.MessageId,
                text: subescribeStatus.GetInfo(),
                replyMarkup: TelegramHelper.SendServiceInformationButton(marzbanUser.Id, vpnId, marzbanUser.Status),
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: subescribeStatus.GetInfo(),
                replyMarkup: TelegramHelper.SendServiceInformationButton(marzbanUser.Id, vpnId, marzbanUser.Status),
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendConfigsAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        int id = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int32.TryParse(queryParameters["id"], out id);
        }

        User? user = await GetUserByChatIdAsync(chatId);
        MarzbanUserDto? marzbanUser = await marzbanService.GetMarzbanUserByUserIdAsync(id, user.Id);

        foreach (string link in marzbanUser.Links)
        {
            byte[] QrImage = await GenerateQrCode
                .GetQrCodeAsync(link);

            using (var Qr = new MemoryStream(QrImage))
            {
                await botClient.SendPhotoAsync(
                    chatId: callbackQuery.Message.Chat.Id,
                    photo: new InputFileStream(Qr, link),
                    caption: link,
                    cancellationToken: cancellationToken);
            }
        }
    }

    public async Task SendSubscriptionLinkAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        int id = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int32.TryParse(queryParameters["id"], out id);
        }

        User user = await GetUserByChatIdAsync(chatId);
        MarzbanUserDto? marzbanUser = await marzbanService.GetMarzbanUserByUserIdAsync(id, user.Id);

        byte[] qrImage = await GenerateQrCode
            .GetQrCodeAsync(marzbanUser?.Subscription_Url);

        using (var qr = new MemoryStream(qrImage))
        {
            await botClient!.SendPhotoAsync(
                chatId: callbackQuery.Message.Chat.Id,
                photo: new InputFileStream(qr, marzbanUser.Subscription_Url),
                caption: marzbanUser.Subscription_Url,
                replyMarkup: TelegramHelper.Back($"subscribe_info?id={id}"),
                cancellationToken: cancellationToken);
        }

        await botClient!.DeleteMessageAsync(callbackQuery.Message.Chat.Id, callbackQuery.Message.MessageId,
            cancellationToken: cancellationToken);
    }

    public async Task GiveServiceNameForFilterAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendServiceName;
        await botClient!.SendTextMessageAsync(
            chatId: callbackQuery.Message!.Chat.Id,
            text: "لطفا اسم سرویس خود را ارسال کنید",
            cancellationToken: cancellationToken);
    }

    public async Task RevokesubscriptionAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);
        string link = await marzbanService.RevokeMarzbanUserAsync(telegramUser.UserSubscribeId ?? 0, user.Id);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: TelegramHelper.SendRevokeSubscribetion(link),
            parseMode: ParseMode.MarkdownV2,
            cancellationToken: cancellationToken);
    }

    public async Task SendTextDeleteMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        int id = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int32.TryParse(queryParameters["id"], out id);
        }

        User? user = await GetUserByChatIdAsync(chatId);
        List<MarzbanUserDto> marzbanUsers = await marzbanService.GetMarzbanUsersAsync(user.Id, null);

        if (marzbanUsers.Any(x => x.IsDelete == true))
        {
            throw new AppException("شما یک درخواست برسی نشده در صف دارید ❌");
        }

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForDeleteMarzbanUser;
        telegramUser.UserSubscribeId = id;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: TelegramHelper.DeleteServiceText,
            cancellationToken: cancellationToken);
    }

    public async Task DeleteMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        User? user = await GetUserByChatIdAsync(chatId);

        AgentDto? agent = await agentService.GetAgentByUserIdAsync(user!.Id);


        global::Telegram.Bot.Types.User me = await botClient!.GetMeAsync(cancellationToken: cancellationToken);

        DeleteMarzbanUserDto delete = new()
        {
            Username = user.TelegramUsername ?? "NOUSERNAME",
            Message = callbackQuery.Message.Text,
            UserId = user.Id,
            ChatId = user.ChatId ?? 0,
            AgentAdminId = agent!.AgentAdminId,
            MarzbanUserId = telegramUser.UserSubscribeId ?? 0,
        };

        await marzbanService.DeleteMarzbanUserAsync(delete);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: """
                  درخواست حذف سرویس برای پشتیبانی ارسال شد ✅
                  درصورت تایید سرویس شما حذف میشود ❌
                  تا وقتی این سرویس در حال برسی است نمیتوانید
                  درخواست حدف سرویس جدیدی ارسال کنید ⚠️
                  """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);
    }

    public async Task DeletedMarzbanUserServiceByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        long Id = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');
        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out Id);
        }

        User? user = await GetUserByChatIdAsync(chatId);

        await marzbanService.MainDeleteMarzbanUserAsync(Id, user.Id);

        await botClient!.EditMessageTextAsync(
            chatId: chatId,
            messageId: callbackQuery.Message.MessageId,
            text: callbackQuery.Message.Text,
            replyMarkup: "درخواست حذف تایید شد ✅",
            cancellationToken: cancellationToken);
    }

    public async Task NotDeleteMarzbanUserServiceByAgentAsync(ITelegramBotClient? botClient,
        CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        long Id = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');
        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out Id);
        }

        User? user = await GetUserByChatIdAsync(chatId);

        try
        {
            await marzbanService.NotDeleteMarzbanUserAsync(Id, user.Id);
            await botClient!.EditMessageTextAsync(
                chatId: chatId,
                messageId: callbackQuery.Message.MessageId,
                text: callbackQuery.Message.Text,
                replyMarkup: "درخواست حذف تایید نشد ✅",
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            await botClient!.EditMessageTextAsync(
                chatId, callbackQuery.Message.MessageId,
                e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task ActiveMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        await marzbanService.ChangeMarzbanUserStatusAsync(MarzbanUserStatus.active, telegramUser.UserSubscribeId ?? 0,
            user.Id);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "سرویس شما با موفقیت فعال شد ✅",
            cancellationToken: cancellationToken);

        await SendSubscribeInformationAsync(botClient, new()
        {
            Data = $"subscribe_info?id={telegramUser.UserSubscribeId}",
            From = callbackQuery.From,
            Message = new Message()
            {
                Chat = callbackQuery.Message.Chat,
                MessageId = telegramUser.MessageId,
            },
        }, cancellationToken, telegramUser);
    }

    public async Task DisabledMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        await marzbanService.ChangeMarzbanUserStatusAsync(MarzbanUserStatus.disabled, telegramUser.UserSubscribeId ?? 0,
            user.Id);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "سرویس شما با موفقیت غیر فعال شد ❌",
            cancellationToken: cancellationToken);

        await SendSubscribeInformationAsync(botClient, new()
        {
            Data = $"subscribe_info?id={telegramUser.UserSubscribeId}",
            From = callbackQuery.From,
            Message = new Message()
            {
                Chat = callbackQuery.Message.Chat,
                MessageId = telegramUser.MessageId,
            },
        }, cancellationToken, telegramUser);
    }

    public async Task SendSupportingMenuAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        await botClient!.EditMessageTextAsync(
            chatId: chatId,
            messageId: callbackQuery.Message.MessageId,
            text: TelegramHelper.SupportingMenuText,
            replyMarkup: TelegramHelper.SupportingMenuButton(),
            cancellationToken: cancellationToken);
    }

    public async Task SendDefaultQuestionAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        await botClient!.EditMessageTextAsync(
            chatId: chatId,
            messageId: callbackQuery.Message.MessageId,
            text: TelegramHelper.DefaultQuestionText,
            replyMarkup: TelegramHelper.Back("supporting"),
            cancellationToken: cancellationToken);
    }

    public async Task SendTextForSendMessageSupporting(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendTicketMessage;

        long chatId = callbackQuery.Message!.Chat.Id;

        await botClient!.EditMessageTextAsync(
            chatId: chatId,
            messageId: callbackQuery.Message.MessageId,
            text: "لطفا پیغام خود را ارسال کنید ✉️",
            replyMarkup: TelegramHelper.Back("supporting"),
            cancellationToken: cancellationToken);
    }

    public async Task SendMessageForSupporting(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto? agent = await agentService.GetAgentByUserIdAsync(user.Id);

        IFormFile? formFile = null;
        File? file = null;

        string? fileId = callbackQuery.Message?.Photo?[^1].FileId;

        if (fileId != null &&
            await botClient.GetFileAsync((fileId ?? null) ?? string.Empty, cancellationToken: cancellationToken) !=
            null)
        {
            file = await botClient.GetFileAsync(
                callbackQuery?.Message.Photo?[^1].FileId ?? null,
                cancellationToken: cancellationToken);

            using var memoryStream = new MemoryStream();

            await botClient!.DownloadFileAsync(file.FilePath!, memoryStream, cancellationToken);

            memoryStream.Seek(0, SeekOrigin.Begin);

            formFile =
                new FormFile(
                    memoryStream,
                    0,
                    memoryStream.Length,
                    file.FileId, $"{file.FileId}.jpg");

            formFile.AddImageToServer(formFile.FileName,
                PathExtension.TicketAvatarOriginServer(webHostEnvironment)
                , 100, 100,
                PathExtension.TicketAvatarThumbServer(webHostEnvironment));
        }

        await notificationService.AddNotificationAsync(
            NotificationTemplate.SendTicketForAgentAsync(
                agent!.AgentAdminId,
                callbackQuery?.Message?.Caption ?? callbackQuery.Message?.Text,
                user.ChatId ?? 0,
                user.Id,
                user.TelegramUsername ?? "NOUSERNAME",
                DateTime.Now,
                file is not null ? PathExtension.TicketAvatarOriginServer(webHostEnvironment) + formFile.FileName : null
            ), user!.Id);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "پیغام شما با موفقیت برای پشتیبان ارسال شد ✅",
            cancellationToken: cancellationToken);

        await SendMainMenuAsync(botClient, callbackQuery, cancellationToken, telegramUser);
    }

    public async Task SendUserInformationAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        await botClient!.EditMessageTextAsync(
            chatId: chatId,
            messageId: callbackQuery.Message.MessageId,
            text: TelegramHelper.SendUserInformation(user),
            replyMarkup: TelegramHelper.UserInformationButtons(),
            cancellationToken: cancellationToken);
    }

    public async Task SendTransactionDetailsAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        TransactionDetailDto? transactionDetail = await transactionService.GetTransactionDetailsAsync(user.AgentId);

        if (transactionDetail is null)
            throw new ApplicationException(" ❌❌ درگاه پرداخت غیر فعال است ❌❌");

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendPrice;

        await botClient!.EditMessageTextAsync(
            chatId: chatId,
            messageId: callbackQuery.Message.MessageId,
            text: TelegramHelper.SendPriceTransactionText(user, transactionDetail),
            replyMarkup: TelegramHelper.Back("wallet"),
            cancellationToken: cancellationToken);
    }

    public async Task SendCardNumberAndDetailAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        TransactionDetailDto transactionDetail = await transactionService.GetTransactionDetailsAsync(user.AgentId);

        AgentDto? agent = await agentService.GetAgentByUserIdAsync(user.Id);

        User? parentUser = await userRepository.GetEntityById(agent.AgentAdminId);

        long price = TelegramHelper.CheckPrice(user, transactionDetail, callbackQuery.Message.Text);

        long remainingBalance = parentUser!.Balance - price;

        if (remainingBalance < (agent?.NegativeChargeCeiling ?? 0) & agent?.NegativeChargeCeiling < 0)
        {
            ButtonJsonDto buttonJson = new ButtonJsonDto("\ud83d\udcb0 افزایش موجودی", "inventory_increase");
            notificationService.AddNotificationAsync(new()
            {
                Message = $"""
                            ⚠️ خطا در پرداخت
                           کاربری با شناسه چت : `\{chatId}`\
                            نام کاربری : @{user.TelegramUsername ?? "NOUSERNAME"}
                           قصد داشت تراکنشی با مبلغ {price:N0} تومان انجام دهد، اما به دلیل اینکه مبلغ از موجودی شما بیشتر بود،
                           تراکنش انجام نشد
                           """,
                Buttons = new()
                {
                    buttonJson
                },
                ForAllMember = false,
                NotificationType = NotificationType.FinancialReports,
                UserId = parentUser.Id,
            }, user.Id);

            telegramUser.State = TelegramMarzbanVpnSessionState.None;
            throw new AppException("❌ پرداخت غیر فعال است ❌");
        }
        else if (remainingBalance < 0 & agent?.NegativeChargeCeiling == 0)
        {
            ButtonJsonDto buttonJson = new ButtonJsonDto("\ud83d\udcb0 افزایش موجودی", "inventory_increase");
            notificationService.AddNotificationAsync(new()
            {
                Message = $"""
                            ⚠️ خطا در پرداخت
                           کاربری با شناسه چت : `\{chatId}`\
                            نام کاربری : @{user.TelegramUsername ?? "NOUSERNAME"}
                           قصد داشت تراکنشی با مبلغ {price:N0} تومان انجام دهد، اما به دلیل اینکه مبلغ از موجودی شما بیشتر بود،
                           تراکنش انجام نشد
                           """,
                Buttons = new()
                {
                    buttonJson
                },
                ForAllMember = false,
                NotificationType = NotificationType.FinancialReports,
                UserId = parentUser.Id,
            }, user.Id);
            telegramUser.State = TelegramMarzbanVpnSessionState.None;
            throw new AppException("❌ پرداخت غیر فعال است ❌");
        }

        if (string.IsNullOrEmpty(transactionDetail.CardNumber) | !user.CardToCardPayment)
        {
            if (!user.CardToCardPayment)
            {
                await notificationService.AddNotificationAsync(
                    NotificationTemplate
                        .ErrorForAddTransactionNotification(agent.AgentAdminId, user.TelegramUsername,
                            user.ChatId ?? 0, price, true, user.Id), user.Id
                );
            }
            else
            {
                await notificationService.AddNotificationAsync(
                    NotificationTemplate
                        .ErrorForAddTransactionNotification(agent.AgentAdminId, user.TelegramUsername,
                            user.ChatId ?? 0, price), user.Id
                );
            }

            telegramUser.State = TelegramMarzbanVpnSessionState.None;
            throw new AppException("❌ پرداخت غیر فعال است ❌");
        }

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendTransactionImage;
        telegramUser.Price = price;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: TelegramHelper.SendTextCardNumber(transactionDetail, price),
            replyMarkup: TelegramHelper.SendTransactionImageButton(),
            cancellationToken: cancellationToken);
    }

    public async Task GiveTransactionImageAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        await botClient!.EditMessageTextAsync(
            chatId: chatId,
            messageId: callbackQuery.Message.MessageId,
            text: "🖼 تصویر رسید خود را ارسال نمایید",
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken
        );
    }

    public async Task AddTransactionAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        if (callbackQuery.Message.Type == MessageType.Photo)
        {
            telegramUser.State = TelegramMarzbanVpnSessionState.None;

            var file = await botClient!.GetFileAsync(callbackQuery.Message.Photo![^1].FileId,
                cancellationToken: cancellationToken);

            using var memoryStream = new MemoryStream();
            await botClient!.DownloadFileAsync(file.FilePath!, memoryStream, cancellationToken);
            memoryStream.Seek(0, SeekOrigin.Begin);

            IFormFile formFile =
                new FormFile(
                    memoryStream,
                    0,
                    memoryStream.Length,
                    file.FileId, $"{file.FileId}.jpg");

            AddTransactionDto transaction = new()
            {
                AccountName = callbackQuery.Message?.From?.Username ?? callbackQuery.Message?.From?.FirstName,
                TransactionTime = DateTime.Now,
                TransactionType = TransactionType.Increase,
                AvatarTransaction = formFile,
                Price = telegramUser.Price,
                Title = "افزایش موجودی"
            };

            User? user = await GetUserByChatIdAsync(chatId);
            await transactionService.AddTransactionAsync(transaction, user!.Id);
            TelegramHelper telegramHelper = new TelegramHelper();

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: TelegramHelper.SuccessTransactionText(telegramUser.Price),
                cancellationToken: cancellationToken
            );

            await SendMainMenuAsync(
                botClient,
                callbackQuery,
                cancellationToken,
                telegramUser
            );
        }
        else
        {
            string text = "🖼 لطفا عکس ارسال کنید";

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: text,
                cancellationToken: cancellationToken);
        }
    }

    public async Task UpdateTransactionStatusAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long id = 0;
        TransactionStatus status = TransactionStatus.Waiting;

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
            Enum.TryParse(queryParameters["status"], true, out status);
        }

        User? user = await GetUserByChatIdAsync(chatId);

        await transactionService.UpdateTransactionStatusAsync(new UpdateTransactionStatusDto(status, id), user.Id);

        string typeTransaction = status == TransactionStatus.Accepted ? "قبول" : "رد";

        await botClient!.EditMessageTextAsync(
            chatId,
            messageId: callbackQuery.Message.MessageId,
            text: callbackQuery.Message.Text,
            replyMarkup: $"تراکنش با موفقیت  {typeTransaction} شد",
            cancellationToken: cancellationToken);
    }

    public async Task SendTextAgentRequest(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);
        bool request = await agentService.HaveRequestAgentAsync(user!.Id);

        if (request)
        {
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: "❌ شما قبلا درخواستی برای نمایندگی ثبت کردید ❌",
                cancellationToken: cancellationToken);
        }
        else
        {
            telegramUser!.State = TelegramMarzbanVpnSessionState.AwaitingSendPhone;

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: "لطفا شماره تلفن خود را برای ثبت نمایندگی ارسال کنید 📞",
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendDescriptionTextForAddedAgent(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        string? phone = TelegramHelper.CheckPhoneNumber(callbackQuery.Message.Text);

        telegramUser.Phone = phone;
        telegramUser.State =
            TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForAddAgentRequest;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "لطفا توضیحات درخواست خود را ارسال کنید 📝",
            cancellationToken: cancellationToken);
    }

    public async Task RequestForAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        User? user = await GetUserByChatIdAsync(chatId);

        AddRequestAgentDto request = new()
        {
            Description = callbackQuery.Message!.Text,
            Phone = telegramUser.Phone
        };

        await agentService.AddAgentRequestAsync(request, user!.Id);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: """
                  درخواست نمایندگی شما با موفقیت ثبت شد ✅
                  منتظر برسی پشتیبانی باشید 👁
                  از صبر و شکیبایی شما سپاس گذاریم
                  """,
            cancellationToken: cancellationToken);
    }

    public async Task AcceptAgentRequestAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long Id = 0;

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["Id"], out Id);
        }

        User? user = await GetUserByChatIdAsync(chatId);

        await agentService.UpdateAgentRequest(new()
        {
            Id = Id,
            AgentRequestStatus = "accept"
        }, user!.Id);

        await botClient!.EditMessageTextAsync(
            chatId,
            messageId: callbackQuery.Message.MessageId,
            text: callbackQuery.Message.Text ?? "",
            replyMarkup: "درخواست تایید شد ✅",
            cancellationToken: cancellationToken);

        callbackQuery.Message.MessageId = 0;

        await SendMainMenuAsync(botClient!, callbackQuery, cancellationToken, telegramUser);
    }

    public async Task RejectAgentRequestAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long Id = 0;

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["Id"], out Id);
        }

        User? user = await GetUserByChatIdAsync(chatId);

        await agentService.UpdateAgentRequest(new()
        {
            Id = Id,
            AgentRequestStatus = "reject"
        }, user!.Id);

        await botClient!.EditMessageTextAsync(
            chatId,
            messageId: callbackQuery.Message.MessageId,
            text: callbackQuery.Message.Text ?? "",
            replyMarkup: "درخواست رد شد ❌",
            cancellationToken: cancellationToken);

        callbackQuery.Message.MessageId = 0;

        await SendMainMenuAsync(botClient!, callbackQuery, cancellationToken, telegramUser);
    }

    public async Task SendTelegramInviteLinkAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        global::Telegram.Bot.Types.User userInfo = await botClient!.GetMeAsync(cancellationToken: cancellationToken);

        User? user = await GetUserByChatIdAsync(chatId);

        TelegramLinkDto? link = await agentService.GetAgentTelegramLink(user!.Id);

        await botClient!.SendTextMessageAsync(
            callbackQuery!.Message!.Chat.Id,
            text: TelegramHelper.InviteText(link, userInfo.Username ?? ""),
            cancellationToken: cancellationToken
        );
    }

    public async Task SendTransactionsAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        List<TransactionDto> transactions = await transactionService
            .GetAllTransactionByUserIdAsync(user!.Id);

        if (transactions.Count <= 0)
            throw new AppException("تراکنشی ثبت نشده است");

        foreach (var transaction in transactions)
        {
            string type = transaction.TransactionType switch
            {
                TransactionType.ManualIncrease => "افزایش دستی \u2705",
                TransactionType.ManualDecrease => "کاهش دستی \u274c",
                TransactionType.Decrease => "کاهش \u2796",
                TransactionType.Increase => "افزایش \u2795",
                _ => ""
            };

            string status = transaction.TransactionStatus switch
            {
                TransactionStatus.Accepted => "تایید شده \u2705",
                TransactionStatus.NotAccepted => "رد شده \u274c",
                _ => "در انتظار برسی \u23f1"
            };

            if (!string.IsNullOrEmpty(transaction.AvatarTransaction))
            {
                using (var stream = new FileStream(
                           PathExtension.TransactionAvatarOriginServer(webHostEnvironment) +
                           transaction.AvatarTransaction,
                           FileMode.Open, FileAccess.Read,
                           FileShare.Read))
                {
                    var inputOnlineFile =
                        new InputFileStream(stream,
                            Path.GetFileName(PathExtension.TransactionAvatarOriginServer(webHostEnvironment) +
                                             transaction.AvatarTransaction));

                    await botClient!.SendPhotoAsync(
                        chatId: chatId,
                        photo: inputOnlineFile,
                        caption: $"""
                                   🕖 تاریخ تراکنش :{PersianDateTimeHelper.GetPersianDateTime(transaction.TransactionTime)}
                                  💸 مبلغ تراکنش : {transaction.Price:N0} تومان
                                   💫 وضعیت تراکنش :{status}
                                   🔢 کد تراکنش :{transaction.TransactionCode}
                                   توضیحات تراکنش :
                                   {transaction.Description}
                                  """,
                        cancellationToken: default
                    );
                }
            }
            else
            {
                await botClient!.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"""
                            🕖 تاریخ تراکنش :{PersianDateTimeHelper.GetPersianDateTime(transaction.TransactionTime)}
                           💸 مبلغ تراکنش : {transaction.Price:N0} تومان
                            💫 وضعیت تراکنش :{status}
                            🔢 کد تراکنش :{transaction.TransactionCode}
                            نوع تراکنش :{type}
                            توضیحات تراکنش :
                            {transaction.Description}
                           """,
                    cancellationToken: cancellationToken
                );
            }
        }

        await SendMainMenuAsync(botClient, callbackQuery, cancellationToken, telegramUser);
    }

    public async Task SendUserTransactionsAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        long id = 0;

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
        }

        User? user = await userRepository.GetEntityById(id);

        telegramUser.Id = id;

        List<TransactionDto> transactions = await transactionService
            .GetAllTransactionByUserIdAsync(user?.Id ?? 0);

        if (transactions.Count <= 0)
            throw new AppException("تراکنشی ثبت نشده است");

        foreach (var transaction in transactions)
        {
            string type = transaction.TransactionType switch
            {
                TransactionType.ManualIncrease => "افزایش دستی \u2705",
                TransactionType.ManualDecrease => "کاهش دستی \u274c",
                TransactionType.Decrease => "کاهش \u2796",
                TransactionType.Increase => "افزایش \u2795",
                _ => ""
            };

            string status = transaction.TransactionStatus switch
            {
                TransactionStatus.Accepted => "تایید شده \u2705",
                TransactionStatus.NotAccepted => "رد شده \u274c",
                _ => "در انتظار برسی \u23f1"
            };

            if (!string.IsNullOrEmpty(transaction.AvatarTransaction))
            {
                using (var stream = new FileStream(
                           PathExtension.TransactionAvatarOriginServer(webHostEnvironment) +
                           transaction.AvatarTransaction,
                           FileMode.Open, FileAccess.Read,
                           FileShare.Read))
                {
                    var inputOnlineFile =
                        new InputFileStream(stream,
                            Path.GetFileName(PathExtension.TransactionAvatarOriginServer(webHostEnvironment) +
                                             transaction.AvatarTransaction));

                    await botClient!.SendPhotoAsync(
                        chatId: chatId,
                        photo: inputOnlineFile,
                        caption: $"""
                                   🕖 تاریخ تراکنش :{PersianDateTimeHelper.GetPersianDateTime(transaction.TransactionTime)}
                                  💸 مبلغ تراکنش : {transaction.Price:N0} تومان
                                   💫 وضعیت تراکنش :{status}
                                   🔢 کد تراکنش :{transaction.TransactionCode}
                                   توضیحات تراکنش :
                                   {transaction.Description}
                                  """,
                        cancellationToken: default
                    );
                }
            }
            else
            {
                await botClient!.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"""
                            🕖 تاریخ تراکنش :{PersianDateTimeHelper.GetPersianDateTime(transaction.TransactionTime)}
                           💸 مبلغ تراکنش : {transaction.Price:N0} تومان
                            💫 وضعیت تراکنش :{status}
                            🔢 کد تراکنش :{transaction.TransactionCode}
                            نوع تراکنش :{type}
                            توضیحات تراکنش :
                            {transaction.Description}
                           """,
                    cancellationToken: cancellationToken
                );
            }
        }

        await ManagementUserAsync(botClient!, new CallbackQuery()
        {
            Data = $"user_management?id={telegramUser.Id}",
            Message = callbackQuery.Message,
        }, cancellationToken, telegramUser);
    }

    public async Task SendUserForLoginToWebAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);
        string password = new Random().Next(100000, 999999).ToString();

        user.Password = PasswordHelper.EncodePasswordMd5(password);

        await userRepository.UpdateEntity(user);
        await userRepository.SaveChanges(user.Id);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: TelegramHelper.SiteInformationText(chatId, password),
            cancellationToken: cancellationToken);
    }

    public async Task SendMenuAgencyManagementAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user?.Id ?? 0);

        if (user?.IsAgent ?? false)
        {
            Message message = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: $"پنل نمایندگی : {agent?.PersianBrandName ?? agent.BrandName ?? "NO_Name"}",
                replyMarkup: TelegramHelper.CreateAgentManagementButton(),
                cancellationToken: cancellationToken
            );
            user.MessageId = message.MessageId;
            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(user.Id);
        }
        else
            await botClient.SendTextMessageAsync(
                chatId,
                "شما به این بخش دسترسی ندارید",
                replyMarkup: new ReplyKeyboardRemove(),
                cancellationToken: cancellationToken);
    }

    public async Task<Message> AgencyManagementAsync(ITelegramBotClient botClient, Message message,
        CancellationToken cancellationToken)
    {
        return await botClient!.SendTextMessageAsync(
            chatId: message.Chat.Id,
            text: "تنظیمات نمایندگی",
            replyMarkup: TelegramHelper.CreateAgentManagementSettingsButton(),
            cancellationToken: cancellationToken
        );
    }

    public async Task<Message> SendListAgentsAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        FilterAgentDto filter = new()
        {
            AdminId = user!.Id,
            TakeEntity = 100,
        };

        filter = await agentService.FilterAgentAsync(filter);

        return await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: """
                  یکی از نماینده هایه لیست زیر را انتخاب کنید !
                  لطفا بر روی نام نمایندگی ضربه بزنید
                  """,
            replyMarkup: TelegramHelper.ListAgents(filter.Entities),
            cancellationToken: cancellationToken);
    }

    public async Task ManagementUserAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message.Chat.Id;

        long Id = 0;

        string? callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData!.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["Id"], out Id);
        }

        User? user = await GetUserByChatIdAsync(chatId);

        User? currentUser = await userRepository.GetEntityById(Id);

        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user.Id);

        if (agent is null)
            throw new AppException("خطا در عملیات");

        if (currentUser is null || currentUser.AgentId != agent.Id) throw new AppException("کاربر وجود نداشت");

        UserInformationDto information = new UserInformationDto();

        List<MarzbanUserDto> marzbanUsers = await marzbanService.GetMarzbanUsersAsync(currentUser.Id);

        List<TransactionDto> transactions =
            await transactionService.GetAllTransactionByUserIdAsync(currentUser.Id);

        if (currentUser.IsAgent)
        {
            AgentDto? admin = await agentService.GetAgentByAdminIdAsync(currentUser.Id);
            List<AgentsIncomesDetail> incomes = await agentService.ListAgentIncomeDetailsByAgentId(admin.Id);
            information.SumAgentIncomes = incomes.Sum(x => x.Profit);
            information.IsAgent = true;

            information.SpecialPercent = (admin.SpecialPercent != 0 & admin?.SpecialPercent != null)
                ? admin.SpecialPercent
                : agent.AgentPercent;

            information.ReferralCount = await userRepository
                .GetQuery()
                .Where(x => x.AgentId == admin.Id).CountAsync(cancellationToken: cancellationToken);
        }

        information.TotalPurchaseAmount = await orderService
            .GetAllUserOrderPriceAsync(currentUser.Id);
        information.CountMarzbanUser = marzbanUsers.Count;
        information.FirstName = currentUser.FirstName;
        information.LastName = currentUser.LastName;
        information.TelegramUserName = currentUser.TelegramUsername;
        information.Mobile = currentUser.Mobile;
        information.TotalPaymentAmount = transactions.Where(x =>
                x.TransactionStatus == TransactionStatus.Accepted && x.TransactionType == TransactionType.Increase)
            .Sum(x => x.Price) ?? 0;
        information.UserStatus = currentUser.UserStatus;
        information.Email = currentUser.Email;
        information.RegistrationDate = PersianDateTimeHelper.GetPersianDate(currentUser.CreateDate);
        information.ChatId = currentUser.ChatId;
        information.CardNumberVisibility = currentUser.CardToCardPayment;
        information.IsBlocked = currentUser.IsBlocked;
        information.Balance = currentUser.Balance;

        telegramUser.Id = information.UserId;

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        if (telegramUser.MessageId != 0)
        {
            try
            {
                await botClient.EditMessageTextAsync(
                    chatId: chatId,
                    messageId: telegramUser.MessageId,
                    text: information.GetInformation(),
                    replyMarkup: TelegramHelper.ManagementUserButtons(currentUser),
                    cancellationToken: cancellationToken);
                cancellationToken = new CancellationToken(true);
                await Task.CompletedTask;
            }
            catch
            {
                await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: information.GetInformation(),
                    replyMarkup: TelegramHelper.ManagementUserButtons(currentUser),
                    cancellationToken: cancellationToken);
                cancellationToken = new CancellationToken(true);
                await Task.CompletedTask;
            }
        }

        if (!cancellationToken.IsCancellationRequested)
        {
            Message message = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: information.GetInformation(),
                replyMarkup: TelegramHelper.ManagementUserButtons(currentUser),
                cancellationToken: cancellationToken);

            telegramUser.MessageId = message.MessageId;
        }
    }

    public async Task IncreaseUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long id = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["Id"], out id);
        }

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendPriceForIncrease;
        telegramUser.Id = id;
        telegramUser.MessageId = callbackQuery.Message.MessageId;

        await botClient!
            .SendTextMessageAsync(
                chatId: chatId,
                text: "لطفا مبلغ ارسالی برای شارژ را به تومان ارسال کنید!",
                cancellationToken: cancellationToken);
    }

    public async Task GiveDescriptionForIncreaseTransactionAsync(ITelegramBotClient? botClient,
        CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long price = TelegramHelper.CheckPrice(callbackQuery.Message.Text);

        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user.Id);

        long remainingBalance = user.Balance - price;

        if (remainingBalance < (agent?.NegativeChargeCeiling ?? 0) & agent?.NegativeChargeCeiling < 0)
            throw new AppException(
                "مبلغ درخواستی باعث می‌شود که موجودی شما بیش از حد مجاز منفی شود! ❌");

        if (user?.Balance < price & agent?.NegativeChargeCeiling == 0)
            throw new AppException(
                "مقدار که برای افزایش موجودی کاربر درخواست داده اید بیشتر از موجودی حساب شما است! ❌");

        telegramUser.IncreasePrice = price;
        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForIncrease;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "توضیحات تراکنش را ارسال کنید !",
            cancellationToken: cancellationToken);
    }

    public async Task IncreaseUserBalanceAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);
        User? child = await userRepository.GetEntityById(telegramUser.Id);

        AddTransactionDto transaction = new AddTransactionDto()
        {
            Description = callbackQuery.Message.Text,
            Price = telegramUser.IncreasePrice,
            Title = "افزایش دستی موجودی",
            TransactionTime = DateTime.Now,
            TransactionType = TransactionType.ManualIncrease,
        };

        await transactionService.IncreaseUserAsync(transaction, child!.Id, user!.Id);

        await notificationService.AddNotificationAsync(
            NotificationTemplate.SendTransactionNotification(transaction, child.Id), user.Id);

        telegramUser.State = TelegramMarzbanVpnSessionState.None;
        await botClient!.SendTextMessageAsync(
            chatId: callbackQuery.Message!.Chat.Id,
            text: $"""
                     مبلغ {telegramUser.IncreasePrice:N0}
                      از حساب شما کم شد و به حساب کاربر شما واریز شد.
                   """,
            cancellationToken: cancellationToken);

        await ManagementUserAsync(botClient!, new CallbackQuery()
        {
            Data = $"user_management?id={child.Id}",
            Message = callbackQuery.Message,
        }, cancellationToken, telegramUser);
    }

    public async Task DecreaseUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long id = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["Id"], out id);
        }

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendPriceForDecrease;
        telegramUser.Id = id;
        telegramUser.MessageId = callbackQuery.Message.MessageId;

        await botClient!
            .SendTextMessageAsync(
                chatId: chatId,
                text: "لطفا مبلغ ارسالی برای کسر شارژ را به تومان ارسال کنید!",
                cancellationToken: cancellationToken);
    }

    public async Task GiveDescriptionForDecreaseTransactionAsync(ITelegramBotClient? botClient,
        CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long price = TelegramHelper.CheckPrice(callbackQuery.Message.Text);

        User? user = await userRepository.GetEntityById(telegramUser.Id);

        if (user?.Balance < price)
            throw new AppException(
                "مقدار که برای کاهش موجودی کاربر درخواست داده اید بیشتر از موجودی حساب کاربر است! ❌");

        telegramUser.DecreasePrice = price;
        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForDecrease;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "توضیحات تراکنش را ارسال کنید !",
            cancellationToken: cancellationToken);
    }

    public async Task DecreaseUserBalanceAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);
        User? child = await userRepository.GetEntityById(telegramUser.Id);

        AddTransactionDto transaction = new AddTransactionDto()
        {
            Description = callbackQuery.Message.Text,
            Price = telegramUser.DecreasePrice,
            Title = "کاهش دستی موجودی",
            TransactionTime = DateTime.Now,
            TransactionType = TransactionType.ManualDecrease,
        };

        await transactionService.DecreaseUserAsync(transaction, child!.Id, user!.Id);

        await notificationService.AddNotificationAsync(
            NotificationTemplate.SendTransactionNotification(transaction, child.Id), user.Id);

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        await botClient!.SendTextMessageAsync(
            chatId: callbackQuery.Message!.Chat.Id,
            text: $"""
                     مبلغ {telegramUser.DecreasePrice:N0}
                      از حساب کاربر کم شد و به حساب  شما واریز شد.
                   """,
            cancellationToken: cancellationToken);

        await ManagementUserAsync(botClient!, new CallbackQuery()
        {
            Data = $"user_management?id={child.Id}",
            Message = callbackQuery.Message,
        }, cancellationToken, telegramUser);
    }

    public async Task BlockUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long id = 0;

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
        }


        User? user = await GetUserByChatIdAsync(chatId);

        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user.Id);

        User? child = await userRepository.GetEntityById(id);

        if (agent?.Id != child?.AgentId)
            throw new AppException("مجاز به بلاک کردن کاربر نیستید");

        child!.IsBlocked = true;

        await userRepository.UpdateEntity(child);
        await userRepository.SaveChanges(user.Id);

        telegramUser.MessageId = callbackQuery.Message.MessageId;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "کاربر غیر فعال شد ❌",
            replyMarkup: null,
            cancellationToken: cancellationToken);

        await ManagementUserAsync(botClient!, new CallbackQuery()
        {
            Data = $"user_management?id={child.Id}",
            Message = callbackQuery.Message,
        }, cancellationToken, telegramUser);
    }

    public async Task OnBlockUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long id = 0;

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
        }


        User? user = await GetUserByChatIdAsync(chatId);

        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user.Id);

        User? child = await userRepository.GetEntityById(id);

        if (agent?.Id != child?.AgentId)
            throw new AppException("مجاز به فعال کردن کاربر نیستید");

        child!.IsBlocked = false;

        await userRepository.UpdateEntity(child);
        await userRepository.SaveChanges(user.Id);

        telegramUser.MessageId = callbackQuery.Message.MessageId;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "کاربر فعال شد ✅",
            replyMarkup: null,
            cancellationToken: cancellationToken);


        await ManagementUserAsync(botClient!, new CallbackQuery()
        {
            Data = $"user_management?id={child.Id}",
            Message = callbackQuery.Message,
        }, cancellationToken, telegramUser);
    }

    public async Task SendTextGiveMessageForUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long id = 0;

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
        }

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendMessageForUser;
        telegramUser.Id = id;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "لطفا پیغام خود را ارسال کنید 💬",
            cancellationToken: cancellationToken);
    }

    public async Task SendMessageForUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        Message message = callbackQuery.Message;

        IFormFile? formFile = null;
        File? file = null;

        string? fileId = message?.Photo?[^1].FileId;

        if (fileId != null && await botClient!.GetFileAsync(
                fileId,
                cancellationToken: cancellationToken) != null)
        {
            file = await botClient!.GetFileAsync(
                message.Photo?[^1].FileId ?? null,
                cancellationToken: cancellationToken);

            using var memoryStream = new MemoryStream();

            await botClient!.DownloadFileAsync(file.FilePath!, memoryStream, cancellationToken);

            memoryStream.Seek(0, SeekOrigin.Begin);

            formFile =
                new FormFile(
                    memoryStream,
                    0,
                    memoryStream.Length,
                    file.FileId, $"{file.FileId}.jpg");

            formFile.AddImageToServer(formFile.FileName,
                PathExtension.TicketAvatarOriginServer(webHostEnvironment)
                , 100, 100,
                PathExtension.TicketAvatarThumbServer(webHostEnvironment));
        }

        User? userValue = await userRepository.GetEntityById(telegramUser.Id);

        await notificationService.AddNotificationAsync(
            NotificationTemplate.SendTicketForUserAsync(
                userValue!.Id,
                userValue.ChatId ?? 0,
                message?.Caption ?? message?.Text,
                DateTime.Now,
                file is not null ? PathExtension.TicketAvatarOriginServer(webHostEnvironment) + formFile.FileName : null
            ), userValue!.Id);

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "پیغام شما با موفقیت برای کاربر ارسال شد ✅",
            cancellationToken: cancellationToken);
    }

    public async Task ChangeStateCardToCardAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser? telegramUser)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long id = 0;
        bool action = false;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["Id"], out id);
            bool.TryParse(queryParameters["action"], out action);
        }

        User? user = await GetUserByChatIdAsync(chatId);

        User? child = await userRepository.GetEntityById(id);

        if (child == null) throw new AppException("چنین کاربری وجود ندارد");

        child!.CardToCardPayment = action;

        await userRepository.UpdateEntity(child);
        await userRepository.SaveChanges(user.Id);

        if (action)
        {
            ButtonJsonDto buttonJson = new ButtonJsonDto("\ud83d\udcb0 افزایش موجودی", "inventory_increase");

            await notificationService.AddNotificationAsync(new AddNotificationDto()
            {
                Message = "درگاه کارت به کارت برای شما فعال شد ✅",
                UserId = child.Id,
                ForAllMember = false,
                Buttons = new()
                {
                    buttonJson
                }
            }, user.Id);
        }


        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: TelegramHelper.ChangeCardToCardText(action),
            replyMarkup: null,
            cancellationToken: cancellationToken);

        await ManagementUserAsync(botClient!, new CallbackQuery()
        {
            Data = $"user_management?id={child.Id}",
            Message = callbackQuery.Message,
        }, cancellationToken, telegramUser);
    }

    public async Task SendTextForGiveSpecialPercent(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        long id = 0;

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
        }

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendSpecialPercent;
        telegramUser.Id = id;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: """
                  لطفا درصدی که در نظر دارید از این نماینده
                  سود بگیرید را ارسال کنید 💰
                  """,
            cancellationToken: cancellationToken);
    }

    public async Task UpdateAgentSpecialPercentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        int specialPercent = TelegramHelper.CheckPercent(callbackQuery.Message.Text);

        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(telegramUser.Id);

        if (agent is null) throw new AppException("کاربر نماینده نیست");

        agent!.SpecialPercent = specialPercent;

        await agentService.UpdateAgentAsync(agent, user!.Id);

        if (specialPercent > 75)
            throw new AppException("""
                                   ⚠️ توجه:
                                   به دلیل محدودیت‌ها 🚫، امکان ثبت درصد تخفیف برای نمایندگان تا سقف ۷۵٪ امکان‌پذیر است.
                                   لطفاً درصد پیشنهادی خود را کمتر از ۷۵٪ ارسال کنید. 🙏
                                   """);

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: $"""
                   درصد سود دریافتی شما
                   از نماینده
                   به {agent.PersianBrandName ?? agent.BrandName ?? "NOUSERNAME"}
                   {specialPercent} درصد
                    تغییر پیدا کرد🔢
                   """,
            cancellationToken: cancellationToken
        );

        await ManagementUserAsync(botClient!, new CallbackQuery()
        {
            Data = $"user_management?id={telegramUser.Id}",
            Message = callbackQuery.Message,
        }, cancellationToken, telegramUser);
    }

    public async Task UpdateAgentBrandingNameAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendPersianBrandName;

        User? user = await GetUserByChatIdAsync(chatId);

        AgentInformationDto agentInformation = await agentService.GetAgentInformationAsync(user.Id);

        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: TelegramHelper.BrandingInformationText(agentInformation),
            cancellationToken: cancellationToken
        );
    }

    public async Task SendTextEngilishBrandNameAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        string persianBrand = TelegramHelper.CheckBrandName(callbackQuery.Message.Text);

        telegramUser.PersionBrandName = persianBrand;
        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendEnglishBrandName;

        await botClient!.SendTextMessageAsync(
            chatId: callbackQuery.Message.Chat.Id,
            text: TelegramHelper.SendTextGiveEngilishBrandName,
            cancellationToken: cancellationToken
        );
    }

    public async Task SetBrandingNameAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        string engilishBrand = TelegramHelper.CheckBrandName(callbackQuery.Message.Text);
        if (!EnglishText.IsValidUsername(callbackQuery.Message.Text))
            throw new AppException(TelegramHelper.SendTextGiveEngilishBrandName);

        User? user = await GetUserByChatIdAsync(chatId);

        AgentDto agent = await agentService.GetAgentByAdminIdAsync(user.Id);

        agent.PersianBrandName = telegramUser.PersionBrandName;
        agent.BrandName = engilishBrand;

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        await agentService.UpdateAgentAsync(agent, user.Id);

        await botClient!.SendTextMessageAsync(
            chatId: callbackQuery.Message.Chat.Id,
            text: """
                  نام نمایندگی با موفقیت تغییر کرد ✅
                  """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken
        );
    }

    public async Task SendTextForUpdateAgentCardDetailInformationAsync(ITelegramBotClient? botClient,
        CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendCardNumber;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: """
                  لطفا شماره کارت 16 رقمی خود را ارسال کنید! ⚠️
                  فرمت درست 6037696975758585 ✅
                  """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken
        );
    }

    public async Task SetCardNumberAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        string cardnumber = TelegramHelper.CheckCardNumber(callbackQuery.Message.Text);

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendCardHolderName;
        telegramUser.CardNumber = cardnumber;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: """
                  لطفا نام صاحب
                  شماره کارت را
                  به صورت دقیق
                  وارد کنید!
                  """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken
        );
    }

    public async Task UpdateAgentCardDetailAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        string holdername = TelegramHelper.CheckHolderName(callbackQuery.Message.Text);

        long chatId = callbackQuery.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        AgentDto? agent = await agentService
            .GetAgentByAdminIdAsync(user?.Id);

        TransactionDetailDto transactionDetail = new()
        {
            CardNumber = telegramUser.CardNumber,
            CardHolderName = holdername,
            Id = agent.TransactionDetailId
        };

        await transactionService.UpdateTransactionDetailsAsync(transactionDetail, user!.Id);

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: """
                  اطلاعات پرداخت شما با موقیت ثبت شد ✅
                  """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);
    }

    public async Task SendAgentTransactionPaymentDetailAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user!.Id);
        TransactionDetailDto? transactionDetail = await transactionService.GetTransactionDetailsAsync(agent!.Id);

        if (transactionDetail is null)
            throw new ApplicationException("اطلاعات پرداخت ثبت نشده");

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: TelegramHelper.TransactionDeatilText(transactionDetail),
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);
    }

    public async Task SendTextUpdateAgentPercentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendAgentPercent;

        AgentInformationDto agentInformation = await agentService.GetAgentInformationAsync(user.Id);

        await botClient!.SendTextMessageAsync(
            chatId,
            $"""
             درصد سود فروش از نماینده ها : {agentInformation?.AgentPercent ?? 0}
              درصد سود خود را ارسال کنید ♻️
             """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);
    }

    public async Task SendTextUpdateUserPercentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendUserPercent;
        
        AgentInformationDto agentInformation = await agentService.GetAgentInformationAsync(user.Id);

        await botClient!.SendTextMessageAsync(
            chatId,
            $"""
             درصد سود فروش از کاربر ها : {agentInformation?.UserPercent ?? 0}
              درصد سود خود را ارسال کنید ♻️
             """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);
    }

    public async Task UpdateAgentPercentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        int percent = TelegramHelper.CheckPercent(callbackQuery.Message.Text);

        if (percent > 75)
            throw new AppException("""
                                   ⚠️ توجه:
                                   به دلیل محدودیت‌ها 🚫، امکان ثبت درصد تخفیف برای نمایندگان تا سقف ۷۵٪ امکان‌پذیر است.
                                   لطفاً درصد پیشنهادی خود را کمتر از ۷۵٪ ارسال کنید. 🙏
                                   """);

        
        User? user = await GetUserByChatIdAsync(chatId);

        AgentDto agent = await agentService.GetAgentByAdminIdAsync(user.Id);

        agent.AgentPercent = percent;

        await agentService.UpdateAgentAsync(agent, user.Id);

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        await botClient!.SendTextMessageAsync(
            chatId: callbackQuery.Message.Chat.Id,
            text: """
                  درصد نمایندگی با موفقیت تغییر کرد ✅
                  """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);
    }

    public async Task UpdateUserPercentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        int percent = TelegramHelper.CheckPercent(callbackQuery.Message.Text);
        
        if (percent > 500)
            throw new AppException("""
                                   ⚠️ توجه:
                                   به دلیل محدودیت‌ها 🚫، امکان ثبت درصد تخفیف برای نمایندگان تا سقف 500٪ امکان‌پذیر است.
                                   لطفاً درصد پیشنهادی خود را کمتر از 500٪ ارسال کنید. 🙏
                                   """);
        
        User? user = await GetUserByChatIdAsync(chatId);

        AgentDto agent = await agentService.GetAgentByAdminIdAsync(user.Id);

        agent.UserPercent = percent;

        await agentService.UpdateAgentAsync(agent, user.Id);

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        await botClient!.SendTextMessageAsync(
            chatId: callbackQuery.Message.Chat.Id,
            text: """
                  درصد کاربری با موفقیت تغییر کرد ✅
                  """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);
    }

    public async Task SendTextUpdatePaymentForAgentOptionAsync(ITelegramBotClient? botClient,
        CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendMaximumAmountForAgent;

        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user!.Id);
        TransactionDetailDto? transactionDetail = await transactionService.GetTransactionDetailsAsync(agent!.Id);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: TelegramHelper.TextAgentPaymentOption(transactionDetail),
            cancellationToken: cancellationToken);
    }

    public async Task GiveMaximumPaymentForAgent(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long price = TelegramHelper.CheckPrice(callbackQuery.Message!.Text);

        telegramUser.MaximumAmountForAgent = price;

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendMinimalAmountForAgent;

        await botClient!.SendTextMessageAsync(
            chatId: callbackQuery.Message.Chat.Id,
            text: """
                  لطفا کف پرداخت نماینده را ارسال کنید 🟢
                  """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);
    }

    public async Task SetPaymentOptionForAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        long price = TelegramHelper.CheckPrice(callbackQuery.Message!.Text);

        if (price > telegramUser.MaximumAmountForAgent)
            throw new AppException("نمیتواند سقف پرداخت کمتر از کف پرداخت باشد.");

        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user?.Id);

        await transactionService.UpdateTransactionDetailsAsync(new TransactionDetailDto()
        {
            Id = agent!.TransactionDetailId,
            MaximumAmountForAgent = telegramUser.MaximumAmountForAgent,
            MinimalAmountForAgent = price,
        }, user!.Id);

        await botClient!.SendTextMessageAsync(
            chatId: callbackQuery.Message.Chat.Id,
            text: """
                  عملیات با موفقیت انجام شد ✅
                  """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);

        telegramUser.State = TelegramMarzbanVpnSessionState.None;
    }

    public async Task SendTextUpdatePaymentForUserOptionAsync(ITelegramBotClient? botClient,
        CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendMaximumAmountForUser;

        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user!.Id);
        TransactionDetailDto? transactionDetail = await transactionService.GetTransactionDetailsAsync(agent!.Id);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: TelegramHelper.TextUserPaymentOption(transactionDetail),
            cancellationToken: cancellationToken);
    }

    public async Task GiveMaximumPaymentForUser(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long price = TelegramHelper.CheckPrice(callbackQuery.Message!.Text);

        telegramUser.MaximumAmountForUser = price;

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendMinimalAmountForUser;

        await botClient!.SendTextMessageAsync(
            chatId: callbackQuery.Message.Chat.Id,
            text: """
                  لطفا کف پرداخت کاربری را ارسال کنید 🟢
                  """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);
    }

    public async Task SetPaymentOptionForUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        long price = TelegramHelper.CheckPrice(callbackQuery.Message!.Text);

        if (price > telegramUser.MaximumAmountForUser)
            throw new AppException("نمیتواند سقف پرداخت کمتر از کف پرداخت باشد.");

        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user?.Id);

        await transactionService.UpdateTransactionDetailsAsync(new TransactionDetailDto()
        {
            Id = agent!.TransactionDetailId,
            MaximumAmountForUser = telegramUser.MaximumAmountForUser,
            MinimalAmountForUser = price,
        }, user!.Id);

        await botClient!.SendTextMessageAsync(
            chatId: callbackQuery.Message.Chat.Id,
            text: """
                  عملیات با موفقیت انجام شد ✅
                  """,
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);

        telegramUser.State = TelegramMarzbanVpnSessionState.None;
    }

    public async Task SendAgentInformationAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        User? user = await GetUserByChatIdAsync(chatId);
        AgentInformationDto agentInformation = await agentService.GetAgentInformationAsync(user.Id);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: agentInformation?.Information_Text() ?? "NO RESULT",
            cancellationToken: cancellationToken);
    }

    public async Task SendTextSearchUserByChatAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSearchUserByChatId;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            "ایدی عددی کاربر را ارسال کنید 🔍",
            cancellationToken: cancellationToken);
    }

    public async Task AddAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        long Id = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');
        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out Id);
        }

        User? parentUser = await GetUserByChatIdAsync(chatId);
        User? user = await userRepository.GetEntityById(Id);

        AddAgentDto agent = new()
        {
            AgentAdminId = user.Id,
            BrandName = "",
            PersianBrandName = user.UserFullName(),
            BrandAddress = "",
        };

        await agentService.AddAgentAsync(agent, parentUser.Id);

        await notificationService.AddNotificationAsync(new AddNotificationDto()
        {
            Message = "شما با موفقیت نماینده شدید ✅",
            UserId = user.Id,
            Buttons = new()
            {
                new("مدیریت پنل نمایندگی 🏢", "agency_management")
            },
        }, user.Id);
        telegramUser.Id = Id;

        await botClient!.SendTextMessageAsync(chatId, "کاربر با موفقیت نماینده شده ✅",
            cancellationToken: cancellationToken);

        await ManagementUserAsync(botClient!, new CallbackQuery()
        {
            Data = $"user_management?id={telegramUser.Id}",
            Message = callbackQuery.Message,
        }, cancellationToken, telegramUser);
    }

    public async Task SendMenuForSendMessageByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "ارسال پیام به زیرمجموعه ها : 💬",
            replyMarkup: TelegramHelper.CreateListTypeOfSendMessageButton(),
            cancellationToken: cancellationToken
        );
    }

    public async Task SendMenuForSelectedUserGroupingByAgentAsync(ITelegramBotClient? botClient,
        CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        string? messageType = null;

        string? callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData!.IndexOf('?');
        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            messageType = queryParameters["type"];
        }

        telegramUser.SendMessageType = messageType;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "لیست گروه های کاربری 👥 : ",
            replyMarkup: TelegramHelper.CreateListUserGroupingSendMessageButton(),
            cancellationToken: cancellationToken
        );
    }

    public async Task SubmitListingsButtonsAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        string? group = null;

        telegramUser.Message = "";

        string? callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData!.IndexOf('?');
        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            group = queryParameters["group"];
        }

        telegramUser.UserGroup = group;

        switch (telegramUser.SendMessageType)
        {
            case "forward":
                telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingForwardMessage;
                await botClient!.SendTextMessageAsync(
                    chatId: chatId,
                    text: """
                          لطفا پیام مورد نظر را فوروارد کنید ! 🛩
                          در صورت انصراف از ارسال پیام روی دکمه بازگشت به منو اصلی کیلیک کنید⚠️
                          """,
                    replyMarkup: TelegramHelper.ButtonBackToHome(),
                    cancellationToken: cancellationToken
                );
                break;
            case "custom":
                telegramUser.State = TelegramMarzbanVpnSessionState.AwaitingSendListButtons;
                await botClient!.SendTextMessageAsync(
                    chatId: chatId,
                    text: """
                          📝 لطفاً متن پیام خود را وارد کنید:

                          🖊️ منتظر دریافت پیام شما هستیم!
                          """,
                    replyMarkup: TelegramHelper.ButtonBackToHome(),
                    cancellationToken: cancellationToken);
                break;
        }
    }

    public async Task ForwardMessageForUserAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user!.Id);

        switch (telegramUser.UserGroup)
        {
            case "all":
                List<UserDto>? users = await agentService.GetAgentUserAsync(agent.Id);

                await notificationService.AddNotificationsAsync(
                    NotificationTemplate.ForwardMessageForUsers(
                        userIds: users.Select(x => x.Id).ToList(),
                        createServiceTime: DateTime.Now,
                        forwardChatId: chatId,
                        messageId: callbackQuery!.Message!.MessageId
                    ),
                    agent.AgentAdminId);
                break;
            case "agent":
                AgentTreeDto agents = await agentService.GetAgentsChildByFilterAsync(agent.AgentAdminId);
                await notificationService.AddNotificationsAsync(
                    NotificationTemplate.ForwardMessageForUsers(
                        userIds: agents.SubAgents.Select(x => x.AgentAdminId).ToList(),
                        createServiceTime: DateTime.Now,
                        forwardChatId: chatId,
                        messageId: callbackQuery!.Message!.MessageId
                    ),
                    agent.AgentAdminId);
                break;
        }


        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "پیغام شما با موفقیت به صف ارسال رفت ✅",
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);
    }

    public async Task SendListButtonsForSendMessage(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        telegramUser.Message = callbackQuery.Message.Text;

        telegramUser.State = TelegramMarzbanVpnSessionState.None;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: """
                  📋 لطفا دکمه مورد نظر را انتخاب کنید برای ارسال پیام:
                     
                  🟢 برای انتخاب یک دکمه از لیست زیر، روی آن کلیک کنید.

                  🚫 در صورتی که می‌خواهید پیام بدون دکمه ارسال شود، روی دکمه «📭 پیام بدون دکمه ارسال شود» کلیک کنید.
                  """,
            replyMarkup: TelegramHelper.CreateListButtonsForSendMessage(),
            cancellationToken: cancellationToken);
    }

    public async Task SendMessageAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser? telegramUser)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        User? user = await GetUserByChatIdAsync(chatId);
        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(user!.Id);


        string? custom_query = null;
        string? text = null;

        string? callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData!.IndexOf('?');
        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            custom_query = queryParameters["query"];
            text = queryParameters["text"];
        }

        ButtonJsonDto? button = custom_query != "null" ? new ButtonJsonDto(text, custom_query) : null;

        switch (telegramUser.UserGroup)
        {
            case "all":
                List<UserDto>? users = await agentService.GetAgentUserAsync(agent.Id);
                await notificationService.AddNotificationsAsync(
                    NotificationTemplate.SendMessageForUsers(
                        userIds: users.Select(x => x.Id).ToList(),
                        createServiceTime: DateTime.Now,
                        telegramUser.Message ?? "",
                        button: button
                    ),
                    agent.AgentAdminId);
                break;

            case "agent":
                AgentTreeDto agents = await agentService.GetAgentsChildByFilterAsync(agent.AgentAdminId);
                await notificationService.AddNotificationsAsync(
                    NotificationTemplate.SendMessageForUsers(
                        userIds: agents.SubAgents.Select(x => x.AgentAdminId).ToList(),
                        createServiceTime: DateTime.Now,
                        telegramUser.Message ?? "",
                        button: button
                    ),
                    agent.AgentAdminId);
                break;
        }

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "پیغام شما با موفقیت به صف ارسال رفت ✅",
            replyMarkup: TelegramHelper.ButtonBackToHome(),
            cancellationToken: cancellationToken);
    }

    public async Task UpdateCreatedTopicAsync(TelegramGroupTopics telegramGroupTopic)
    {
        await telegramGroupTopicRepository.UpdateEntity(telegramGroupTopic);
        await telegramBotRepository.SaveChanges(1);
    }
}