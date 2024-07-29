using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Web;
using Application.Extensions;
using Application.Helper;
using Application.Services.Interface.Telegram;
using Application.Sessions;
using Application.Utilities;
using Domain.DTOs.Marzban;
using Domain.DTOs.Telegram;
using Domain.DTOs.Transaction;
using Domain.Entities.Marzban;
using Domain.Enums.Transaction;
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
                    // InlineKeyboardButton.WithCallbackData("همکاری در فروش 🤝", "collaboration"),
                    InlineKeyboardButton.WithCallbackData("کیف پول + شارژ 🏦", "wallet")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("کلمه عبور و نام کاربری سایت 🔒",
                        "web_information")
                }
            });

        return await botClient.SendTextMessageAsync(
            chatId: message.Chat.Id,
            text: "خوش آمدید بچه هایه خوب",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);
    }

    public async Task SendMainMenuAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, string? title = null)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        BotSessions
            .users_Sessions?
            .AddOrUpdate(chatId, new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.None),
                (key, old)
                    => old = new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.None));

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
                    InlineKeyboardButton.WithCallbackData("سرویس های من 🎁", "my_services"),
                },
                new[]
                {
                    // InlineKeyboardButton.WithCallbackData("همکاری در فروش 🤝", "collaboration"),
                    InlineKeyboardButton.WithCallbackData("کیف پول + شارژ 🏦", "wallet")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("کلمه عبور و نام کاربری سایت 🔒",
                        "web_information")
                }
            });

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }

        await botClient.SendTextMessageAsync(
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
                photo: new InputFileStream(Qr, user.Username),
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
        long subscribeId = 0;
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
                                                                           $"?marzbanvpntemplateId={id}" +
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
        try
        {
            long marzbanvpntemplateId = 0;
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
                Int64.TryParse(queryParameters["marzbanvpntemplateId"], out marzbanvpntemplateId);
                Int64.TryParse(queryParameters["marzbanvpnid"], out marzbanvpnid);
                Int32.TryParse(queryParameters["days"], out days);
                Int32.TryParse(queryParameters["gb"], out gb);
                Int64.TryParse(queryParameters["subscribeId"], out subscribeId);
            }

            if (subscribeId != 0)
            {
            }

            BuyMarzbanVpnDto buy = new();

            buy.MarzbanVpnId = marzbanvpnid;
            buy.MarzbanVpnTemplateId = marzbanvpntemplateId;
            buy.Count = 1;
            buy.TotalDay = days;
            buy.TotalGb = gb;

            MarzbanVpnTemplateDto? template = null;

            if (marzbanvpntemplateId != 0)
                template = await telegramService.GetMarzbanTemplateByIdAsync(marzbanvpntemplateId);

            List<MarzbanUser> marzbanUsers = await telegramService.BuySubscribeAsync(buy, chatId);

            foreach (MarzbanUser user in marzbanUsers)
            {
                byte[] QrImage = await GenerateQrCode
                    .GetQrCodeAsync(user.Subscription_Url);

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

        int id = 0;
        int vpnId = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int32.TryParse(queryParameters["id"], out id);
            Int32.TryParse(queryParameters["vpnId"], out vpnId);
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
                InlineKeyboardButton.WithCallbackData("تمدید سرویس 💊", $"vpn_template?id={vpnId}&subscribeId={id}"),
                // InlineKeyboardButton.WithCallbackData("تغییر لینک ⚙️", "change_link")
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

        int vpnId = 0;
        string callbackData = callbackQuery.Data;
        int questionMarkIndex = callbackData.IndexOf('?');

        if (questionMarkIndex >= 0)
        {
            string? query = callbackData?.Substring(questionMarkIndex);
            NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
            Int32.TryParse(queryParameters["vpnId"], out vpnId);
        }

        GetMarzbanVpnDto vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(vpnId);

        BotSessions
            .users_Sessions?
            .AddOrUpdate(chatId, new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.AwaitingGb, vpnId: vpnId),
                (key, old)
                    => old = new TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState.AwaitingGb, vpnId: vpnId));

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

    public async Task SendDaysPriceAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message!.Chat.Id;

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);
        var uservalue = user.Value.Value;

        GetMarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(uservalue.VpnId ?? 0);

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

        GetMarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(uservalue.VpnId ?? 0);
        User mainUser = await telegramService.GetUserByChatIdAsync(chatId);


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


            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("پرداخت و دریافت سرویس", $"buy_subscribe" +
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
                text: sub.GetInfo(),
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

        List<TransactionDetailDto> transactionDetail = await telegramService.GetTransactionDetailAsync();

        string information =
            $"\ud83d\udcb8 مبلغ را  به تومان وارد کنید:\n\u2705  حداقل مبلغ {transactionDetail[0].MinimalAmount} حداکثر مبلغ {transactionDetail[0].MaximumAmount} تومان می باشد";

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions
            .users_Sessions?.SingleOrDefault(x => x.Key == chatId);

        TelegramMarzbanVpnSession uservalue = user.Value.Value;

        uservalue.State = TelegramMarzbanVpnSessionState.AwatingSendPrice;

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

        List<TransactionDetailDto> transactionDetail = await telegramService.GetTransactionDetailAsync();

        var uservalue = user.Value.Value;

        if (transactionDetail[0].MaximumAmount < uservalue.Price | transactionDetail[0].MinimalAmount > uservalue.Price)
        {
            string exText =
                $"\u274c خطا \n\ud83d\udcac مبلغ باید حداقل {transactionDetail[0].MinimalAmount} تومان و حداکثر {transactionDetail[0].MaximumAmount} تومان باشد";

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
        {transactionDetail[0].CardNumber}
        {transactionDetail[0].CardHolderName}
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

            var uservalue = user.Value.Value;

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
}