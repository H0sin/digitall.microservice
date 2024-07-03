using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Web;
using Api.Filters;
using Application.Helper;
using Application.Services.Interface.Telegram;
using Application.Sessions;
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
    ITelegramService telegramService
) : ControllerBase
{
    private ITelegramBotClient? _botClient;

    private static ConcurrentDictionary<long, CustomMarzbanVpnSession> userSessions =
        new ConcurrentDictionary<long, CustomMarzbanVpnSession>();

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

    private async Task<Message> SendStartedMessage(ITelegramBotClient botClient, Message message,
        CancellationToken cancellationToken)
    {
        await botClient.SendChatActionAsync(
            chatId: message.Chat.Id,
            chatAction: ChatAction.Typing,
            cancellationToken: cancellationToken);

        await Task.Delay(500, cancellationToken);

        string parameter = "";

        if (message.Text != null && message.Text.StartsWith("/start"))
        {
            parameter = message.Text.Substring(6);
        }

        await telegramService.StartTelegramBot(new StartTelegramBotDto()
        {
            AgentCode = 10001,
            ChatId = message.Chat.Id,
            FirstName = message.From.FirstName,
            LastName = message.From.LastName
        });

        InlineKeyboardMarkup inlineKeyboard = new(
            new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("تست رایگان 😎", "test_free"),
                    InlineKeyboardButton.WithCallbackData("خرید اشتراک 🔒", "subscribe")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("سرویس های من 🎁", "my_services")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("همکاری در فروش 🤝", "collaboration"),
                    InlineKeyboardButton.WithCallbackData("کیف پول + شارژ 🏦", "wallet")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("پشتیبانی 📞", "support"),
                    InlineKeyboardButton.WithCallbackData("آموزش 📚", "education")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("درخواست نمایندگی 🔒", "request_representative")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("بازگشت به منو اصلی", "21"),
                },
            });

        return await botClient.SendTextMessageAsync(
            chatId: message.Chat.Id,
            text: "خوش آمدید بچه هایه دیرین",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);
    }

    private async Task SendMainMenu(long chatId, int messageId, CancellationToken cancellationToken)
    {
        InlineKeyboardMarkup inlineKeyboard = new(
            new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("تست رایگان 😎", "test_free"),
                    InlineKeyboardButton.WithCallbackData("خرید اشتراک 🔒", "subscribe")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("سرویس های من 🎁", "my_services")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("همکاری در فروش 🤝", "collaboration"),
                    InlineKeyboardButton.WithCallbackData("کیف پول + شارژ 🏦", "wallet")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("پشتیبانی 📞", "support"),
                    InlineKeyboardButton.WithCallbackData("آموزش 📚", "education")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("درخواست نمایندگی 🔒", "request_representative")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("بازگشت به منو اصلی", "21"),
                },
            });

        await _botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "به منو اصلی بازگشتید 🏠",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (messageId != 0)
        {
            await _botClient.DeleteMessageAsync(chatId, messageId, cancellationToken);
        }
    }

    private async Task SendSubscriptionMenu(long chatId, int messageId, CancellationToken cancellationToken)
    {
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

        await _botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "اشتراک خود را انتخاب نمایید. 📌",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        // حذف منوی قبلی اگر شماره پیام ارسالی موجود باشد
        if (messageId != 0)
        {
            await _botClient.DeleteMessageAsync(chatId, messageId, cancellationToken);
        }
    }

    private async Task SendTestFreeMenu(long chatId, int messageId, CancellationToken cancellationToken)
    {
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

        await _botClient.SendTextMessageAsync(
            chatId: chatId,
            text: " موقعیت سرویس را انتخاب نمایید. 📌",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        // حذف منوی قبلی اگر شماره پیام ارسالی موجود باشد
        if (messageId != 0)
        {
            await _botClient.DeleteMessageAsync(
                chatId,
                messageId,
                cancellationToken);
        }
    }

    private async Task SendVpnTemplateById(CallbackQuery callbackQuery, CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

        string callbackData = callbackQuery.Data;
        int index = callbackData.IndexOf('=');
        long id = 0;
        if (index != -1) id = Convert.ToInt64(callbackData[(index + 1)..]);

        List<MarzbanVpnTemplateDto> templates = await telegramService.GetMarzbanVpnTemplatesByVpnIdAsync(id, chatId);

        foreach (MarzbanVpnTemplateDto template in templates)
        {
            List<InlineKeyboardButton> button = new()
            {
                InlineKeyboardButton.WithCallbackData(
                    (template!.Days! + " روزه ") +
                    (template.Gb > 200 ? " نامحدود " : template.Gb + " گیگ ")
                    + (template.Price + " تومان "),
                    "factor_subscribe?id=" + template.Id + "&vpnId=" + id)
            };
            keys.Add(button);
        }

        List<InlineKeyboardButton> custom = new()
        {
            InlineKeyboardButton.WithCallbackData("\ud83d\udecd حجم و زمان دلخواه", "custom_subscribe")
        };
        List<InlineKeyboardButton> home = new()
        {
            InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
        };

        keys.Add(custom);
        keys.Add(home);

        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keys);

        await _botClient.SendTextMessageAsync(
            chatId: chatId,
            text: " نوع سرویس خود را انتخاب کنید. 📌",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        // حذف منوی قبلی اگر شماره پیام ارسالی موجود باشد
        if (callbackQuery.Message.MessageId != 0)
        {
            await _botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    private async Task SendSubscription(CallbackQuery callbackQuery, CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        long marzbanvpntemplateId = 0;
        long marzbanvpnid = 0;

        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');
        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int64.TryParse(queryParameters["marzbanvpntemplateId"], out marzbanvpntemplateId);
            Int64.TryParse(queryParameters["marzbanvpnid"], out marzbanvpnid);
        }

        BuyMarzbanVpnDto buy = new();

        buy.MarzbanVpnId = marzbanvpnid;
        buy.MarzbanVpnTemplateId = marzbanvpntemplateId;
        buy.Count = 2;
        MarzbanVpnTemplateDto? template = await telegramService.GetMarzbanTemplateByIdAsync(marzbanvpntemplateId);

        List<MarzbanUser> marzbanUsers = await telegramService.BuySubscribeAsync(buy, chatId);

        foreach (MarzbanUser user in marzbanUsers)
        {
            byte[] QrImage = await GenerateQrCode
                .GetQrCodeAsync(user.Subscription_Url);

            string caption = $@"
✅ سرویس با موفقیت ایجاد شد

👤 نام کاربری سرویس: {user.Username.TrimEnd()}
🌿 نام سرویس: {template.Title.TrimEnd()}
⏳ مدت زمان: {template.Days} روز
👥 حجم سرویس: {(template.Gb > 200 ? "نامحدود" : template.Gb + "گیگ")}
لینک اتصال:
{user.Subscription_Url.TrimEnd()}
";
            using (var Qr = new MemoryStream(QrImage))
            {
                await _botClient.SendPhotoAsync(
                    chatId: callbackQuery.Message.Chat.Id,
                    photo: new InputFileStream(Qr, user.Subscription_Url),
                    caption: caption,
                    cancellationToken: cancellationToken);
            }
        }

        await _botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        await SendMainMenu(chatId, callbackQuery.Message.MessageId, cancellationToken);
    }

    private async Task SendFactorSubscribe(CallbackQuery callbackQuery, CancellationToken cancellationToken)
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

        BuyMarzbanVpnDto buy = new();
        buy.MarzbanVpnTemplateId = id;
        buy.MarzbanVpnId = vpnId;
        buy.Count = 1;

        IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

        List<InlineKeyboardButton> bu = new()
        {
            InlineKeyboardButton.WithCallbackData("پرداخت و دریافت سرویس", $"buy_subscribe" +
                                                                           $"?marzbanvpntemplateId={id}" +
                                                                           $"&marzbanvpnid={vpnId}")
        };
        List<InlineKeyboardButton> home = new()
        {
            InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
        };

        keys.Add(bu);
        keys.Add(home);

        InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keys);

        var sub = await telegramService.SendFactorSubscribeAsync(buy, chatId);

        string deatils = $@"
📇 پیش فاکتور شما:
🔐 نام سرویس: 🛍 {sub.Title}
📆 مدت اعتبار: {sub.Days} روز
💶 قیمت:  {sub.Price} تومان
👥 حجم اکانت: {(sub.Gb > 200 ? "نامحدود" : sub.Gb + "گیگ")}
🗒 یادداشت محصول : 
💵 موجودی کیف پول شما : {sub.Balance}          
💰 سفارش شما آماده پرداخت است
";

        await _botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: deatils,
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);
        // حذف منوی قبلی اگر شماره پیام ارسالی موجود باش
        // د
        if (callbackQuery.Message.MessageId != 0)
        {
            await _botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    private async Task CreateAndSendTestConfig(long chatId, int messageId, CancellationToken cancellationToken)
    {
        GenerateQrCode.GetQrCodeAsync("");
    }


    private async Task SendListServices(CallbackQuery callbackQuery, CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        // int skip = 0;
        // int take = 3;
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
                InlineKeyboardButton.WithCallbackData(us.Username, $"subscribe_info?id={us.Id}")
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

        await _botClient!.SendTextMessageAsync(
            chatId: chatId,
            text:
            "\ud83d\udecd اشتراک های خریداری شده توسط شما\n\n\u26a0\ufe0fبرای مشاهده اطلاعات و مدیریت روی نام کاربری کلیک کنید",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await _botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    private async Task SendSubscribeInfo(CallbackQuery callbackQuery, CancellationToken cancellationToken)
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

    
        if (callbackQuery.Message.MessageId != 0)
        {
            await _botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    private async Task BotOnMessageReceived(Message message,
        CancellationToken cancellationToken)
    {
        if (message.Text is not { } messageText)
            return;

        var action = messageText.Split(' ')[0] switch
        {
            "/start" => SendStartedMessage(_botClient, message, cancellationToken),
            // "/inline_keyboard" => SendInlineKeyboard(_botClient, message, cancellationToken)
            // _ => Usage(_botClient, message, cancellationToken)
        };
        Message sentMessage = await action;
    }

    private async Task BotOnCallbackQueryReceived(CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        string data = callbackQuery.Data.Split('?')[0];

        switch (data)
        {
            case "subscribe":
                await SendSubscriptionMenu(callbackQuery.Message.Chat.Id, callbackQuery.Message.MessageId,
                    cancellationToken);
                break;
            case "test_free":
                await SendTestFreeMenu(callbackQuery.Message.Chat.Id, callbackQuery.Message.MessageId,
                    cancellationToken);
                break;
            case "back_to_main":
                await SendMainMenu(callbackQuery.Message.Chat.Id, callbackQuery.Message.MessageId, cancellationToken);
                break;
            case "vpn_template":
                await SendVpnTemplateById(callbackQuery, cancellationToken);
                break;
            case "factor_subscribe":
                await SendFactorSubscribe(callbackQuery, cancellationToken);
                break;
            case "buy_subscribe":
                await SendSubscription(callbackQuery, cancellationToken);
                break;
            case "custom_subscribe":
                break;
            case "my_services":
                await SendListServices(callbackQuery, cancellationToken);
                break;
            case "subscribe_info":
                await SendSubscribeInfo(callbackQuery, cancellationToken);
                break;
            default:
                if (callbackQuery.Data.StartsWith("createtestsub?id"))
                {
                    string callbackData = callbackQuery.Data;
                    int index = callbackData.IndexOf('=');
                    if (index != -1)
                    {
                        long id = Convert.ToInt64(callbackData[(index + 1)..]);

                        MarzbanUserInformationDto user =
                            await telegramService
                                .GetMarzbanTestVpnsAsync(id, callbackQuery!.Message!.Chat.Id);

                        GetMarzbanVpnDto? vpn = await telegramService
                            .GetMarzbanVpnInformationByIdAsync(id);

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
                            await _botClient.SendPhotoAsync(
                                chatId: callbackQuery.Message.Chat.Id,
                                photo: new InputFileStream(Qr, user.Subscription_Url),
                                caption: caption,
                                cancellationToken: cancellationToken);
                        }
                    }
                }
                break;
        }
    }
}