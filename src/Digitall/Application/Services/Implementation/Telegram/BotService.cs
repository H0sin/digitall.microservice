using System.Collections.Specialized;
using System.Web;
using Application.Helper;
using Application.Services.Interface.Telegram;
using Domain.DTOs.Marzban;
using Domain.DTOs.Telegram;
using Domain.Entities.Marzban;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Application.Services.Implementation.Telegram;

public class BotService(ITelegramService telegramService) : IBotService
{
    public async Task<Message> StartLinkAsync(ITelegramBotClient botClient, Message message,
        CancellationToken cancellationToken)
    {
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

    public async Task SendMainMenuAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

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

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
        
        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "به منو اصلی بازگشتید 🏠",
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

        // حذف منوی قبلی اگر شماره پیام ارسالی موجود باشد
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
            await botClient.SendPhotoAsync(
                chatId: callbackQuery.Message.Chat.Id,
                photo: new InputFileStream(Qr, user.Subscription_Url),
                caption: caption,
                cancellationToken: cancellationToken);
        }
    }


    public async Task SendListVpnsTemplateAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
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

        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: " نوع سرویس خود را انتخاب کنید. 📌",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        // حذف منوی قبلی اگر شماره پیام ارسالی موجود باشد
        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task SendFactorVpnAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
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

        SubscribeFactorBotDto sub = await telegramService.SendFactorSubscribeAsync(buy, chatId);

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: sub.GetInfo(),
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);
        // حذف منوی قبلی اگر شماره پیام ارسالی موجود باش
        // د
        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task SendSubscriptionAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
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
        buy.Count = 1;

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
                await botClient.SendPhotoAsync(
                    chatId: callbackQuery.Message.Chat.Id,
                    photo: new InputFileStream(Qr, user.Subscription_Url),
                    caption: caption,
                    cancellationToken: cancellationToken);
            }
        }

        await botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        await SendMainMenuAsync(botClient, callbackQuery, cancellationToken);
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

        int id = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int32.TryParse(queryParameters["id"], out id);
        }

        SubescribeStatus.ServiceStatus status = await telegramService.GetMarzbanUserByChatIdAsync(id, chatId);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("دریافت ترافیک 🌍", $"get_traffic?id={id}"),
                InlineKeyboardButton.WithCallbackData("لینک اشتراک 🔗", $"subscription_link?id={id}")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("تمدید سرویس 💊", "renew_service"),
                InlineKeyboardButton.WithCallbackData("تغییر لینک ⚙️", "change_link")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("حذف سرویس ❌", "delete_service"),
                InlineKeyboardButton.WithCallbackData("خرید حجم اضافه ➕", "buy_extra_volume")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("تغییر وضعیت سرویس ❌", "change_service_status"),
                InlineKeyboardButton.WithCallbackData("خرید زمان اضافه ⏳", "buy_extra_time")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("تغییر لوکیشن 🌐", "change_location"),
                InlineKeyboardButton.WithCallbackData("انتقال سرویس به کاربر دیگر 🚚", "transfer_service")
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
}