using Application.Helper;
using Application.Services.Interface.Telegram;
using Domain.DTOs.Marzban;
using Domain.DTOs.Telegram;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Api.Controllers.Telegram;

public class BotHookController(
    IServiceProvider serviceProvider,
    ITelegramService telegramService
) : ControllerBase
{
    private ITelegramBotClient? _botClient;


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
        //
        // if (messageId.HasValue)
        // {
        //     await botClient.EditMessageTextAsync(chatId, messageId.Value, "به صفحه اصلی بازگشتید!", replyMarkup: inlineKeyboard);
        // }
        // else
        // {
        //     await botClient.SendTextMessageAsync(chatId, "به صفحه اصلی بازگشتید!", replyMarkup: inlineKeyboard);
        // }

        return await botClient.SendTextMessageAsync(
            chatId: message.Chat.Id,
            text: "Choose",
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
            await _botClient.DeleteMessageAsync(chatId, messageId, cancellationToken);
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

        List<MarzbanVpnTemplateDto> templates = await telegramService.GetMarzbanVpnTemplatesByVpnIdAsync(id);

        foreach (MarzbanVpnTemplateDto template in templates)
        {
            List<InlineKeyboardButton> button = new()
            {
                InlineKeyboardButton.WithCallbackData(template!.Title!, "createsub?id=" + template.Id)
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

        keys.Add(home);
        keys.Add(custom);

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

    private async Task CreateAndSendTestConfig(long chatId, int messageId, CancellationToken cancellationToken)
    {
        GenerateQrCode.GetQrCodeAsync("");
    }

    private async Task BotOnMessageReceived(Message message,
        CancellationToken cancellationToken)
    {
        if (message.Text is not { } messageText)
            return;

        var action = messageText.Split(' ')[0] switch
        {
            "/start" => SendStartedMessage(_botClient, message, cancellationToken),
            "/inline_keyboard" => SendInlineKeyboard(_botClient, message, cancellationToken)
            // _ => Usage(_botClient, message, cancellationToken)
        };
        Message sentMessage = await action;

        //------------------------------ S T A R T ---------------------------------------

        static async Task<Message> SendInlineKeyboard(ITelegramBotClient botClient, Message message,
            CancellationToken cancellationToken)
        {
            await botClient.SendChatActionAsync(
                chatId: message.Chat.Id,
                chatAction: ChatAction.Typing,
                cancellationToken: cancellationToken);

            // Simulate longer running task
            await Task.Delay(500, cancellationToken);

            InlineKeyboardMarkup inlineKeyboard = new(
                new[]
                {
                    // first row
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("1.1", "11"),
                        InlineKeyboardButton.WithCallbackData("1.2", "12"),
                    },
                    // second row
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("2.1", "21"),
                        InlineKeyboardButton.WithCallbackData("2.2", "22"),
                    },
                });

            return await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Choose",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
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

        // await _botClient.SendTextMessageAsync(
        //     chatId: callbackQuery.Id,
        //     text: "Choose",
        //     replyMarkup: replyKeyboardMarkup,
        //     cancellationToken: cancellationToken);

        // await _botClient.SendTextMessageAsync(
        //     chatId: callbackQuery.Message!.Chat.Id,
        //     text: $"Received {callbackQuery.Data}",
        //     cancellationToken: cancellationToken);
    }
}