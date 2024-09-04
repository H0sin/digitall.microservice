using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Runtime.InteropServices.JavaScript;
using System.Web;
using Application.Extensions;
using Application.Helper;
using Application.Services.Interface.Notification;
using Application.Services.Interface.Telegram;
using Application.Services.Interface.Transaction;
using Application.Sessions;
using Application.Static.Template;
using Application.Utilities;
using Data.Migrations;
using Domain.DTOs.Agent;
using Domain.DTOs.Marzban;
using Domain.DTOs.Notification;
using Domain.DTOs.Telegram;
using Domain.DTOs.Transaction;
using Domain.Entities.Agent;
using Domain.Entities.Marzban;
using Domain.Entities.Telegram;
using Domain.Entities.Transaction;
using Domain.Enums.Agent;
using Domain.Enums.Marzban;
using Domain.Enums.Transaction;
using Domain.Exceptions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Serilog;
using Serilog.Core;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using File = Telegram.Bot.Types.File;
using ILogger = Microsoft.Extensions.Logging.ILogger;
using User = Domain.Entities.Account.User;

namespace Application.Services.Implementation.Telegram;

public class BotService(
    ITelegramService telegramService,
    INotificationService notificationService,
    IWebHostEnvironment _env) : IBotService
{
    private IBotService _botServiceImplementation;

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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long agentId = 0;
        try
        {
            if (message.Text != null && message.Text.StartsWith("/start"))
            {
                Int64.TryParse((message.Text.Substring(6)), out agentId);
            }

            user.State = TelegramMarzbanVpnSessionState.None;
            user.UserSubscribeId = null;
            AgentOptionDto? agentOptions = await telegramService.StartTelegramBotAsync(new StartTelegramBotDto()
            {
                AgentCode = agentId,
                ChatId = message.Chat.Id,
                FirstName = message.From.FirstName,
                LastName = message.From.LastName,
                BotId = botClient.BotId,
                TelegramUsername = message.From.Username
            });

            bool isAgent = await telegramService.IsAgentAsyncByChatIdAsync(message.Chat.Id);

            IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

            keys.Add(new List<InlineKeyboardButton>()
            {
                InlineKeyboardButton.WithCallbackData("تست رایگان 😎", "test_free"),
                InlineKeyboardButton.WithCallbackData("خرید اشتراک 🔒", "subscribe")
            });

            keys.Add(new List<InlineKeyboardButton>()
            {
                InlineKeyboardButton.WithCallbackData("سرویس های من 🎁", "my_services"),
                InlineKeyboardButton.WithCallbackData("پشتیبانی",
                    "send_message")
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


            if (isAgent)
            {
                await SendAgentMenuForAdmin(botClient, message.Chat.Id, cancellationToken);
                await telegramService.UpdateUserMessageId(message.Chat.Id, message.MessageId);
                keys.Add(new()
                {
                    InlineKeyboardButton.WithCallbackData("همکاری در فروش 🤝",
                        "invitation_link"),
                    InlineKeyboardButton.WithCallbackData("لیست تراکنش ها \ud83d\udcb8",
                        $"transactions?id={message.Chat.Id}"),
                });
            }
            else
            {
                await DeleteMenu(botClient, message.Chat.Id, cancellationToken);

                keys.Add(new()
                {
                    InlineKeyboardButton.WithCallbackData("لیست تراکنش ها \ud83d\udcb8",
                        $"transactions?id={message.Chat.Id}"),
                });
            }

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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user, string? title = null)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        bool isAgent = await telegramService.IsAgentAsyncByChatIdAsync(chatId);

        //sesstion

        user.State = TelegramMarzbanVpnSessionState.None;
        user.UserSubscribeId = null;

        IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

        keys.Add(new List<InlineKeyboardButton>()
        {
            InlineKeyboardButton.WithCallbackData("تست رایگان 😎", "test_free"),
            InlineKeyboardButton.WithCallbackData("خرید اشتراک 🔒", "subscribe")
        });

        keys.Add(new List<InlineKeyboardButton>()
        {
            InlineKeyboardButton.WithCallbackData("سرویس های من 🎁", "my_services"),
            InlineKeyboardButton.WithCallbackData("پشتیبانی",
                "send_message")
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

        if (isAgent)
        {
            await SendAgentMenuForAdmin(botClient, chatId, cancellationToken);
            await telegramService.UpdateUserMessageId(chatId, callbackQuery.Message.MessageId);
            keys.Add(new()
            {
                InlineKeyboardButton.WithCallbackData("همکاری در فروش 🤝",
                    "invitation_link"),
                InlineKeyboardButton.WithCallbackData("لیست تراکنش ها \ud83d\udcb8", $"transactions?id={chatId}"),
            });
        }
        else
        {
            await DeleteMenu(botClient, chatId, cancellationToken);
            keys.Add(new()
            {
                InlineKeyboardButton.WithCallbackData("لیست تراکنش ها \ud83d\udcb8", $"transactions?id={chatId}"),
            });
        }

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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user,
        string? title = null)
    {
        long chatId = message.Chat.Id;

        bool isAgent = await telegramService.IsAgentAsyncByChatIdAsync(chatId);

        user.State = TelegramMarzbanVpnSessionState.None;
        user.UserSubscribeId = null;
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

        if (isAgent)
        {
            await SendAgentMenuForAdmin(botClient, chatId, cancellationToken);
            await telegramService.UpdateUserMessageId(chatId, message.MessageId);
            keys.Add(new()
            {
                InlineKeyboardButton.WithCallbackData("همکاری در فروش 🤝",
                    "invitation_link"),
                InlineKeyboardButton.WithCallbackData("لیست تراکنش ها \ud83d\udcb8", $"transactions?id={chatId}"),
            });
        }
        else
        {
            await DeleteMenu(botClient, chatId, cancellationToken);
            keys.Add(new()
            {
                InlineKeyboardButton.WithCallbackData("لیست تراکنش ها \ud83d\udcb8", $"transactions?id={chatId}"),
            });
        }

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
        try
        {
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
        catch (Exception e)
        {
            await botClient.SendTextMessageAsync(chatId, e.Message, cancellationToken: cancellationToken);
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

            var groupedTemplates = templates.GroupBy(x => x.Days);

            foreach (var group in groupedTemplates)
            {
                var firstTemplate = group.First();

                string text = group.Key switch
                {
                    31 => "یک ماه",
                    61 => "دو ماه",
                    91 => "سه ماه",
                    121 => "چهار ماه",
                    151 => "پنج ماه",
                    181 => "شش ماه",
                    211 => "هفت ماه",
                    241 => "هشت ماه",
                    271 => "نه ماه",
                    301 => "ده ماه",
                    331 => "یازده ماه",
                    361 => "یک سال",
                    _ => firstTemplate.Days + " روزه "
                };


                List<InlineKeyboardButton> button = new()
                {
                    InlineKeyboardButton.WithCallbackData(text,
                        "sendvpntemplate?id=" + firstTemplate.Id + "&vpnId=" + id + "&subscribeId=" + subscribeId +
                        "&days=" + firstTemplate.Days)
                };

                keys.Add(button);
            }

            List<InlineKeyboardButton> custom = new()
            {
                // InlineKeyboardButton.WithCallbackData("\ud83d\udecd حجم و زمان دلخواه",
                //     "custom_subscribe?vpnId=" + id + "&subscribeId" + subscribeId)
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
            await SendMainMenuAsync(botClient, callbackQuery, cancellationToken, new TelegramMarzbanVpnSession());
        }
    }

    public async Task SendFactorVpnAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
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


        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: user?.UserSubscribeId != null ? sub.GetRenewalInfo() : sub.GetInfo(),
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task SendSubscriptionAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        Message message = await
            botClient.SendTextMessageAsync(chatId, "در حال ساخت سرویس شما 🙏", cancellationToken: cancellationToken);
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

            BuyMarzbanVpnDto buy = new();

            buy.MarzbanVpnId = marzbanvpnid;
            buy.MarzbanVpnTemplateId = templateId;
            buy.Count = 1;
            buy.TotalDay = days;
            buy.TotalGb = gb;
            buy.MarzbanUserId = user?.UserSubscribeId;

            MarzbanVpnTemplateDto? template = null;

            if (templateId != 0)
                template = await telegramService.GetMarzbanTemplateByIdAsync(templateId);

            List<MarzbanUser> marzbanUsers = await telegramService.BuySubscribeAsync(buy, chatId);

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
                IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>(new[]
                {
                    new List<InlineKeyboardButton>()
                    {
                        InlineKeyboardButton.WithUrl("مشاهده اموزش 📖",
                            marzbanUser.Subscription_Url.TrimEnd())
                    }
                });

                using (var Qr = new MemoryStream(QrImage))
                {
                    await botClient.SendPhotoAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        photo: new InputFileStream(Qr, marzbanUser.Subscription_Url),
                        parseMode: ParseMode.MarkdownV2,
                        replyMarkup: new InlineKeyboardMarkup(keys),
                        caption: caption,
                        cancellationToken: cancellationToken);
                }
            }
            
            
            if (subscribeId > 0 && marzbanUsers.Count == 0)
            {
                await botClient.SendTextMessageAsync(chatId,"""
                                                            🙏 با تشکر از تمدید سرویس خود.
                                                            ✅ تمدید شما با موفقیت انجام شد.
                                                            ⬅️ برای بازگشت به لیست سرویس‌های خود یا مشاهده اطلاعات، روی دکمه‌های زیر کلیک کنید.
                                                            """,
                    replyMarkup:new InlineKeyboardMarkup(new []
                    {
                        InlineKeyboardButton.WithCallbackData("بازگشت به لیست سرویس‌ها 🏠", "my_services"),
                        InlineKeyboardButton.WithCallbackData("بازگشت به سرویس 🏠",$"subscribe_info?id={subscribeId}&vpnId={marzbanvpnid}"),
                    })
                    ,cancellationToken:cancellationToken);
            }
            
            user.State = TelegramMarzbanVpnSessionState.None;

            await botClient.DeleteMessageAsync(chatId, message.MessageId, cancellationToken: cancellationToken);
            await SendMainMenuAsync(botClient, callbackQuery, cancellationToken, user);
        }
        catch (Exception e)
        {
            IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

            User? current_user = await telegramService.GetUserByChatIdAsync(chatId);

            await botClient.DeleteMessageAsync(chatId, message.MessageId, cancellationToken: cancellationToken);

            List<InlineKeyboardButton> increase = new()
            {
                InlineKeyboardButton.WithCallbackData("\ud83d\udcb0 افزایش موجودی", "inventory_increase")
            };

            user.State = TelegramMarzbanVpnSessionState.None;

            await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                replyMarkup: new InlineKeyboardMarkup(increase),
                cancellationToken: cancellationToken);
            await SendMainMenuAsync(botClient, callbackQuery, cancellationToken, user);
        }
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
        User? user = await telegramService.GetUserByChatIdAsync(chatId);
        filter.UserId = user.Id;
        filter.Page = page;
        filter.Username = username;

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
        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("جستو جو سرویس \ud83d\udd0d", "search_list_service")
        });
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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
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

        user.UserSubscribeId = id;

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("تغییر لینک ⚙️", $"revoke_sub"),
            },
            new[]
            {
                // InlineKeyboardButton.WithCallbackData("دریافت کانفیگ ها 🌍", $"get_traffic?id={id}"),
                InlineKeyboardButton.WithCallbackData("لینک اشتراک 🔗", $"subscription_link?id={id}")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("تمدید سرویس 💊", $"vpn_template" +
                                                                        $"?id={vpnId}&" +
                                                                        $"subscribeId={id}"),
            },
            // new[]
            // {
            //     InlineKeyboardButton.WithCallbackData("خرید حجم اضافه ➕",
            //         $"custom_subscribe?vpnId={vpnId}&appendGb=true"),
            //     InlineKeyboardButton.WithCallbackData("خرید زمان اضافه ⌛️",
            //         $"append_date?vpnId={vpnId}&subscribeId={id}"),
            // },
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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
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


            user.VpnId = vpnId;
            user.State = (!appendGb)
                ? user.State =
                    TelegramMarzbanVpnSessionState.AwaitingGb
                : user.State = TelegramMarzbanVpnSessionState.AwaitingSendAppendGbForService;

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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message!.Chat.Id;

        MarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(user.VpnId ?? 0, chatId);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
            }
        });

        if (user.Gb > vpn?.GbMax | user.Gb < vpn?.GbMin | user.Gb == 0)
        {
            user.State = TelegramMarzbanVpnSessionState.AwaitingGb;

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text:
                $"\u274c حجم نامعتبر است.\n\ud83d\udd14 حداقل حجم {vpn.GbMin} گیگابایت و حداکثر {vpn.GbMax} گیگابایت می باشد",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
        else
        {
            user.State = TelegramMarzbanVpnSessionState.AwaitingDate;

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text:
                $"\u231b\ufe0f زمان سرویس خود را انتخاب نمایید \n\ud83d\udccc تعرفه هر روز  : {vpn?.DayPrice}  تومان\n\u26a0\ufe0f حداقل زمان {vpn?.DayMin} روز  و حداکثر {vpn?.DayMax} روز  می توانید تهیه کنید",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendCustomFactorVpnAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message!.Chat.Id;

        MarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(user.VpnId ?? 0, chatId);
        User? mainUser = await telegramService.GetUserByChatIdAsync(chatId);


        if (user.Date > vpn?.DayMax | user.Date < vpn?.DayMin | user.Date == 0)
        {
            user.State = TelegramMarzbanVpnSessionState.AwaitingDate;
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
            user.State = TelegramMarzbanVpnSessionState.AwaitingFactor;

            string payment = user.UserSubscribeId == null ? "دریافت سرویس" : $"تمدید سرویس";

            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData($"پرداخت و {payment}",
                        $"buy_subscribe" +
                        $"?marzbanvpnid={user.VpnId}" +
                        $"&gb={user.Gb}" +
                        $"&days={user.Date}")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
                }
            });

            SubscribeFactorBotDto sub = new()
            {
                Days = user.Date ?? 0,
                Gb = user.Gb ?? 0,
                Balance = mainUser.Balance,
                Count = 1,
                Price = ((user.Gb * vpn.GbPrice) + (user.Date * vpn.DayPrice)) * 1 ?? 0,
                Title = "خرید اشتراک"
            };

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: user.UserSubscribeId != null ? sub.GetRenewalInfo() : sub.GetInfo(),
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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        try
        {
            TransactionDetailDto? transactionDetail = await telegramService.GetTransactionDetailAsync(chatId);

            user.State = TelegramMarzbanVpnSessionState.AwaitingSendPrice;

            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
                }
            });

            if (transactionDetail is null)
                throw new ApplicationException("پرداخت کارت به کارت برای شما غیر فعال است.");

            bool isAgent = await telegramService.IsAgentAsyncByChatIdAsync(chatId);

            string information = "";

            if (isAgent)
                information =
                    $"\ud83d\udcb8 مبلغ را به تومان وارد کنید:\n\u2705 حداقل مبلغ {transactionDetail.MinimalAmountForAgent} حداکثر مبلغ {transactionDetail.MaximumAmountForAgent} تومان می باشد";
            else
                information =
                    $"\ud83d\udcb8 مبلغ را به تومان وارد کنید:\n\u2705 حداقل مبلغ {transactionDetail.MinimalAmountForUser} حداکثر مبلغ {transactionDetail.MaximumAmountForUser} تومان می باشد";

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: information,
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

    public async Task SendCardNumberAndDetailAsync(ITelegramBotClient? botClient, Message? message,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message!.Chat.Id;

        TransactionDetailDto? transactionDetail = await telegramService.GetTransactionDetailAsync(chatId);

        bool isAgent = await telegramService.IsAgentAsyncByChatIdAsync(chatId);

        if (isAgent)
        {
            if (transactionDetail!.MaximumAmountForAgent < user.Price |
                transactionDetail.MinimalAmountForAgent > user.Price)
            {
                string exText =
                    $"\u274c خطا \n\ud83d\udcac مبلغ باید حداقل {transactionDetail.MinimalAmountForAgent} تومان و حداکثر {transactionDetail.MaximumAmountForAgent} تومان باشد";

                await Task.CompletedTask;
                throw new AppException(exText);
            }
        }
        else
        {
            if (transactionDetail!.MaximumAmountForUser < user.Price |
                transactionDetail.MinimalAmountForUser > user.Price)
            {
                string exText =
                    $"\u274c خطا \n\ud83d\udcac مبلغ باید حداقل {transactionDetail.MinimalAmountForUser} تومان و حداکثر {transactionDetail.MaximumAmountForUser} تومان باشد";

                await Task.CompletedTask;
                throw new AppException(exText);
            }
        }

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("✅ پرداخت کردم  | ارسال رسید", "send_transaction_image")
            }
        });

        string text =
            $@"برای افزایش موجودی، مبلغ {user.Price:No}  تومان  را به شماره‌ی حساب زیر واریز کنید 👇🏻
        
        ==================== 
        {transactionDetail.CardNumber}
        {transactionDetail.CardHolderName}
        ====================

‼️مبلغ باید همان مبلغی که در بالا ذکر شده واریز نمایید.
‼️امکان برداشت وجه از کیف پول نیست.
‼️مسئولیت واریز اشتباهی با شماست.
🔝بعد از پرداخت  دکمه پرداخت کردم را زده سپس تصویر رسید را ارسال نمایید
💵بعد از تایید پرداختتون توسط ادمین کیف پول شما شارژ خواهد شد و در صورتی که سفارشی داشته باشین انجام خواهد شد";

        User? current_user = await telegramService.GetUserByChatIdAsync(chatId);
        AgentDto? agent = await telegramService.GetAgentByChatIdAsync(chatId);

        if (string.IsNullOrEmpty(transactionDetail.CardNumber) || !current_user.CardToCardPayment)
        {
            if (!current_user.CardToCardPayment)
            {
                await notificationService.AddNotificationAsync(
                    NotificationTemplate
                        .ErrorForAddTransactionNotification(agent.AgentAdminId, current_user.TelegramUsername,
                            current_user.ChatId ?? 0, user.Price, true), current_user.Id
                );
            }
            else
            {
                await notificationService.AddNotificationAsync(
                    NotificationTemplate
                        .ErrorForAddTransactionNotification(agent.AgentAdminId, current_user.TelegramUsername,
                            current_user.ChatId ?? 0, user.Price), current_user.Id
                );
            }

            text = "پرداخت غیر فعال است";
            user.State = TelegramMarzbanVpnSessionState.None;
            throw new AppException(text);
        }

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: text,
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        await Task.CompletedTask;
    }

    public async Task AwaitingForTransactionImageAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        user.State = TelegramMarzbanVpnSessionState.AwaitingSendTransactionImage;

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

    public async Task AddTransactionAsync(ITelegramBotClient? botClient, Message? message,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message!.Chat.Id;

        if (message.Type == MessageType.Photo)
        {
            user.State = TelegramMarzbanVpnSessionState.None;

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
                Price = user.Price,
                Title = "افزایش موجودی"
            };

            CallbackQuery callbackQuery = new CallbackQuery()
            {
                Data = "back_to_main",
                Message = message
            };

            await telegramService.AddTransactionAsync(transaction, chatId);
            await SendMainMenuAsync(botClient, callbackQuery, cancellationToken, new TelegramMarzbanVpnSession(),
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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message!.Chat.Id;

        MarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(user.VpnId ?? 0, chatId);

        SubscribeFactorBotDto sub = new SubscribeFactorBotDto()
        {
            Gb = user.Gb ?? 0,
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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message!.Chat.Id;


        MarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(user.VpnId ?? 0, chatId);

        SubscribeFactorBotDto sub = new SubscribeFactorBotDto()
        {
            Days = user.Date ?? 0,
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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        MarzbanVpnDto? marzbanVpn = await telegramService
            .GetMarzbanVpnInformationByIdAsync(user.VpnId ?? 0, chatId);

        BuyMarzbanVpnDto buy = new();

        buy.MarzbanVpnId = user.VpnId ?? 0;
        buy.Count = 1;
        buy.TotalGb = user.Gb ?? 0;
        buy.MarzbanUserId = user?.UserSubscribeId;

        List<MarzbanUser> marzbanUsers = await telegramService.BuySubscribeAsync(buy, chatId);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("بازگشت به سروی ",
                    $"subscribe_info?id={user.UserSubscribeId}&vpnId={user.VpnId}")
            },
        });

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "\u2705 افزایش حجم برای سرویس شما با موفقیت صورت گرفت\n\n" +
                  $"\u25ab\ufe0fحجم اضافه : {buy.TotalGb} گیگ\n\n" +
                  $"\u25ab\ufe0fمبلغ افزایش حجم : {user.Gb * marzbanVpn.GbPrice} تومان",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task AcceptAppendDaysAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        MarzbanVpnDto? marzbanVpn = await telegramService
            .GetMarzbanVpnInformationByIdAsync(user.VpnId ?? 0, chatId);

        BuyMarzbanVpnDto buy = new();

        buy.MarzbanVpnId = user.VpnId ?? 0;
        buy.Count = 1;
        buy.TotalDay = user.Date ?? 0;
        buy.MarzbanUserId = user?.UserSubscribeId;

        await telegramService.BuySubscribeAsync(buy, chatId);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("بازگشت به سرور ",
                    $"subscribe_info?id={user.UserSubscribeId}&vpnId={user.VpnId}")
            },
        });

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: "\u2705 افزایش روز برای سرویس شما با موفقیت صورت گرفت\n\n" +
                  $"\u25ab\ufe0fروز اضافه : {buy.TotalDay}\n\n" +
                  $"\u25ab\ufe0fمبلغ افزایش حجم : {user.Date * marzbanVpn.DayPrice} تومان",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        if (callbackQuery.Message.MessageId != 0)
        {
            await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
        }
    }

    public async Task SendDaysPriceForAppendDaysAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
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

        user.VpnId = vpnId;
        user.UserSubscribeId = subscribeId;


        MarzbanVpnDto? vpn = await telegramService.GetMarzbanVpnInformationByIdAsync(user.VpnId ?? 0, chatId);

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
            }
        });

        user.State = TelegramMarzbanVpnSessionState.AwaitingSendAppendDaysForService;

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text:
            $"\u231b\ufe0f زمان سرویس خود را انتخاب نمایید \n\ud83d\udccc تعرفه هر روز  : {vpn?.DayPrice}  تومان\n\u26a0\ufe0f حداقل زمان {vpn?.DayMin} روز  و حداکثر {vpn?.DayMax} روز  می توانید تهیه کنید",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);
    }

    public async Task ActiveMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        try
        {
            if (user.UserSubscribeId is null)
            {
                throw new NotFoundException("با عرض پوزش سرور پاسخگو نمیباشد");
            }

            await telegramService.ChangeMarzbanUserStatusAsync(MarzbanUserStatus.active, user.UserSubscribeId ?? 0,
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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;

        try
        {
            if (user.UserSubscribeId is null)
            {
                throw new NotFoundException("با عرض پوزش سرور پاسخگو نمیباشد");
            }

            await telegramService.ChangeMarzbanUserStatusAsync(MarzbanUserStatus.disabled,
                user.UserSubscribeId ?? 0,
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
            await SendMainMenuAsync(botClient!, callbackQuery, cancellationToken, new TelegramMarzbanVpnSession());
        }
    }

    public async Task RequestForAgentAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message!.Chat.Id;
        try
        {
            await telegramService.AddRequestAgentAsync(message.Text ?? "", user.Phone, chatId);

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

    public async Task SendTextDeleteMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        try
        {
            if (await telegramService.DeleteServiceInQue(chatId))
            {
                throw new AppException("شما یک درخواست برسی نشده در صف دارید");
            }

            user.State = TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForDeleteMarzbanUser;
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: "لطفا درخواست خود را" + "\n" +
                      " برای حذف سرویس ارسال کنید",
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

    public async Task DeleteMarzbanUserAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message!.Chat.Id;
        try
        {
            user.State = TelegramMarzbanVpnSessionState.AwaitingSendDescriptionForDeleteMarzbanUser;
            AgentDto? agent = await telegramService.GetAgentByChatIdAsync(chatId);

            SubescribeStatus.ServiceStatus? status =
                await telegramService.GetMarzbanUserByChatIdAsync(user.UserSubscribeId ?? 0, chatId);

            global::Telegram.Bot.Types.User telegramUser = await botClient.GetMeAsync();

            await telegramService.DeleteMarzbanUserAsync(user.UserSubscribeId ?? 0, chatId);

            await notificationService
                .AddNotificationAsync(
                    NotificationTemplate
                        .SendDeleteMarzbanUserNotificationForAgent(agent.AgentAdminId,
                            status
                                .GenerateServiceDeletionRequestMessage
                                (telegramUser.Username ?? "NOUSERNAME", chatId,
                                    message.Text ?? ""), status.MarzbanUserId), agent.AgentAdminId);

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: "درخواست شما ثبت شد منتظر" +
                      " برسی کارشناسان باشید !",
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

    public async Task RevokeSubscribeAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        try
        {
            string sub = await telegramService.RevokeMarzbanUserAsync(user.UserSubscribeId ?? 0, chatId);

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
        TelegramLinkDto? link = await telegramService.GetAgentBotLinkAsync(callbackQuery!.Message!.Chat.Id);
        await botClient!.SendTextMessageAsync(
            callbackQuery!.Message!.Chat.Id,
            $"با استفاده از لینک میتونید از دعوت دوستان خودتون به ربات کسب درآمد کنید.\n\n👇👇👇👇👇👇👇👇👇👇\n\n🔗 {link.GenerateLink(userInfo.Username)}",
            cancellationToken: cancellationToken
        );
        await Task.CompletedTask;
    }

    public async Task SendAgentMenuForAdmin(ITelegramBotClient botClient, long chatId,
        CancellationToken cancellationToken)
    {
        User? user = await telegramService.GetUserByChatIdAsync(chatId);

        var keyboard = new ReplyKeyboardMarkup(new[]
        {
            (user!.IsSupperAdmin ? new KeyboardButton[] { "مدیرت ربات \u2699\ufe0f" } : new KeyboardButton[] { }),
            new KeyboardButton[] { "مدیریت پنل نمایندگی \u270f\ufe0f", "آمار نمایندگی \ud83d\udcca" },
            new KeyboardButton[] { "جستجو کاربر \ud83d\udd0d", "ارسال پیام \u2709\ufe0f" },
            new KeyboardButton[] { "\ud83c\udfe0 بازگشت به منو اصلی" },
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
                new KeyboardButton[] { "مدیریت نماینده ها \ud83d\udc65" },
                new KeyboardButton[] { "ثبت | تغییر شماره کارت \ud83d\udcb3", "ثبت | تغییر نام نمایندگی \ud83d\udc65" },
                new KeyboardButton[] { "مشاهده اطلاعات پرداخت \ud83d\udcb0" },
                new KeyboardButton[] { "تغییر درصد کاربر", "تغییر درصد نماینده" },
                new KeyboardButton[] { "\ud83d\udd22 پرداخت نمایندگی", "\ud83d\udd22 پرداخت کاربری" },
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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message.Chat.Id;
        try
        {
            user.State = TelegramMarzbanVpnSessionState.AwaitingSendCardNumber;

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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message.Chat.Id;
        try
        {
            user.State = TelegramMarzbanVpnSessionState.AwaitingSendCardHolderName;
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

            string text = $"💳 شماره کارت: {transaction.CardNumber ?? "ثبت نشده"} \n" +
                          $"👤 نام صاحب کارت: {transaction.CardHolderName ?? "ثبت نشده"}\n" +
                          $"📈 درصد سود پیش‌ فرض از کاربر عادی: %{transaction.AgentPercent}\n" +
                          $"📊 درصد سود پیش‌ فرض از نماینده: %{transaction.UserPercent}\n" +
                          $"💰 سقف پرداخت نماینده: {transaction.MaximumAmountForAgent:N0}\n" +
                          $"💵 کف پرداخت نماینده: {transaction.MinimalAmountForAgent:N0}\n" +
                          $"💰 سقف پرداخت کاربر: {transaction.MaximumAmountForUser:N0}\n" +
                          $"💵 کف پرداخت کاربر: {transaction.MinimalAmountForUser:N0}\n";


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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        try
        {
            long chatId = message.Chat.Id;


            user.State = TelegramMarzbanVpnSessionState.AwaitingSendAgentPercent;

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
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        try
        {
            long chatId = message.Chat.Id;

            user.State = TelegramMarzbanVpnSessionState.AwaitingSendUserPercent;

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

    public async Task<Message> UpdateAgentPersionBrandNameAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        try
        {
            long chatId = message.Chat.Id;

            user.State = TelegramMarzbanVpnSessionState.AwaitingSendPersianBrandName;
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
                        نام فعلی فارسی نمایندگی : {agentInformation.PersianBrandName ?? "ثبت نشده است"}
                         نام فعلی انگیلیسی نمایندگی :{agentInformation.BrandName ?? "ثبت نشده است"}
                         لطفا نام فارسی نمایندگی را ارسال کنید!
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

    public async Task AcceptAgentRequestAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        try
        {
            long Id = 0;

            string callbackData = callbackQuery.Data;
            int questionMarkIndex = callbackData.IndexOf('?');

            if (questionMarkIndex >= 0)
            {
                string? query = callbackData?.Substring(questionMarkIndex);
                NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
                Int64.TryParse(queryParameters["Id"], out Id);
            }

            await telegramService.ChangeAgentRequestAsync(chatId, new()
            {
                Id = Id,
                AgentRequestStatus = "accept"
            });

            await botClient!.SendTextMessageAsync(
                chatId,
                $"""عملیات با موفقیت انجام شد""",
                replyMarkup: null,
                cancellationToken: cancellationToken);

            if (callbackQuery.Message.MessageId != 0)
            {
                await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
            }
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId,
                $"""عملیات با مشکل مواجه شد""",
                replyMarkup: null,
                cancellationToken: cancellationToken);
        }
    }

    public async Task RejectAgentRequestAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        try
        {
            long id = 0;

            string callbackData = callbackQuery.Data;
            int questionMarkIndex = callbackData.IndexOf('?');

            if (questionMarkIndex >= 0)
            {
                string? query = callbackData?.Substring(questionMarkIndex);
                NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
                Int64.TryParse(queryParameters["Id"], out id);
            }

            await telegramService.ChangeAgentRequestAsync(chatId, new()
            {
                Id = id,
                AgentRequestStatus = "reject"
            });

            await botClient!.SendTextMessageAsync(
                chatId,
                $"""عملیات با موفقیت انجام شد""",
                replyMarkup: null,
                cancellationToken: cancellationToken);

            if (callbackQuery.Message.MessageId != 0)
            {
                await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
            }
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId,
                e.Message,
                replyMarkup: null,
                cancellationToken: cancellationToken);
        }
    }

    public async Task ChangeStateCardToCard(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        try
        {
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

            bool response = await telegramService.ActionForCardToCardAsync(chatId, id, action);

            string? message = "";

            if (response)
                message = "شماره کارت فعال شد";
            else
                message = "شماره کارت غیر فعال شد";

            await botClient!.SendTextMessageAsync(
                chatId,
                text: message,
                replyMarkup: null,
                cancellationToken:
                cancellationToken);
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId,
                e.Message,
                replyMarkup: null,
                cancellationToken: cancellationToken);
            await Task.CompletedTask;
        }
    }

    public async Task ManagementUserAsync(ITelegramBotClient botClient, long chatId, long userId,
        CancellationToken cancellationToken)
    {
        IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("افزایش موجودی \u2795", $"increase_by_agent?id={userId}"),
            InlineKeyboardButton.WithCallbackData("کاهش موجودی \u2796", $"decrease_by_agent?id={userId}"),
        });

        UserInformationDto information = await telegramService.GetUserInformationAsync(chatId, userId);

        bool isAgent = await telegramService.IsAgentAsyncByChatIdAsync(information.ChatId ?? 0);


        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("رفع مسدودی کاربر\u2705", $"on_blocked_user?id={userId}"),
            InlineKeyboardButton.WithCallbackData("مسدود کردن کاربر\u274c", $"blocked_user?id={userId}")
        });

        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("ارسال پیام \ud83d\udcac", $"send_message_user?id={userId}"),
        });

        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("لیست تراکنش ها \ud83d\udcb8", $"transactions?id={userId}"),
        });

        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("فعال کردن شماره کارت \u2705",
                $"action_card?id={userId}&action={true}"),
            InlineKeyboardButton.WithCallbackData("غیر فعال کردن شماره کارت  \u274c",
                $"action_card?id={userId}&action={false}")
        });

        if (isAgent)
        {
            AgentDto? admin = await telegramService.GetAgentByAdminChatIdAsync(information.ChatId ?? 0);
            List<AgentsIncomesDetail> incomes = await telegramService.GetAgentIncomesDetails(admin.Id);
            information.SumAgentIncomes = incomes.Sum(x => x.Profit);

            keys.Add(new()
            {
                InlineKeyboardButton.WithCallbackData("تغییر در صد نماینده  \u2699\ufe0f",
                    $"change_agent_percent?id={admin!.Id}")
            });
            information.IsAgent = true;
            information.SpecialPercent = (admin.SpecialPercent != 0 && admin?.SpecialPercent != null)
                ? admin.SpecialPercent
                : admin?.AgentPercent;
        }
        else
        {
            keys.Add(new()
            {
                InlineKeyboardButton.WithCallbackData("نماینده کردن \ud83e\udd39\u200d\u2642\ufe0f",
                    $"added_agent?id={information!.ChatId}")
            });
        }

        keys.Add(new()
        {
            InlineKeyboardButton.WithCallbackData("\ud83c\udfe0 بازگشت به منو اصلی", "back_to_main")
        });

        await botClient.SendTextMessageAsync(
            chatId,
            information.GetInformation(),
            replyMarkup: new InlineKeyboardMarkup(keys),
            cancellationToken: cancellationToken);

        await Task.CompletedTask;
    }

    public async Task IncreaseUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
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

        user.State = TelegramMarzbanVpnSessionState.AwaitingSendPriceForIncrease;
        user.UserChatId = id;

        await botClient!
            .SendTextMessageAsync(
                chatId: chatId,
                "لطفا مبلغ ارسالی برای شارژ را ارسال کنید!",
                cancellationToken: cancellationToken);

        await Task.CompletedTask;
    }

    public async Task DecreaseUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
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

        user.State = TelegramMarzbanVpnSessionState.AwaitingSendPriceForDecrease;
        user.UserChatId = id;

        await botClient!
            .SendTextMessageAsync(
                chatId: chatId,
                "لطفا مبلغ ارسالی برای کسر موجودی را ارسال کنید!",
                cancellationToken: cancellationToken);

        await Task.CompletedTask;
    }

    public async Task<Message> SearchUserByChatAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message!.Chat.Id;

        user.State = TelegramMarzbanVpnSessionState.AwaitingSearchUserByChatId;

        return await botClient!.SendTextMessageAsync(
            chatId: chatId,
            "ایدی عددی کاربر را ارسال کنید.",
            cancellationToken: cancellationToken);
    }

    public async Task UpdateTransactionStatusAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        try
        {
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

            await telegramService.UpdateTransactionAsync(new UpdateTransactionStatusDto(status, id), chatId);

            string typeTransaction = status == TransactionStatus.Accepted ? "قبول" : "رد";
            await botClient!.SendTextMessageAsync(
                chatId,
                $"تراکنش {typeTransaction}  شد",
                replyMarkup: null,
                cancellationToken: cancellationToken);
            await Task.CompletedTask;
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId,
                e.Message,
                replyMarkup: null,
                cancellationToken: cancellationToken);
            await Task.CompletedTask;
        }
    }

    public async Task BlockUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        try
        {
            long id = 0;

            string callbackData = callbackQuery.Data;
            int questionMarkIndex = callbackData.IndexOf('?');

            if (questionMarkIndex >= 0)
            {
                string? query = callbackData?.Substring(questionMarkIndex);
                NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
                Int64.TryParse(queryParameters["id"], out id);
            }

            await telegramService.BlockUserAsync(chatId, id, true);
            await botClient!.SendTextMessageAsync(
                chatId,
                "کاربر غیر فعال شد.",
                replyMarkup: null,
                cancellationToken: cancellationToken);
            await Task.CompletedTask;
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId,
                e.Message,
                replyMarkup: null,
                cancellationToken: cancellationToken);
            await Task.CompletedTask;
        }
    }

    public async Task OnBlockUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery!.Message!.Chat.Id;
        try
        {
            long id = 0;

            string callbackData = callbackQuery.Data;
            int questionMarkIndex = callbackData.IndexOf('?');

            if (questionMarkIndex >= 0)
            {
                string? query = callbackData?.Substring(questionMarkIndex);
                NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
                Int64.TryParse(queryParameters["id"], out id);
            }

            await telegramService.BlockUserAsync(chatId, id, false);
            await botClient!.SendTextMessageAsync(
                chatId,
                "کاربر فعال شد.",
                replyMarkup: null,
                cancellationToken: cancellationToken);
            await Task.CompletedTask;
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId,
                e.Message,
                replyMarkup: null,
                cancellationToken: cancellationToken);
            await Task.CompletedTask;
        }
    }

    public async Task<Message> ChangeAgentPaymentOptionAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message!.Chat.Id;
        user.State = TelegramMarzbanVpnSessionState.AwaitingSendMaximumAmountForAgent;

        TransactionDetailDto? transactionDetail = await telegramService.GetAgentTransactionDetailAsync(chatId);
        string text =
            "💰 سقف پرداخت: " + transactionDetail?.MaximumAmountForAgent.ToString("N0") + " تومان\n" +
            "💵 کف پرداخت: " + transactionDetail?.MinimalAmountForAgent.ToString("N0") + " تومان\n" +
            "📤 لطفاً سقف پرداخت نماینده را ارسال کنید";

        return await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: text,
            cancellationToken: cancellationToken);
    }

    public async Task<Message> ChangeUserPaymentOptionAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message!.Chat.Id;

        user.State = TelegramMarzbanVpnSessionState.AwaitingSendMaximumAmountForUser;

        TransactionDetailDto? transactionDetail = await telegramService.GetAgentTransactionDetailAsync(chatId);
        string text =
            "💰 سقف پرداخت: " + transactionDetail?.MaximumAmountForUser.ToString("N0") + " تومان\n" +
            "💵 کف پرداخت: " + transactionDetail?.MinimalAmountForUser.ToString("N0") + " تومان\n" +
            "📤 لطفاً سقف پرداخت کاربر را ارسال کنید";

        return await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text: text,
            cancellationToken: cancellationToken);
    }

    public async Task<Message> SendListAgentsAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message.Chat.Id;
        try
        {
            FilterAgentDto agents = await telegramService.FilterAgentsAsync(chatId);

            IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

            keys.Add(new List<InlineKeyboardButton>()
            {
                InlineKeyboardButton.WithCallbackData("نام نماینده"),
                InlineKeyboardButton.WithCallbackData("نام نمایندگی"),
                InlineKeyboardButton.WithCallbackData("آیدی عددی کاربر")
            });

            foreach (var agent in agents.Entities)
            {
                string? name = (!string.IsNullOrEmpty(agent?.PersianBrandName)
                    ? agent.PersianBrandName
                    : (!string.IsNullOrEmpty(agent?.BrandName) ? agent?.BrandName : "نام ثبت نشده"));

                List<InlineKeyboardButton> key = new()
                {
                    InlineKeyboardButton.WithCallbackData(agent?.User.UserFullName(),
                        $"user_management?id={agent?.User?.ChatId}"),
                    InlineKeyboardButton.WithCallbackData(name, $"user_management?id={agent?.User.ChatId}"),
                    InlineKeyboardButton.WithCallbackData(agent?.User?.ChatId.ToString(),
                        $"user_management?id={agent?.User?.ChatId}"),
                };
                keys.Add(key);
            }

            return await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: """
                      یکی از نماینده هایه لیست زیر را انتخاب کنید !
                      لطفا رویه نام نمایندگی ضربه بزنید
                      """,
                replyMarkup: new InlineKeyboardMarkup(keys),
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            return await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendChildAgentInformation(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        try
        {
            long id = 0;

            string callbackData = callbackQuery.Data;
            int questionMarkIndex = callbackData.IndexOf('?');

            if (questionMarkIndex >= 0)
            {
                string? query = callbackData?.Substring(questionMarkIndex);
                NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
                Int64.TryParse(queryParameters["id"], out id);
            }

            if (callbackQuery.Message.MessageId != 0)
            {
                await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
            }

            AgentInformationDto information = await telegramService.GetAgentInformationByIdAsync(chatId, id);
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: information.Information_Text(),
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

    public async Task SendMessageForUpdateSpecialPercent(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        try
        {
            long id = 0;

            string callbackData = callbackQuery.Data;
            int questionMarkIndex = callbackData.IndexOf('?');

            if (questionMarkIndex >= 0)
            {
                string? query = callbackData?.Substring(questionMarkIndex);
                NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
                Int64.TryParse(queryParameters["id"], out id);
            }

            if (callbackQuery.Message.MessageId != 0)
            {
                await botClient!.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
            }

            user.State = TelegramMarzbanVpnSessionState.AwaitingSendSpecialPercent;
            user.ChildAgentId = id;

            await botClient!.SendTextMessageAsync(chatId: chatId,
                text: "لطفا درصدی که در نظر دارید از این نماینده سود بگیرید را ارسال کنید",
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

    public async Task SendTicketMenuAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

        keys.Add(new List<InlineKeyboardButton>()
        {
            InlineKeyboardButton.WithCallbackData(" \u2709\ufe0f ارسال پیام به پشتیبانی", "send_message_agent"),
            InlineKeyboardButton.WithCallbackData("سوالات متداول \u2753", "default_question")
        });

        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text:
            "\u260e\ufe0f  در دکمه زیر ( سوالات متداول ) سوالات پرتکرار شما آمده است. روی دکمه زیر کلیک کنید در صورت نیافتن سوال خود روی دکمه پشتیبانی کلیک کنید",
            replyMarkup: new InlineKeyboardMarkup(keys),
            cancellationToken: cancellationToken);
    }

    public async Task SendDefaultQuestionAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        await botClient!.SendTextMessageAsync(
            chatId: chatId,
            text:
            """
            💡 سوالات متداول ⁉️

            1️⃣ فیلترشکن شما آیپی ثابته؟ میتونم برای صرافی های ارز دیجیتال استفاده کنم؟

            ✅ به دلیل وضعیت نت و محدودیت های کشور سرویس ما مناسب ترید نیست و فقط لوکیشن‌ ثابته.

            2️⃣ اگه قبل از منقضی شدن اکانت، تمدیدش کنم روزهای باقی مانده می سوزد؟

            ✅ خیر، روزهای باقیمونده اکانت موقع تمدید حساب میشن و اگه مثلا 5 روز قبل از منقضی شدن اکانت 1 ماهه خودتون اون رو تمدید کنید 5 روز باقیمونده + 30 روز تمدید میشه.

            3️⃣ اگه به یک اکانت بیشتر از حد مجاز متصل شیم چه اتفاقی میافته؟

            ✅ در این صورت حجم سرویس شما زود تمام خواهد شد.

            4️⃣ فیلترشکن شما از چه نوعیه؟

            ✅ فیلترشکن های ما v2ray است و پروتکل‌های مختلفی رو ساپورت میکنیم تا حتی تو دورانی که اینترنت اختلال داره بدون مشکل و افت سرعت بتونید از سرویستون استفاده کنید.

            5️⃣ فیلترشکن از کدوم کشور است؟

            ✅ سرور فیلترشکن ما از کشور  آلمان است

            6️⃣ چطور باید از این فیلترشکن استفاده کنم؟

            ✅ برای آموزش استفاده از برنامه، روی دکمه «📚 آموزش» بزنید.

            7️⃣ فیلترشکن وصل نمیشه، چیکار کنم؟

            ✅ به همراه یک عکس از پیغام خطایی که میگیرید به پشتیبانی مراجعه کنید.

            8️⃣ فیلترشکن شما تضمینی هست که همیشه مواقع متصل بشه؟

            ✅ به دلیل قابل پیش‌بینی نبودن وضعیت نت کشور، امکان دادن تضمین نیست فقط می‌تونیم تضمین کنیم که تمام تلاشمون رو برای ارائه سرویس هر چه بهتر انجام بدیم.

            9️⃣ امکان بازگشت وجه دارید؟

            ✅ امکان بازگشت وجه در صورت حل نشدن مشکل از سمت ما وجود دارد.

            💡 در صورتی که جواب سوالتون رو نگرفتید میتونید به «پشتیبانی» مراجعه کنید.
            """,
            cancellationToken: cancellationToken);
    }

    public Task SendTicketGroupingAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<Message> SendTicketAsync(ITelegramBotClient botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message.Chat.Id;
        try
        {
            AgentDto? agent = await telegramService.GetAgentByChatIdAsync(chatId);
            User? user = await telegramService.GetUserByChatIdAsync(chatId);

            IFormFile? formFile = null;
            File? file = null;

            string? fileId = message?.Photo?[^1].FileId;

            if (fileId != null && await botClient.GetFileAsync(
                    fileId ?? null,
                    cancellationToken: cancellationToken) != null)
            {
                file = await botClient.GetFileAsync(
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
                    PathExtension.TicketAvatarOriginServer(_env)
                    , 100, 100,
                    PathExtension.TicketAvatarThumbServer(_env));
            }

            await notificationService.AddNotificationAsync(
                NotificationTemplate.SendTicketForAgentAsync(
                    agent.AgentAdminId,
                    message?.Caption ?? message?.Text,
                    user?.ChatId ?? 0,
                    user?.TelegramUsername ?? "NOUSERNAME",
                    DateTime.Now,
                    file is not null ? PathExtension.TicketAvatarOriginServer(_env) + formFile.FileName : null
                ), user!.Id);

            return await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: "پیغام شما با موفقیت برای نماینده ارسال شد.",
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            return await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message + "مشکلی در ثبت پیام رخ داد.",
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendMarzbanVpnTemplatesGbAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        try
        {
            IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

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

            List<MarzbanVpnTemplateDto> templates =
                await telegramService.SendTemplatesGroupingByDays(chatId, vpnId, days);

            templates = templates.OrderBy(x => x.Gb).ToList();

            foreach (var template in templates)
            {
                keys.Add(new()
                {
                    InlineKeyboardButton.WithCallbackData($"{template.Gb} گیگ {template.Price:N0} تومان",
                        "factor_subscribe?id=" + template.Id + "&vpnId=" + vpnId + "&subscribeId=" + subscribeId)
                });
            }

            keys.Add(
                new List<InlineKeyboardButton>()
                {
                    InlineKeyboardButton.WithCallbackData("بازگشت", $"vpn_template?id={vpnId}")
                });

            await botClient!.SendTextMessageAsync(chatId, "یکی از آیتم هایه زیر را انتخاب کنید",
                replyMarkup: new InlineKeyboardMarkup(keys),
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task SendMessageForUserAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message!.Chat.Id;
        try
        {
            TelegramMarzbanVpnSession? user_value = BotSessions
                .users_Sessions!
                .SingleOrDefault(x => x.Key == chatId).Value;

            IFormFile? formFile = null;
            File? file = null;

            string? fileId = message?.Photo?[^1].FileId;

            if (fileId != null && await botClient.GetFileAsync(
                    fileId ?? null,
                    cancellationToken: cancellationToken) != null)
            {
                file = await botClient.GetFileAsync(
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
                    PathExtension.TicketAvatarOriginServer(_env)
                    , 100, 100,
                    PathExtension.TicketAvatarThumbServer(_env));
            }

            User? user = await telegramService.GetUserByChatIdAsync(user_value.UserChatId);

            await notificationService.AddNotificationAsync(
                NotificationTemplate.SendTicketForUserAsync(
                    user!.Id,
                    user.ChatId ?? 0,
                    message?.Caption ?? message?.Text,
                    DateTime.Now,
                    file is not null ? PathExtension.TicketAvatarOriginServer(_env) + formFile.FileName : null
                ), user!.Id);

            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: "پیغام شما با موفقیت برای نماینده ارسال شد.",
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task AddAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;
        try
        {
            long Id = 0;
            string callbackData = callbackQuery.Data;
            int questionMarkIndex = callbackData.IndexOf('?');
            if (questionMarkIndex >= 0)
            {
                string? query = callbackData?.Substring(questionMarkIndex);
                NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
                Int64.TryParse(queryParameters["id"], out Id);
            }

            await telegramService.AddAgentAsync(chatId, Id);

            await botClient!.SendTextMessageAsync(chatId, "کاربر با موفقیت نماینده شده",
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(chatId, e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task SendTransactionsAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        try
        {
            long Id = 0;
            string callbackData = callbackQuery.Data;
            int questionMarkIndex = callbackData.IndexOf('?');
            if (questionMarkIndex >= 0)
            {
                string? query = callbackData?.Substring(questionMarkIndex);
                NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
                Int64.TryParse(queryParameters["id"], out Id);
            }

            List<TransactionDto> transactions = await telegramService.GetTransactionsAsync(Id);

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
                               PathExtension.TransactionAvatarOriginServer(_env) + transaction.AvatarTransaction,
                               FileMode.Open, FileAccess.Read,
                               FileShare.Read))
                    {
                        var inputOnlineFile =
                            new InputFileStream(stream,
                                Path.GetFileName(PathExtension.TransactionAvatarOriginServer(_env) +
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
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(chatId, e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task<Message> SendMessageBeforSendMessageForMember(ITelegramBotClient? botClient,
        Message message,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        user.State = TelegramMarzbanVpnSessionState.AwaitingSendMessageForAllUser;

        return await botClient.SendTextMessageAsync(
            message.Chat.Id,
            "لطفا پیغام خود را ارسال کنید",
            cancellationToken: cancellationToken);
    }

    public async Task SendMessageForMembersAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken)
    {
        long chatId = message.Chat.Id;
        string? text = message.Text;
        try
        {
            if (string.IsNullOrEmpty(text) || text.Length < 5 || text.Length > 700)
                throw new AppException("""
                                       نمیتواند متن ارسالی بیشتر از 700 و کمتر از 5 کاراکتر باشد
                                       لطفا فرمت درست را ارسال کنید
                                       """);
            await telegramService.SendMessageForAgentMembers(chatId, text);

            await botClient.SendTextMessageAsync(
                chatId,
                "پیغام با موفقیت ارسال شد.",
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            await botClient.SendTextMessageAsync(
                chatId,
                e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task GetServiceByUserNameAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken, TelegramMarzbanVpnSession user)
    {
        long chatId = message.Chat.Id;
        try
        {
            string userName = message.Text;
            if (string.IsNullOrEmpty(userName) | userName.Length < 4)
                throw new AppException("لطفا نام کاربری درست ارسال کنید");

            SubescribeStatus.ServiceStatus? status = await telegramService.GetMarzbanUserByUserName(chatId, userName);

            user.UserSubscribeId = status.MarzbanUserId;
            user.VpnId = status.VpnId;

            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("تغییر لینک ⚙️", $"revoke_sub"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("دریافت ترافیک 🌍", $"get_traffic?id={status.MarzbanUserId}"),
                    InlineKeyboardButton.WithCallbackData("لینک اشتراک 🔗",
                        $"subscription_link?id={status.MarzbanUserId}")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("تمدید سرویس 💊", $"vpn_template" +
                                                                            $"?id={status.VpnId}&" +
                                                                            $"subscribeId={status.MarzbanUserId}"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("خرید حجم اضافه ➕",
                        $"custom_subscribe?vpnId={status.VpnId}&appendGb=true"),
                    InlineKeyboardButton.WithCallbackData("خرید زمان اضافه ⌛️",
                        $"append_date?vpnId={status.VpnId}&subscribeId={status.MarzbanUserId}"),
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

            if (message.MessageId != 0)
            {
                await botClient!.DeleteMessageAsync(chatId, message.MessageId, cancellationToken);
            }
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task DeletedMarzbanUserServiceByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        try
        {
            long Id = 0;
            string callbackData = callbackQuery.Data;
            int questionMarkIndex = callbackData.IndexOf('?');
            if (questionMarkIndex >= 0)
            {
                string? query = callbackData?.Substring(questionMarkIndex);
                NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
                Int64.TryParse(queryParameters["id"], out Id);
            }

            await telegramService.MainDeleteMarzbanUserAsync(Id, chatId);

            if (callbackQuery.Message.MessageId != 0)
            {
                await botClient!.EditMessageTextAsync(chatId, callbackQuery.Message.MessageId,
                    "سرویس با موفقیت حدف شد",
                    cancellationToken: cancellationToken);
            }
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task NotDeleteMarzbanUserServiceByAgentAsync(ITelegramBotClient? botClient,
        CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        long chatId = callbackQuery.Message!.Chat.Id;

        try
        {
            long Id = 0;
            string callbackData = callbackQuery.Data;
            int questionMarkIndex = callbackData.IndexOf('?');
            if (questionMarkIndex >= 0)
            {
                string? query = callbackData?.Substring(questionMarkIndex);
                NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);
                Int64.TryParse(queryParameters["id"], out Id);
            }

            await telegramService.MainNotDeleteMarzbanUserAsync(Id, chatId);

            if (callbackQuery.Message.MessageId != 0)
            {
                await botClient!.EditMessageTextAsync(chatId, callbackQuery.Message.MessageId,
                    "عملیات با موفقیت انجام شد",
                    cancellationToken: cancellationToken);
            }
        }
        catch (Exception e)
        {
            await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task<Message> SendBotManagementBotAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken,
        TelegramMarzbanVpnSession? value)
    {
        long chatId = message!.Chat.Id;

        try
        {
            User? user = await telegramService.GetUserByChatIdAsync(chatId);

            var keyboard = new ReplyKeyboardMarkup(new[]
            {
                new KeyboardButton[] { "آمار ربات \u2699\ufe0f", "غیر فعال سازی ربات \u274c" },
                new KeyboardButton[] { "ارسال پیام داخلی \u2709\ufe0f" },
                new KeyboardButton[] { "\ud83c\udfe0 بازگشت به منو اصلی" },
            })
            {
                ResizeKeyboard = true // تنظیم اندازه کیبورد
            };

            return await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "لطفاً یک گزینه را انتخاب کنید:",
                replyMarkup: keyboard,
                cancellationToken: cancellationToken
            );
        }
        catch (Exception e)
        {
            return await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public async Task<Message> MenuForSendMessageForBotAsync(ITelegramBotClient? botClient, Message message, CancellationToken cancellationToken,
        TelegramMarzbanVpnSession? value)
    {
        long chatId = message!.Chat.Id;

        try
        {
            User? user = await telegramService.GetUserByChatIdAsync(chatId);

            if (!user.IsSupperAdmin)
                return new Message();
            
            var keyboard = new ReplyKeyboardMarkup(new[]
            {
                new KeyboardButton[] { "ارسال پیام برای نمایندگان \ud83d\udc64" ,"ارسال پیام برای کاربران \ud83d\udcac"},
                new KeyboardButton[]{"ارسال پیام کلی"},
                new KeyboardButton[] { "فروارد پیام برای نمایندگان \ud83d\udc64" ,"فروارد پیام برای کاربران \ud83d\udcac"},
                new KeyboardButton[] { "\ud83c\udfe0 بازگشت به منو اصلی" },
            })
            {
                ResizeKeyboard = true // تنظیم اندازه کیبورد
            };

            return await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "لطفاً یک گزینه را انتخاب کنید:",
                replyMarkup: keyboard,
                cancellationToken: cancellationToken
            );
        }
        catch (Exception e)
        {
            return await botClient!.SendTextMessageAsync(
                chatId: chatId,
                text: e.Message,
                cancellationToken: cancellationToken);
        }
    }

    public Task<Message> SendListTelegramButtons(ITelegramBotClient? botClient, Message message, CancellationToken cancellationToken,
        TelegramMarzbanVpnSession? value)
    {
        throw new NotImplementedException();
    }


    private async Task DeleteMenu(ITelegramBotClient? botClient, long chatId,
        CancellationToken cancellationToken)
    {
        try
        {
            User? user = await telegramService.GetUserByChatIdAsync(chatId);
            if (user?.MessageId != null && user.MessageId != 0)
                await botClient!.DeleteMessageAsync(
                    chatId: chatId,
                    messageId: user.MessageId ?? 0,
                    cancellationToken: cancellationToken
                );
        }
        catch
        {
            return;
        }
    }
}