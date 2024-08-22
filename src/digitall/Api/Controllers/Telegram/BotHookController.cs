using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Web;
using Api.Filters;
using Application.Extensions;
using Application.Helper;
using Application.Services.Interface.Telegram;
using Application.Sessions;
using Application.Utilities;
using Data.DefaultData;
using Domain.DTOs.Agent;
using Domain.DTOs.Marzban;
using Domain.DTOs.Telegram;
using Domain.Entities.Marzban;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Api.Controllers.Telegram;

[ServiceFilter(typeof(ExceptionHandler))]
public class BotHookController(
    IServiceProvider serviceProvider,
    IBotService botService,
    ITelegramService telegramService
) : ControllerBase
{
    private ITelegramBotClient? _botClient;
    private string? _token;

    [HttpPost("{botName}")]
    public async Task<IActionResult> Post(string botName,
        [FromBody] Update update,
        CancellationToken cancellationToken)
    {
        string? token = await telegramService.GetTelegramBotAsyncByName(botName);

        if (token == null)
        {
            return NotFound();
        }

        _token = token;

        _botClient = new TelegramBotClient(token);

        await HandleUpdateAsync(update, new CancellationToken());

        return Ok();
    }

    public async Task HandleUpdateAsync(Update update,
        CancellationToken cancellationToken)
    {
        var handler = update switch
        {
            { Message: { } message } => BotOnMessageReceived(message, cancellationToken),
            { EditedMessage: { } message } => BotOnMessageReceived(message, cancellationToken),
            { CallbackQuery: { } callbackQuery } => BotOnCallbackQueryReceived(callbackQuery,
                cancellationToken)
        };

        await handler;
    }

    private async Task BotOnMessageReceived(Message message,
        CancellationToken cancellationToken)
    {
        try
        {
            if (message.Photo is not { } photo & message.Text is not { } messageText)
                return;

            KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions.users_Sessions!
                .SingleOrDefault(x => x.Key == message.Chat.Id);

            if (user.Value.Value is not null)
            {
                switch (user.Value.Value.State)
                {
                    case TelegramMarzbanVpnSessionState.AwaitingSendPhone:
                        string? phone = message.Text;

                        if (phone!.Length != 11)
                        {
                            throw new ApplicationException("لطفا شماره تماس درست را ارسال کنید");
                        }

                        user.Value.Value.Phone = phone;
                        user.Value.Value.State =
                            TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForAddAgentRequest;

                        await _botClient!.SendTextMessageAsync(chatId: message.Chat.Id,
                            "لطفا توضیحات درخواست خود را ارسال کنید");

                        break;

                    case TelegramMarzbanVpnSessionState.AwaitingSendEnglishBrandName:
                        string? englishBrandName = message!.Text;
                        if (englishBrandName!.Length <= 2 || string.IsNullOrEmpty(englishBrandName))
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                        نام نمایندگی را به صورت صحیح ارسال کنید!
                                      """,
                                cancellationToken: cancellationToken);
                            break;
                        }

                        if (!EnglishText.IsEnglishText(englishBrandName))
                            throw new ApplicationException("لطفا حروف انگیلیسی ارسال کنید");

                        user.Value.Value.EnglishBrandName = message.Text;
                        bool updateBrandNamesResponse = await telegramService.UpdateAgentBrandNames(message.Chat.Id,
                            user.Value.Value.PersionBrandName, user.Value.Value.EnglishBrandName);

                        user.Value.Value.State = TelegramMarzbanVpnSessionState.None;
                        if (!updateBrandNamesResponse)
                            throw new ApplicationException("مشکلی در تغییر نام نمایندگی رخ داده.");

                        await _botClient!.SendTextMessageAsync(chatId: message.Chat.Id,
                            text: "عملیات با موفقیت انجام شد", cancellationToken: cancellationToken);

                        break;
                    case TelegramMarzbanVpnSessionState.AwaitingSendPersionBrandName:
                        string? persionBrandName = message!.Text;
                        if (persionBrandName.Length <= 2 || string.IsNullOrEmpty(persionBrandName))
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                        نام نمایندگی را به صورت صحیح ارسال کنید!
                                      """,
                                cancellationToken: cancellationToken);
                            break;
                        }

                        user.Value.Value.PersionBrandName = message.Text;
                        user.Value.Value.State = TelegramMarzbanVpnSessionState.AwaitingSendEnglishBrandName;

                        await _botClient!.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: "لطفا نام نمایندگی خود را به صورت انگیلیسی ارسال کنید",
                            cancellationToken: cancellationToken
                        );
                        break;
                    case TelegramMarzbanVpnSessionState.AwaitingSendUserPercent:
                        int userPercent = 0;
                        Int32.TryParse(message?.Text, out userPercent);

                        if (userPercent == 0)
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                      لطفا فرمت درست را ارسال کنید.
                                      """,
                                cancellationToken: cancellationToken);
                            break;
                        }

                        user.Value.Value.UserPercent = userPercent;
                        bool update_user_percent =
                            await telegramService.UpdateUserPercentAsync(message.Chat.Id, userPercent);
                        user.Value.Value.State = TelegramMarzbanVpnSessionState.None;
                        if (update_user_percent)
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                      درصد کاربر های شما با موفقیت تغییر کرد
                                      """,
                                cancellationToken: cancellationToken);
                        }
                        else
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                        مشکلی در ثبت اطلاعات رخ داد
                                      """,
                                cancellationToken: cancellationToken);
                        }

                        break;
                    case TelegramMarzbanVpnSessionState.AwaitingSendAgentPercent:
                        int agentPercent = 0;
                        Int32.TryParse(message?.Text, out agentPercent);
                        if (agentPercent == 0)
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                      لطفا فرمت درست را ارسال کنید.
                                      """,
                                cancellationToken: cancellationToken);
                            break;
                        }

                        user.Value.Value.AgentPercent = agentPercent;
                        bool update_agent_percent =
                            await telegramService.UpdateAgentPercentAsync(message.Chat.Id, agentPercent);
                        user.Value.Value.State = TelegramMarzbanVpnSessionState.None;
                        if (update_agent_percent)
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                      درصد نماینده های شما با موفقیت تغییر کرد
                                      """,
                                cancellationToken: cancellationToken);
                            break;
                        }
                        else
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                        مشکلی در ثبت اطلاعات رخ داد
                                      """,
                                cancellationToken: cancellationToken);
                            break;
                        }

                        break;
                    case TelegramMarzbanVpnSessionState.AwaitingSendCardHolderName:
                        string? HolderName = message.Text;

                        user.Value.Value.State = TelegramMarzbanVpnSessionState.AwaitingSendCardHolderName;
                        if (HolderName.Trim().Length <= 4 | string.IsNullOrEmpty(HolderName))
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                        نام صاحب کارت را به صورت صحیح ارسال کنید!
                                      """,
                                cancellationToken: cancellationToken);
                            break;
                        }

                        user.Value.Value.State = TelegramMarzbanVpnSessionState.None;
                        user.Value.Value.CardHolderName = message.Text;
                        BotSessions
                            .users_Sessions?
                            .AddOrUpdate(message.Chat.Id,
                                user.Value.Value, (key, old) => old = user.Value.Value);
                        bool response =
                            await telegramService.EditeAgentTransactionDetailAsync(message.Chat.Id, user.Value.Value);
                        if (response)
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                      اطلاعات پرداخت شما با موقیت ثبت شد
                                      """,
                                cancellationToken: cancellationToken);
                        }
                        else
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                      مشکلی در ثبت اطلاعات رخ داد
                                      """,
                                cancellationToken: cancellationToken);
                        }

                        break;
                    case TelegramMarzbanVpnSessionState.AwaitingSendCardNumber:
                        long cardNumber = 0;
                        Int64.TryParse(message?.Text, out cardNumber);

                        if (cardNumber == 0 | message.Text.Length != 16)
                        {
                            await _botClient!.SendTextMessageAsync(
                                chatId: message!.Chat.Id,
                                text: """
                                      فرمت ارسالی کارت اشتباه است!
                                      : فرمت درست
                                       6037696975758585
                                      """,
                                cancellationToken: cancellationToken);
                            break;
                        }

                        user.Value.Value.State = TelegramMarzbanVpnSessionState.AwaitingSendCardHolderName;
                        user.Value.Value.CardNumber = message.Text;
                        await botService.EditeAgentCardHolderNameInformationAsync(_botClient, message,
                            cancellationToken);
                        BotSessions
                            .users_Sessions?
                            .AddOrUpdate(message.Chat.Id,
                                user.Value.Value, (key, old) => old = user.Value.Value);
                        break;

                    case TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForAddAgentRequest:
                        await botService.RequestForAgentAsync(_botClient, message, cancellationToken);
                        user.Value.Value.State = TelegramMarzbanVpnSessionState.None;
                        user.Value.Value.RequestDescription = message!.Text;
                        BotSessions
                            .users_Sessions?
                            .AddOrUpdate(message.Chat.Id,
                                user.Value.Value, (key, old) => old = user.Value.Value);
                        break;

                    case TelegramMarzbanVpnSessionState.AwaitingSendAppendDaysForService:
                        int day = 0;
                        Int32.TryParse(message?.Text, out day);
                        user.Value.Value.Date = day;
                        await botService.SendFactorAppendDaysAsync(_botClient, message, cancellationToken);
                        user.Value.Value.State = TelegramMarzbanVpnSessionState.None;
                        BotSessions
                            .users_Sessions?
                            .AddOrUpdate(message.Chat.Id,
                                user.Value.Value, (key, old) => old = user.Value.Value);
                        break;

                    case TelegramMarzbanVpnSessionState.AwaitingSendAppendGbForService:
                        int gig = 0;
                        Int32.TryParse(message?.Text, out gig);
                        user.Value.Value.Gb = gig;
                        await botService.SendFactorAppendGbAsync(_botClient, message, cancellationToken);
                        user.Value.Value.State = TelegramMarzbanVpnSessionState.None;
                        BotSessions
                            .users_Sessions?
                            .AddOrUpdate(message.Chat.Id,
                                user.Value.Value, (key, old) => old = user.Value.Value);
                        break;

                    case TelegramMarzbanVpnSessionState.AwaitingGb:
                        int gb = 0;
                        Int32.TryParse(message?.Text, out gb);
                        user.Value.Value.Gb = gb;
                        BotSessions
                            .users_Sessions?
                            .AddOrUpdate(message.Chat.Id,
                                user.Value.Value, (key, old) => old = user.Value.Value);
                        await botService.SendDaysPriceAsync(_botClient, message, cancellationToken);
                        break;

                    case TelegramMarzbanVpnSessionState.AwaitingDate:
                        int date = 0;
                        Int32.TryParse(message?.Text, out date);
                        user.Value.Value.Date = date;
                        BotSessions
                            .users_Sessions?
                            .AddOrUpdate(message.Chat.Id,
                                user.Value.Value, (key, old) => old = user.Value.Value);

                        await botService.SendCustomFactorVpnAsync(_botClient, message, cancellationToken);
                        break;
                    case TelegramMarzbanVpnSessionState.AwaitingSendPrice:
                        int price = 0;
                        Int32.TryParse(message?.Text, out price);
                        user.Value.Value.Price = price;

                        BotSessions
                            .users_Sessions?
                            .AddOrUpdate(message.Chat.Id,
                                user.Value.Value, (key, old) => old = user.Value.Value);

                        await botService.SendCardNumberAndDetailAsync(_botClient, message, cancellationToken);
                        break;
                    case TelegramMarzbanVpnSessionState.AwaitingSendTransactionImage:
                        await botService.AddTrnasactionAsync(_botClient, message, cancellationToken);
                        break;
                }
            }

            bool? started = message?.Text.StartsWith("/start");

            Message action = new Message();
            if (started != null && started == true)
            {
                action = message?.Text.Split(" ")[0] switch
                {
                    "/start" => await botService.StartLinkAsync(_botClient, message, cancellationToken),
                };
            }
            else
            {
                action = message?.Text switch
                {
                    "ثبت | تغییر نام نمایندگی \ud83d\udc65" => await botService.UpdateAgentPersionBrandNameAsync(
                        _botClient,
                        message,
                        cancellationToken),
                    "تغییر درصد نماینده" => await botService.UpdateAgentPercentAsync(_botClient,
                        message,
                        cancellationToken),
                    "تغییر درصد کاربر" => await botService.UpdateUserPercentAsync(_botClient,
                        message,
                        cancellationToken),
                    "مدیریت پنل نمایندگی \u270f\ufe0f" => await botService.SendAgentInformationMenuAsync(_botClient,
                        message,
                        cancellationToken),
                    "آمار نمایندگی \ud83d\udcca" => await botService.SendAgentInformationAsync(_botClient,
                        message,
                        cancellationToken),
                    "\ud83c\udfe0 بازگشت به منو اصلی" => await botService.SendMainMenuAsync(_botClient, message,
                        cancellationToken),
                    "ثبت | تغییر شماره کارت \ud83d\udcb3" => await botService.EditeAgentCardNumberInformationAsync(
                        _botClient,
                        message, cancellationToken),
                    "مشاهده اطلاعات پرداخت \ud83d\udcb0" => await botService.SendAgentTransactionPaymentDetailAsync(
                        _botClient,
                        message, cancellationToken),
                    _ => new Message()
                };
            }

            Message sentMessage = action;
        }
        catch (Exception e)
        {
            await _botClient!.SendTextMessageAsync(message.Chat.Id, e.Message, cancellationToken: cancellationToken);
        }
    }

    private async Task BotOnCallbackQueryReceived(CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        string data = callbackQuery.Data.Split('?')[0];

        switch (data)
        {
            case "subscribe":
                await botService.SendListVpnsAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "test_free":
                await botService.SendListVpnsHaveTestAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "back_to_main":
                await botService.SendMainMenuAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "vpn_template":
                await botService.SendListVpnsTemplateAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "factor_subscribe":
                await botService.SendFactorVpnAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "buy_subscribe":
                await botService.SendSubscriptionAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "custom_subscribe":
                await botService.SendGbPriceAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "my_services":
                await botService.SendListServicesAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "subscribe_info":
                await botService.SendSubscribeInformationAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "createtestsub":
                await botService.SendTestSubscibeAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "subscription_link":
                await botService.SendSubscribeAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "get_traffic":
                await botService.SendConfigsAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "wallet":
                await botService.SendUserInformationAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "inventory_increase":
                await botService.SendTransactionDetailsAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "send_transaction_image":
                await botService.WatingForTransactionImageAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "web_information":
                await botService.SendUserForLoginToWebAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "accept_gb":
                await botService.AcceptAppendGbAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "accept_date":
                await botService.AcceptAppendDaysAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "append_date":
                await botService.SendDaysPriceForAppendDaysAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "active_service":
                await botService.ActiveMarzbanUserAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "disabled_service":
                await botService.DisabledMarzbanUserAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "delete_service":
                await botService.DeleteMarzbanUserAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "revoke_sub":
                await botService.RevokeSubscribeAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "invitation_link":
                await botService.SendTelegramInviteLinkAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "accept_agent_request":
                await botService.AcceptAgentRequestAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "reject_agent_request":
                await botService.RejectAgentRequestAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "action_card":
                await botService.ChangeStateCardToCard(_botClient, callbackQuery, cancellationToken);
                break;
            case "user_management":
                await botService.ManagementUserAsync(_botClient,callbackQuery,cancellationToken);
                break;
            case "renewal_service":
                await _botClient!.SendTextMessageAsync(
                    chatId: callbackQuery!.Message!.Chat.Id,
                    text: callbackQuery.Data,
                    cancellationToken: cancellationToken);
                break;
            case "agent_request":
                long chatId = callbackQuery!.Message!.Chat.Id;
                bool have = await telegramService.HaveRequestForAgentAsync(callbackQuery!.Message!.Chat.Id);
                if (have)
                {
                    await _botClient!.SendTextMessageAsync(
                        chatId: chatId,
                        text: "شما قبلا درخواستی برای نمایندگی ثبت کردید",
                        cancellationToken: cancellationToken);
                }
                else
                {
                    KeyValuePair<long, TelegramMarzbanVpnSession>? userSesstion = BotSessions
                        .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

                    TelegramMarzbanVpnSession? uservalue = userSesstion?.Value;

                    if (userSesstion?.Value is null)
                        uservalue = new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState
                            .AwaitingSendDescriptionForAddAgentRequest);

                    uservalue!.State = TelegramMarzbanVpnSessionState.AwaitingSendPhone;

                    BotSessions
                        .users_Sessions?
                        .AddOrUpdate(chatId,
                            uservalue!, (key, old) => old = uservalue);

                    await _botClient!.SendTextMessageAsync(
                        chatId: chatId,
                        text: "لطفا شماره تلفن خود را برای ثبت نمایندگی ارسال کنید",
                        cancellationToken: cancellationToken);
                }
                break;
            default:
                break;
        }
    }
}