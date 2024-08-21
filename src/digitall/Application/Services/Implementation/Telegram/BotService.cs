using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Runtime.InteropServices.JavaScript;
using System.Web;
using Application.Extensions;
using Application.Helper;
using Application.Services.Interface.Telegram;
using Application.Sessions;
using Application.Utilities;
using Domain.DTOs.Agent;
using Domain.DTOs.Marzban;
using Domain.DTOs.Telegram;
using Domain.DTOs.Transaction;
using Domain.Entities.Agent;
using Domain.Entities.Marzban;
using Domain.Entities.Telegram;
using Domain.Enums.Marzban;
using Domain.Enums.Transaction;
using Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Serilog;
using Serilog.Core;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using ILogger = Microsoft.Extensions.Logging.ILogger;
using User = Domain.Entities.Account.User;

namespace Application.Services.Implementation.Telegram;

public class BotService(ITelegramService telegramService, ILogger<BotService> logger) : IBotService
{
    private static ConcurrentDictionary<long, TelegramMarzbanVpnSession>? userSessions =
        new ConcurrentDictionary<long, TelegramMarzbanVpnSession>();

    public async Task SendUserForLoginToWebAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        try
        {
            string? password = await telegramService.ResetUserPasswordAsync(chatId);

            #region message

            string information = $@"
👤 نام کاربری شما :{chatId}       
       🔐 کلمه عبور جدید: {password}
";

            #endregion

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: information,
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task<Message> StartLinkAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long agentId = 0;
        try
        {
            if (message.Text != null && message.Text.StartsWith("/start"))
            {
                Int64.TryParse((message.Text.Substring(6)), out agentId);
            }

            AgentOptionDto? agentOptions = await telegramService.StartTelegramBotAsync(new StartTelegramBotDto()
            {
                AgentCode = agentId,
                ChatId = message.Chat.Id,
                FirstName = message.From.FirstName,
                LastName = message.From.LastName,
                BotId = botClient.BotId,
                TelegramUsername = message.From.Username
            });

            IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

            keys.Add(new List<InlineKeyboardButton>()
            {
                InlineKeyboardButton.WithCallbackData("تست رایگان 😎", "test_free"),
                InlineKeyboardButton.WithCallbackData("خرید اشتراک 🔒", "subscribe")
            });

            keys.Add(new List<InlineKeyboardButton>()
            {
                InlineKeyboardButton.WithCallbackData("سرویس های من 🎁", "my_services"),
            });

            keys.Add(new()
            {
                InlineKeyboardButton.WithCallbackData("در خواست نمایندگی ♻️", "agent_request"),
                InlineKeyboardButton.WithCallbackData("کیف پول + شارژ 🏦", "wallet")
            });

            keys.Add(new()
            {
                InlineKeyboardButton.WithCallbackData("کلمه عبور و نام کاربری سایت 🔒",
                    "web_information")
            });

            keys.Add(new()
            {
                InlineKeyboardButton.WithCallbackData("همکاری در فروش 🤝",
                    "invitation_link")
            });

            InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keys);

            return await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: agentOptions!.WelcomeMessage ?? "خوش آمدید",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            return await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendMainMenuAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, string? title = null)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        bool isAgent = await telegramService.IsAgentAsyncByChatIdAsync(chatId);

        if (isAgent)
            await SendAgentMenuForAdmin(botClient, chatId, cancellationToken);
        else
            await DeleteMenu(botClient, callbackQuery.Message, cancellationToken);

        BotSessions
            .users_Sessions?
            .AddOrUpdate(chatId, new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.None),
                (key, old)
                    => old = new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.None));

        IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

        keys.Add(new List<InlineKeyboardButton>()
        {
            InlineKeyboardButton.WithCallbackData("تست رایگان 😎", "test_free"),
            InlineKeyboardButton.WithCallbackData("خرید اشتراک 🔒", "subscribe")
        });

        keys.Add(new List<InlineKeyboardButton>()
        {
            InlineKeyboardButton.WithCallbackData("سرویس های من 🎁", "my_services"),
        });

        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("در خواست نمایندگی ♻️", "agent_request"),
            InlineKeyboardButton.WithCallbackData("کیف پول + شارژ 🏦", "wallet")
        });

        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("کلمه عبور و نام کاربری سایت 🔒",
                "web_information")
        });

        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("همکاری در فروش 🤝",
                "invitation_link")
        });

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }

        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keys);

        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: title ?? "به منو اصلی بازگشتید 🏠",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);
    }

    public async Task<Message> SendMainMenuAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken,
        string? title = null)
    {
        long chatId = message.Chat.Id;

        bool isAgent = await telegramService.IsAgentAsyncByChatIdAsync(chatId);

        if (isAgent)
            await SendAgentMenuForAdmin(botClient, chatId, cancellationToken);
        else
            await DeleteMenu(botClient, message, cancellationToken);

        BotSessions
            .users_Sessions?
            .AddOrUpdate(chatId, new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.None),
                (key, old)
                    => old = new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.None));

        IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

        keys.Add(new List<InlineKeyboardButton>()
        {
            InlineKeyboardButton.WithCallbackData("تست رایگان 😎", "test_free"),
            InlineKeyboardButton.WithCallbackData("خرید اشتراک 🔒", "subscribe")
        });

        keys.Add(new List<InlineKeyboardButton>()
        {
            InlineKeyboardButton.WithCallbackData("سرویس های من 🎁", "my_services"),
        });

        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("در خواست نمایندگی ♻️", "agent_request"),
            InlineKeyboardButton.WithCallbackData("کیف پول + شارژ 🏦", "wallet")
        });

        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("کلمه عبور و نام کاربری سایت 🔒",
                "web_information")
        });

        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("همکاری در فروش 🤝",
                "invitation_link")
        });

        if (message.MessageId != 0)
        {
            await botClient.DeleteMessageAsync(chatId, message.MessageId, cancellationToken);
        }

        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keys);

        return await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: title ?? "به منو اصلی بازگشتید 🏠",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);
    }

    public async Task SendListVpnsAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

        List<MarzbanVpnBotDto> vpns = await telegramService.GetMarzbanVpnsAsync();

        foreach (MarzbanVpnBotDto vpn in vpns)
        {
            List<InlineKeyboardButton> button = new()
            {
                InlineKeyboardButton.WithCallbackData(vpn.Title, "vpn_template?id=" + vpn.Id)
            };
            keys.Add(button);
        }

        List<InlineKeyboardButton> home = new()
        {
            InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
        };

        keys.Add(home);

        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keys);

        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "اشتراک خود را انتخاب نمایید. 📌",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task SendListVpnsHaveTestAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

        List<MarzbanVpnTestDto> vpns = await telegramService.GetListMarzbanVpnTestAsync();

        foreach (MarzbanVpnTestDto vpn in vpns)
        {
            List<InlineKeyboardButton> button = new()
            {
                InlineKeyboardButton.WithCallbackData(vpn.Title, "createtestsub?id=" + vpn.Id)
            };
            keys.Add(button);
        }

        List<InlineKeyboardButton> home = new()
        {
            InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
        };

        keys.Add(home);

        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keys);

        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: " موقعیت سرویس را انتخاب نمایید. 📌",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task SendTestSubscibeAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
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

        MarzbanUserInformationDto user =
            await telegramService
                .GetMarzbanTestVpnsAsync(id, callbackQuery!.Message!.Chat.Id);

        MarzbanVpnDto? vpn = await telegramService
            .GetMarzbanVpnInformationByIdAsync(id, chatId);

        byte[] QrImage = await GenerateQrCode
            .GetQrCodeAsync(user.Subscription_Url);

        string caption = $@"
✅ سرویس با موفقیت ایجاد شد

👤 نام کاربری سرویس: {user.Username.TrimEnd()}
🌿 نام سرویس: {vpn.Name.TrimEnd()}
⏳ مدت زمان: {vpn.Test_Days} روز
🗜 حجم سرویس: {vpn.Test_TotalGb} مگابایت
لینک اتصال:
{user.Subscription_Url.TrimEnd()}
";
        using (var Qr = new MemoryStream(QrImage))
        {
            await botClient.SendPhotoAsync(
                chatId: callbackQuery.Message.Chat.Id,
                photo: new InputFileStream(Qr, user.Username),
                caption: caption,
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendListVpnsTemplateAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        try
        {
            IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

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

            List<MarzbanVpnTemplateDto>
                templates = await telegramService.GetMarzbanVpnTemplatesByVpnIdAsync(id, chatId);

            foreach (MarzbanVpnTemplateDto template in templates)
            {
                List<InlineKeyboardButton> button = new()
                {
                    InlineKeyboardButton.WithCallbackData(
                        (template!.Days! + " روزه ") +
                        (template.Gb > 200 ? " نامحدود " : template.Gb + " گیگ ")
                        + (template.Price + " تومان "),
                        "factor_subscribe?id=" + template.Id + "&vpnId=" + id + "&subscribeId=" + subscribeId)
                };
                keys.Add(button);
            }

            List<InlineKeyboardButton> custom = new()
            {
                InlineKeyboardButton.WithCallbackData("\ud83d\udecd حجم و زمان دلخواه",
                    "custom_subscribe?vpnId=" + id + "&subscribeId" + subscribeId)
            };

            List<InlineKeyboardButton> home = new()
            {
                InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
            };

            keys.Add(custom);
            keys.Add(home);

            InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keys);

            await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: " نوع سرویس خود را انتخاب کنید. 📌",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);

            if (callbackQuery.Message.MessageId != 0)
            {
                await botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
            }
        }
        catch (Exception e)
        {
            await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
            await SendMainMenuAsync(botClient, callbackQuery, cancellationToken);
        }
    }

    public async Task SendFactorVpnAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

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

        IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

        List<InlineKeyboardButton> bu = new()
        {
            InlineKeyboardButton.WithCallbackData("پرداخت و دریافت سرویس", $"buy_subscribe" +
                                                                           $"?templateId={id}" +
                                                                           $"&marzbanvpnid={vpnId}" +
                                                                           $"&subscribeId={subscribeId}")
        };
        List<InlineKeyboardButton> home = new()
        {
            InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
        };

        keys.Add(bu);
        keys.Add(home);

        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keys);

        SubscribeFactorBotDto sub = await telegramService.SendFactorSubscribeAsync(buy, chatId);

        KeyValuePair<long, TelegramMarzbanVpnSession>? userSesstion = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        TelegramMarzbanVpnSession? uservalue = userSesstion?.Value;

        // if (uservalue is null)

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: uservalue?.UserSubscribeId != null ? sub.GetRenewalInfo() : sub.GetInfo(),
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task SendSubscriptionAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        try
        {
            long templateId = 0;
            long marzbanvpnid = 0;
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
                Int64.TryParse(queryParameters["marzbanvpnid"], out marzbanvpnid);
                Int32.TryParse(queryParameters["days"], out days);
                Int32.TryParse(queryParameters["gb"], out gb);
                Int64.TryParse(queryParameters["subscribeId"], out subscribeId);
            }

            KeyValuePair<long, TelegramMarzbanVpnSession>? userSesstion = BotSessions
                .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

            TelegramMarzbanVpnSession? uservalue = userSesstion?.Value;

            BuyMarzbanVpnDto buy = new();

            buy.MarzbanVpnId = marzbanvpnid;
            buy.MarzbanVpnTemplateId = templateId;
            buy.Count = 1;
            buy.TotalDay = days;
            buy.TotalGb = gb;
            buy.MarzbanUserId = uservalue?.UserSubscribeId;

            MarzbanVpnTemplateDto? template = null;

            if (templateId != 0)
                template = await telegramService.GetMarzbanTemplateByIdAsync(templateId);

            List<MarzbanUser> marzbanUsers = await telegramService.BuySubscribeAsync(buy, chatId);

            foreach (MarzbanUser user in marzbanUsers)
            {
                byte[] QrImage = await GenerateQrCode
                    .GetQrCodeAsync(user?.Subscription_Url);

                string caption = $@"
✅ سرویس با موفقیت ایجاد شد

👤 نام کاربری سرویس: {user.Username.TrimEnd()}
🌿 نام سرویس: {template?.Title ?? "خرید اشتراک"}
⏳ مدت زمان: {template?.Days ?? days} روز
👥 حجم سرویس: {((template?.Gb ?? gb) > 200 ? "نامحدود" : (template?.Gb ?? gb) + "گیگ")}
لینک اتصال:
{user.Subscription_Url.TrimEnd()}
";
                using (var Qr = new MemoryStream(QrImage))
                {
                    await botClient.SendPhotoAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        photo: new InputFileStream(Qr, user.Subscription_Url),
                        caption: caption,
                        cancellationToken: cancellationToken);
                }
            }

            BotSessions
                .users_Sessions?
                .AddOrUpdate(chatId, new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.None),
                    (key, old)
                        => old = new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.None));


            await SendMainMenuAsync(botClient, callbackQuery, cancellationToken);
        }
        catch (Exception e)
        {
            await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
            await SendMainMenuAsync(botClient, callbackQuery, cancellationToken);
        }
    }

    public async Task SendListServicesAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
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
        Domain.Entities.Account.User? user = await telegramService.GetUserByChatIdAsync(chatId);
        filter.UserId = user.Id;
        filter.Page = page;
        FilterMarzbanUser users = await telegramService.FilterMarzbanUsersList(filter);

        IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

        foreach (var us in users.Entities)
        {
            List<InlineKeyboardButton> key = new()
            {
                InlineKeyboardButton.WithCallbackData(us.Username, $"subscribe_info?id={us.Id}&vpnId={us.MarzbanVpnId}")
            };
            keys.Add(key);
        }

        List<InlineKeyboardButton> beforAfter = new();

        if (page != 1)
            beforAfter.Add(InlineKeyboardButton.WithCallbackData("قبلی",
                $"my_services?page={page - 1}"));
        if (page * filter.TakeEntity < filter.AllEntitiesCount)
            beforAfter.Add(InlineKeyboardButton.WithCallbackData("بعدی",
                $"my_services?page={page + 1}"));

        List<InlineKeyboardButton> home = new()
        {
            InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
        };

        keys.Add(beforAfter);
        keys.Add(home);

        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keys);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text:
            "\ud83d\udecd اشتراک های خریداری شده توسط شما\n\n\u26a0\ufe0fبرای مشاهده اطلاعات و مدیریت روی نام کاربری کلیک کنید",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task SendSubscribeInformationAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long id = 0;
        int vpnId = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["id"], out id);
            Int32.TryParse(queryParameters["vpnId"], out vpnId);
        }

        SubescribeStatus.ServiceStatus? status = await telegramService.GetMarzbanUserByChatIdAsync(id, chatId);

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        TelegramMarzbanVpnSession? uservalue = user?.Value;

        if (uservalue is null)
            uservalue = new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.None, UserSubscribeId: id);

        uservalue.UserSubscribeId = id;

        BotSessions
            .users_Sessions?
            .AddOrUpdate(chatId, uservalue,
                (key, old)
                    => old = uservalue);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("تغییر لینک ⚙️", $"revoke_sub"),
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("دریافت ترافیک 🌍", $"get_traffic?id={id}"),
                InlineKeyboardButton.WithCallbackData("لینک اشتراک 🔗", $"subscription_link?id={id}")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("تمدید سرویس 💊", $"vpn_template" +
                                                                        $"?id={vpnId}&" +
                                                                        $"subscribeId={id}"),
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("خرید حجم اضافه ➕",
                    $"custom_subscribe?vpnId={vpnId}&appendGb=true"),
                InlineKeyboardButton.WithCallbackData("خرید زمان اضافه ⌛️",
                    $"append_date?vpnId={vpnId}&subscribeId={id}"),
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("حذف سرویس ❌", $"delete_service")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("فعال کردن 🤞", "active_service"),
                InlineKeyboardButton.WithCallbackData(" غیر فعال کردن ❌", "disabled_service"),
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("بازگشت به لیست سرویس‌ها 🏠", "my_services")
            }
        });

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: status.GetInfo(),
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task SendConfigsAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
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

        List<string> links = await telegramService.GetMarzbanSubscibtionLiknsAsync(id, chatId);

        foreach (string link in links)
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

    public async Task SendSubscribeAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
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

        string? subscribe = await telegramService.GetSubscibetionAsync(id, chatId);

        byte[] QrImage = await GenerateQrCode
            .GetQrCodeAsync(subscribe);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("بازگشت 🌍", $"subscribe_info?id={id}"),
            },
        });

        using (var Qr = new MemoryStream(QrImage))
        {
            await botClient.SendPhotoAsync(
                chatId: callbackQuery.Message.Chat.Id,
                photo: new InputFileStream(Qr, subscribe),
                caption: subscribe,
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendGbPriceAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        try
        {
            int vpnId = 0;
            bool appendGb = false;
            string callbackData = callbackQuery.Data;
            int questionMarkIndex = callbackData.IndexOf('?');
            long subscribeId = 0;

            if (questionMarkIndex >= 0)
            {
                string? query = callbackData?.Substring(questionMarkIndex);
                NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
                Boolean.TryParse(queryParameters["appendGb"], out appendGb);
                Int32.TryParse(queryParameters["vpnId"], out vpnId);
                Int64.TryParse(queryParameters["subscribeId"], out subscribeId);
            }

            MarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(vpnId, chatId);

            KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
                .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

            TelegramMarzbanVpnSession? uservalue = user?.Value;
            if (uservalue is null)
                uservalue = new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.None);

            uservalue.VpnId = vpnId;
            if (!appendGb)
            {
                uservalue.State = TelegramMarzbanVpnSessionState.AwaitingGb;

                BotSessions
                    .users_Sessions?
                    .AddOrUpdate(chatId,
                        new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.AwaitingGb, vpnId: vpnId),
                        (key, old)
                            => old = old);
            }
            else
            {
                uservalue.State = TelegramMarzbanVpnSessionState.AwaitingSendAppendGbForService;

                BotSessions
                    .users_Sessions?
                    .AddOrUpdate(chatId,
                        new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.AwaitingSendAppendGbForService,
                            vpnId: vpnId),
                        (key, old)
                            => old = old);
            }

            string deatils = $@"📌 حجم درخواستی خود را ارسال کنید.
🔔قیمت هر گیگ حجم {vpn?.GbPrice ?? 0} تومان می باشد.
🔔 حداقل حجم {vpn?.GbMin ?? 0} گیگابایت و حداکثر {vpn?.GbMax ?? 0} گیگابایت می باشد.";

            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
                }
            });

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: deatils,
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendDaysPriceAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message!.Chat.Id;

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);
        var uservalue = user.Value.Value;

        MarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(uservalue.VpnId ?? 0, chatId);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
            }
        });

        if (uservalue.Gb > vpn?.GbMax | uservalue.Gb < vpn?.GbMin | uservalue.Gb == 0)
        {
            uservalue.State = TelegramMarzbanVpnSessionState.AwaitingGb;
            BotSessions
                .users_Sessions?
                .AddOrUpdate(chatId, uservalue,
                    (key, old)
                        => old = uservalue);

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text:
                $"\u274c حجم نامعتبر است.\n\ud83d\udd14 حداقل حجم {vpn.GbMin} گیگابایت و حداکثر {vpn.GbMax} گیگابایت می باشد",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
        else
        {
            uservalue.State = TelegramMarzbanVpnSessionState.AwaitingDate;

            BotSessions
                .users_Sessions?
                .AddOrUpdate(chatId, uservalue,
                    (key, old)
                        => old = uservalue);

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text:
                $"\u231b\ufe0f زمان سرویس خود را انتخاب نمایید \n\ud83d\udccc تعرفه هر روز  : {vpn?.DayPrice}  تومان\n\u26a0\ufe0f حداقل زمان {vpn?.DayMin} روز  و حداکثر {vpn?.DayMax} روز  می توانید تهیه کنید",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendCustomFactorVpnAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message!.Chat.Id;

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        var uservalue = user.Value.Value;

        MarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(uservalue.VpnId ?? 0, chatId);
        User? mainUser = await telegramService.GetUserByChatIdAsync(chatId);


        if (uservalue.Date > vpn?.DayMax | uservalue.Date < vpn?.DayMin | uservalue.Date == 0)
        {
            uservalue.State = TelegramMarzbanVpnSessionState.AwaitingDate;
            BotSessions
                .users_Sessions?
                .AddOrUpdate(chatId, uservalue,
                    (key, old)
                        => old = uservalue);

            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
                }
            });

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text:
                $"\u274c زمان ارسال شده نامعتبر است . زمان باید بین {vpn.DayMin} روز تا {vpn.DayMax} روز باشد",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
        else
        {
            uservalue.State = TelegramMarzbanVpnSessionState.AwatingFactor;

            BotSessions
                .users_Sessions?
                .AddOrUpdate(chatId, uservalue,
                    (key, old)
                        => old = uservalue);

            string payment = uservalue.UserSubscribeId == null ? "دریافت سرویس" : $"تمدید سرویس";

            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData($"پرداخت و {payment}", $"buy_subscribe" +
                        $"?marzbanvpnid={uservalue.VpnId}" +
                        $"&gb={uservalue.Gb}" +
                        $"&days={uservalue.Date}")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
                }
            });

            SubscribeFactorBotDto sub = new()
            {
                Days = uservalue.Date ?? 0,
                Gb = uservalue.Gb ?? 0,
                Balance = mainUser.Balance,
                Count = 1,
                Price = ((uservalue.Gb * vpn.GbPrice) + (uservalue.Date * vpn.DayPrice)) * 1 ?? 0,
                Title = "خرید اشتراک"
            };

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: uservalue.UserSubscribeId != null ? sub.GetRenewalInfo() : sub.GetInfo(),
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);

            if (message.MessageId != 0)
            {
                await botClient!.DeleteMessageAsync(chatId, message.MessageId, cancellationToken);
            }
        }
    }

    public async Task SendUserInformationAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        User? user = await telegramService.GetUserByChatIdAsync(chatId);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("\ud83d\udcb0 افزایش موجودی", "inventory_increase")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
            }
        });

        string information = @$"🗂 اطلاعات حساب کاربری شما :

👤 نام: {user.UserFullName()}
📱 شماره تماس :🔴 {user.Mobile ?? " ارسال نشده است "} 🔴
💰 موجودی: {user.Balance} تومان";


        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: information,
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task SendTransactionDetailsAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        TransactionDetailDto? transactionDetail = await telegramService.GetTransactionDetailAsync(chatId);

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        TelegramMarzbanVpnSession uservalue = user.Value.Value;

        uservalue.State = TelegramMarzbanVpnSessionState.AwatingSendPrice;

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
            }
        });
        string information = transactionDetail.GetTransactionMessage();

        if (string.IsNullOrEmpty(transactionDetail.CardNumber))
        {
            information = "نماینده شما شماره کارتی برای پرداخت ثبت نکرده است";
            uservalue.State = TelegramMarzbanVpnSessionState.None;
        }

        BotSessions
            .users_Sessions?
            .AddOrUpdate(chatId, uservalue,
                (key, old)
                    => old = uservalue);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: information,
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);
    }

    public async Task SendCardNumberAndDetailAsync(ITelegramBotClient? botClient, Message? message,
        CancellationToken cancellationToken)
    {
        long chatId = message!.Chat.Id;

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        TransactionDetailDto? transactionDetail = await telegramService.GetTransactionDetailAsync(chatId);

        var uservalue = user.Value.Value;

        if (transactionDetail.MaximumAmount < uservalue.Price | transactionDetail.MinimalAmount > uservalue.Price)
        {
            string exText =
                $"\u274c خطا \n\ud83d\udcac مبلغ باید حداقل {transactionDetail.MinimalAmount} تومان و حداکثر {transactionDetail.MaximumAmount} تومان باشد";

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: exText,
                cancellationToken: cancellationToken);
        }
        else
        {
            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("✅ پرداخت کردم  | ارسال رسید", "send_transaction_image")
                }
            });

            string text = $@"برای افزایش موجودی، مبلغ {uservalue.Price}  تومان  را به شماره‌ی حساب زیر واریز کنید 👇🏻
        
        ==================== 
        {transactionDetail.CardNumber}
        {transactionDetail.CardHolderName}
        ====================

‼️مبلغ باید همان مبلغی که در بالا ذکر شده واریز نمایید.
‼️امکان برداشت وجه از کیف پول نیست.
‼️مسئولیت واریز اشتباهی با شماست.
🔝بعد از پرداخت  دکمه پرداخت کردم را زده سپس تصویر رسید را ارسال نمایید
💵بعد از تایید پرداختتون توسط ادمین کیف پول شما شارژ خواهد شد و در صورتی که سفارشی داشته باشین انجام خواهد شد";

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: text,
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
    }

    public async Task WatingForTransactionImageAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        var uservalue = user.Value.Value;

        uservalue.State = TelegramMarzbanVpnSessionState.AwaitingSendTransactionImage;

        BotSessions
            .users_Sessions?
            .AddOrUpdate(chatId, uservalue,
                (key, old)
                    => old = uservalue);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
            }
        });

        string text = "🖼 تصویر رسید خود را ارسال نمایید";

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: text,
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);
    }

    public async Task AddTrnasactionAsync(ITelegramBotClient? botClient, Message? message,
        CancellationToken cancellationToken)
    {
        long chatId = message!.Chat.Id;

        if (message.Type == MessageType.Photo)
        {
            KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
                .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

            TelegramMarzbanVpnSession uservalue = user?.Value;

            uservalue.State = TelegramMarzbanVpnSessionState.None;

            BotSessions
                .users_Sessions?
                .AddOrUpdate(chatId, uservalue,
                    (key, old)
                        => old = uservalue);

            var file = await botClient!.GetFileAsync(message.Photo![^1].FileId, cancellationToken: cancellationToken);
            using var memoryStream = new MemoryStream();

            await botClient!.DownloadFileAsync(file.FilePath!, memoryStream, cancellationToken);

            memoryStream.Seek(0, SeekOrigin.Begin); // R

            IFormFile formFile =
                new FormFile(
                    memoryStream,
                    0,
                    memoryStream.Length,
                    file.FileId, $"{file.FileId}.jpg");


            AddTransactionDto transaction = new()
            {
                AccountName = message.From?.FirstName ?? "بدون اسم",
                TransactionTime = DateTime.Now,
                TransactionType = TransactionType.Increase,
                AvatarTransaction = formFile,
                Price = uservalue.Price,
                Title = "افزایش موجودی"
            };

            CallbackQuery callbackQuery = new CallbackQuery()
            {
                Data = "back_to_main",
                Message = message
            };

            await telegramService.AddTransactionAsync(transaction, chatId);
            await SendMainMenuAsync(botClient, callbackQuery, cancellationToken,
                "\ud83d\ude80 رسید پرداخت  شما ارسال شد پس از تایید توسط مدیریت مبلغ به کیف پول شما واریز خواهد شد");
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

    public async Task SendFactorAppendGbAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message!.Chat.Id;

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        TelegramMarzbanVpnSession uservalue = user?.Value;

        MarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(uservalue.VpnId ?? 0, chatId);

        SubscribeFactorBotDto sub = new SubscribeFactorBotDto()
        {
            Gb = uservalue.Gb ?? 0,
            Price = vpn.GbPrice
        };

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("تایید و دریافت حجم اضاف", "accept_gb")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
            }
        });

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: sub.GetAppendGbInfo(),
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, message.MessageId, cancellationToken);
        }
    }

    public async Task SendFactorAppendDaysAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message!.Chat.Id;

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        TelegramMarzbanVpnSession uservalue = user?.Value;

        MarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(uservalue.VpnId ?? 0, chatId);

        SubscribeFactorBotDto sub = new SubscribeFactorBotDto()
        {
            Days = uservalue.Date ?? 0,
            Price = vpn.DayPrice
        };

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("تایید و دریافت روز اضاف", "accept_date")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
            }
        });

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: sub.GetAppendDayInfo(),
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, message.MessageId, cancellationToken);
        }
    }

    public async Task AcceptAppendGbAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        TelegramMarzbanVpnSession uservalue = user?.Value;

        MarzbanVpnDto marzbanVpn = await telegramService
            .GetMarzbanVpnInformationByIdAsync(uservalue.VpnId ?? 0, chatId);

        BuyMarzbanVpnDto buy = new();

        buy.MarzbanVpnId = uservalue.VpnId ?? 0;
        buy.Count = 1;
        buy.TotalGb = uservalue.Gb ?? 0;
        buy.MarzbanUserId = uservalue?.UserSubscribeId;

        List<MarzbanUser> marzbanUsers = await telegramService.BuySubscribeAsync(buy, chatId);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("بازگشت به سروی ",
                    $"subscribe_info?id={uservalue.UserSubscribeId}&vpnId={uservalue.VpnId}")
            },
        });

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "\u2705 افزایش حجم برای سرویس شما با موفقیت صورت گرفت\n\n" +
                  $"\u25ab\ufe0fحجم اضافه : {buy.TotalGb} گیگ\n\n" +
                  $"\u25ab\ufe0fمبلغ افزایش حجم : {uservalue.Gb * marzbanVpn.GbPrice} تومان",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task AcceptAppendDaysAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        TelegramMarzbanVpnSession uservalue = user?.Value;

        MarzbanVpnDto marzbanVpn = await telegramService
            .GetMarzbanVpnInformationByIdAsync(uservalue.VpnId ?? 0, chatId);

        BuyMarzbanVpnDto buy = new();

        buy.MarzbanVpnId = uservalue.VpnId ?? 0;
        buy.Count = 1;
        buy.TotalDay = uservalue.Date ?? 0;
        buy.MarzbanUserId = uservalue?.UserSubscribeId;

        await telegramService.BuySubscribeAsync(buy, chatId);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("بازگشت به سرور ",
                    $"subscribe_info?id={uservalue.UserSubscribeId}&vpnId={uservalue.VpnId}")
            },
        });

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "\u2705 افزایش روز برای سرویس شما با موفقیت صورت گرفت\n\n" +
                  $"\u25ab\ufe0fروز اضافه : {buy.TotalDay}\n\n" +
                  $"\u25ab\ufe0fمبلغ افزایش حجم : {uservalue.Date * marzbanVpn.DayPrice} تومان",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task SendDaysPriceForAppendDaysAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        int vpnId = 0;
        long subscribeId = 0;

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int32.TryParse(queryParameters["vpnId"], out vpnId);
            Int64.TryParse(queryParameters["subscribeId"], out subscribeId);
        }

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        TelegramMarzbanVpnSession? uservalue = user?.Value;

        if (uservalue is null)
            uservalue = new(TelegramMarzbanVpnSessionState.AwaitingSendAppendDaysForService, vpnId: vpnId,
                UserSubscribeId: subscribeId);

        uservalue.VpnId = vpnId;
        uservalue.UserSubscribeId = subscribeId;

        BotSessions
            .users_Sessions?
            .AddOrUpdate(chatId, uservalue,
                (key, old)
                    => old = uservalue);

        MarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(uservalue.VpnId ?? 0, chatId);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
            }
        });

        uservalue.State = TelegramMarzbanVpnSessionState.AwaitingSendAppendDaysForService;

        BotSessions
            .users_Sessions?
            .AddOrUpdate(chatId, uservalue,
                (key, old)
                    => old = uservalue);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text:
            $"\u231b\ufe0f زمان سرویس خود را انتخاب نمایید \n\ud83d\udccc تعرفه هر روز  : {vpn?.DayPrice}  تومان\n\u26a0\ufe0f حداقل زمان {vpn?.DayMin} روز  و حداکثر {vpn?.DayMax} روز  می توانید تهیه کنید",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);
    }

    public async Task ActiveMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        try
        {
            KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
                .users_Sessions?.SingleOrDefault(x => x.Key == chatId);
            TelegramMarzbanVpnSession? uservalue = user?.Value;

            if (uservalue.UserSubscribeId is null)
            {
                throw new NotFoundException("با عرض پوزش سرور پاسخگو نمیباشد");
            }

            await telegramService.ChangeMarzbanUserStatusAsync(MarzbanUserStatus.active, uservalue.UserSubscribeId ?? 0,
                chatId);

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: "سرویس شما با موفقیت فعال شد",
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task DisabledMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        try
        {
            KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
                .users_Sessions?.SingleOrDefault(x => x.Key == chatId);
            TelegramMarzbanVpnSession? uservalue = user?.Value;

            if (uservalue.UserSubscribeId is null)
            {
                throw new NotFoundException("با عرض پوزش سرور پاسخگو نمیباشد");
            }

            await telegramService.ChangeMarzbanUserStatusAsync(MarzbanUserStatus.disabled,
                uservalue.UserSubscribeId ?? 0,
                chatId);

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: "سرویس شما با موفقیت غیر فعال شد",
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            // await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
            await SendMainMenuAsync(botClient!, callbackQuery, cancellationToken);
        }
    }

    public async Task RequestForAgentAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message!.Chat.Id;
        try
        {
            await telegramService.AddRequestAgentAsync(message.Text ?? "", chatId);
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: "درخواست شما با موفثیت ثبت شد منتظر برسی کارشناسان ما باشید",
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task DeleteMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        try
        {
            KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
                .users_Sessions?.SingleOrDefault(x => x.Key == chatId);
            TelegramMarzbanVpnSession? uservalue = user?.Value;

            if (uservalue is null)
            {
                throw new NotFoundException("با عرض پوزش دوباره تلاش کنید");
            }

            await telegramService.DeleteMarzbanUserAsync(uservalue.UserSubscribeId ?? 0, chatId);

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: "سرویس شما با موفقیت حذف شد",
                cancellationToken: cancellationToken);

            await SendListServicesAsync(botClient!, callbackQuery, cancellationToken);
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);

            await SendListServicesAsync(botClient!, callbackQuery, cancellationToken);
        }
    }

    public async Task RevokeSubscribeAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        try
        {
            KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
                .users_Sessions?.SingleOrDefault(x => x.Key == chatId);
            TelegramMarzbanVpnSession? uservalue = user?.Value;

            if (uservalue is null)
            {
                throw new NotFoundException("با عرض پوزش دوباره تلاش کنید");
            }

            string sub = await telegramService.RevokeMarzbanUserAsync(uservalue.UserSubscribeId ?? 0, chatId);

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: $"\u2705 کانفیگ شما با موفقیت بروزرسانی گردید.\nاشتراک شما : {sub}",
                cancellationToken: cancellationToken);

            await SendListServicesAsync(botClient!, callbackQuery, cancellationToken);
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);

            await SendListServicesAsync(botClient!, callbackQuery, cancellationToken);
        }
    }

    public async Task SendTelegramInviteLinkAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        var userInfo = await botClient!.GetMeAsync(cancellationToken: cancellationToken);
        string? agentCode = await telegramService.GetAgentBotLinkAsync(callbackQuery!.Message!.Chat.Id);
        string? link = $"https://t.me/{userInfo.Username}?start={agentCode}";
        await botClient!.SendTextMessageAsync(
            callbackQuery!.Message!.Chat.Id,
            $"با استفاده از لینک زیر شما میتونید از دعوت دوستان خودتون به ربات کسب درآمد کنید.\n\n👇👇👇👇👇👇👇👇👇👇\n\n🔗 {link}",
            cancellationToken: cancellationToken
        );
        await Task.CompletedTask;
    }

    public async Task SendAgentMenuForAdmin(ITelegramBotClient botClient, long chatId,
        CancellationToken cancellationToken)
    {
        var keyboard = new ReplyKeyboardMarkup(new[]
        {
            new KeyboardButton[] { "مدیریت پنل نمایندگی \u270f\ufe0f", "آمار نمایندگی \ud83d\udcca" },
            new KeyboardButton[] { " مدیریت کاربر" },
            new KeyboardButton[] { "جستجو کاربر 🔍", "ارسال پیام ✉️" },
        })
        {
            ResizeKeyboard = true // تنظیم اندازه کیبورد
        };

        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "لطفاً یک گزینه را انتخاب کنید:",
            replyMarkup: keyboard,
            cancellationToken: cancellationToken
        );
    }

    public async Task<Message> SendAgentInformationMenuAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        try
        {
            bool isAgent = await telegramService.IsAgentAsyncByChatIdAsync(message.Chat.Id);

            if (!isAgent)
                throw new AppException("شما نماینده نیستید");

            var keyboard = new ReplyKeyboardMarkup(new[]
            {
                new KeyboardButton[] { "ثبت | تغییر شماره کارت \ud83d\udcb3" },
                new KeyboardButton[] { "مشاهده اطلاعات پرداخت \ud83d\udcb0" },
                new KeyboardButton[] { "تغییر درصد کاربر", "تغییر درصد نماینده" },
                new KeyboardButton[] { "\ud83c\udfe0 بازگشت به منو اصلی" }
            })
            {
                ResizeKeyboard = true
            };

            return await botClient!.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "مدیریت پنل نمایندگی:",
                cancellationToken: cancellationToken,
                replyMarkup: keyboard
            );
        }
        catch (Exception e)
        {
            return await botClient!.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: e.Message,
                cancellationToken: cancellationToken
            );
        }
    }

    public async Task<Message> EditeAgentCardNumberInformationAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message.Chat.Id;
        try
        {
            BotSessions
                .users_Sessions?
                .AddOrUpdate(chatId,
                    new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.AwaitingSendCardNumber),
                    (key, old)
                        => old = new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.AwaitingSendCardNumber));

            return await botClient!.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: """
                      لطفا شماره کارت 16 رقمی خود را ارسال کنید!
                      فرمت درست 6037696975758585
                      """,
                cancellationToken: cancellationToken
            );
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Message> EditeAgentCardHolderNameInformationAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message.Chat.Id;
        try
        {
            BotSessions
                .users_Sessions?
                .AddOrUpdate(chatId,
                    new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.AwaitingSendCardHolderName),
                    (key, old)
                        => old = new TelegramMarzbanVpnSession(
                            TelegramMarzbanVpnSessionState.AwaitingSendCardHolderName));

            return await botClient!.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: """
                      لطفا نام صاحب
                       شماره کارت را
                       به صورت دقیق
                        وارد کنید!
                      """,
                cancellationToken: cancellationToken
            );
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Message> SendAgentTransactionPaymentDetailAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message.Chat.Id;
        try
        {
            TransactionDetailDto? transaction = await telegramService.GetAgentTransactionDetailAsync(chatId);
            if (transaction is null)
                throw new ApplicationException("اطلاعات پرداخت ثبت نشده");

            string text = $"شماره کارت: {transaction.CardNumber ?? "ثبت نشده"} \n" +
                          $"نام صاحب کارت: {transaction.CardHolderName ?? "ثبت نشده"}\n" +
                          $"درصد سود پیش‌ فرض از کاربر عادی: %{transaction.AgentPercent}\n" +
                          $"درصد سود پیش‌ فرض از نماینده: %{transaction.UserPercent}";
            return await botClient!.SendTextMessageAsync(chatId,
                text, cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            return await botClient!.SendTextMessageAsync(chatId, e.Message, cancellationToken: cancellationToken);
        }
    }

    public async Task<Message> SendAgentInformationAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        try
        {
            long chatId = message.Chat.Id;
            AgentInformationDto agentInformation = await telegramService.GetAgentInformationAsync(chatId);
            return await botClient!.SendTextMessageAsync(
                chatId,
                agentInformation.Information_Text(),
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Message> UpdateAgentPercentAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        try
        {
            long chatId = message.Chat.Id;

            BotSessions
                .users_Sessions?
                .AddOrUpdate(chatId,
                    new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.AwaitingSendAgentPercent),
                    (key, old)
                        => old = new TelegramMarzbanVpnSession(
                            TelegramMarzbanVpnSessionState.AwaitingSendAgentPercent));

            AgentInformationDto agentInformation = await telegramService.GetAgentInformationAsync(chatId);

            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
                }
            });

            return await botClient!.SendTextMessageAsync(
                chatId,
                $"""
                 درصد صود فروش از نماینده ها : {agentInformation.AgentPercent}
                  درصد صود خود را ارسال کنید
                 """,
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Message> UpdateUserPercentAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        try
        {
            long chatId = message.Chat.Id;

            BotSessions
                .users_Sessions?
                .AddOrUpdate(chatId,
                    new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.AwaitingSendUserPercent),
                    (key, old)
                        => old = new TelegramMarzbanVpnSession(
                            TelegramMarzbanVpnSessionState.AwaitingSendUserPercent));

            AgentInformationDto agentInformation = await telegramService.GetAgentInformationAsync(chatId);

            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
                }
            });

            return await botClient!.SendTextMessageAsync(
                chatId,
                $"""
                 درصد صود فروش از کاربر ها : {agentInformation.UserPercent}
                  درصد صود خود را ارسال کنید
                 """,
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private async Task DeleteMenu(ITelegramBotClient? botClient, Message message, CancellationToken cancellationToken)
    {
        await botClient!.EditMessageReplyMarkupAsync(
            chatId: message.Chat.Id,
            messageId: message.MessageId,
            replyMarkup: InlineKeyboardMarkup.Empty(),
            cancellationToken: cancellationToken
        );
    }
}