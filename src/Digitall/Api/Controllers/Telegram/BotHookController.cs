using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Application.Extensions;
using Application.Helper;
using Application.Services.Interface.Telegram;
using Asp.Versioning;
using Domain.DTOs.Telegram;
using Domain.Entities.Telegram;
using Microsoft.AspNetCore.Authorization;
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
        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("سرویس ویژه آلمان 🇩🇪 آمریکا 🇺🇸 ترکیه 🇹🇷", "special_service")
            },
            new []
            {
                InlineKeyboardButton.WithCallbackData("سرویس اقتصادی آلمان 🇩🇪 هلند 🇳🇱 فرانسه 🇫🇷 ترکیه 🇹🇷", "economic_service")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("بازگشت به منوی اصلی 🏠", "back_to_main")
            }
        });

        await _botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "منوی خرید اشتراک را انتخاب کنید 📌",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken);

        // حذف منوی قبلی اگر شماره پیام ارسالی موجود باشد
        if (messageId != 0)
        {
            await _botClient.DeleteMessageAsync(chatId, messageId, cancellationToken);
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
            "/inline_keyboard" => SendInlineKeyboard(_botClient, message, cancellationToken),
            _ => Usage(_botClient, message, cancellationToken)
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

        static async Task<Message> SendReplyKeyboard(ITelegramBotClient botClient, Message message,
            CancellationToken cancellationToken)
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(
                new[]
                {
                    new KeyboardButton[] { "1.1", "1.2" },
                    new KeyboardButton[] { "2.1", "2.2" },
                })
            {
                ResizeKeyboard = true
            };

            return await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Choose",
                replyMarkup: replyKeyboardMarkup,
                cancellationToken: cancellationToken);
        }

        static async Task<Message> RemoveKeyboard(ITelegramBotClient botClient, Message message,
            CancellationToken cancellationToken)
        {
            return await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Removing keyboard",
                replyMarkup: new ReplyKeyboardRemove(),
                cancellationToken: cancellationToken);
        }

        static async Task<Message> SendFile(ITelegramBotClient botClient, Message message,
            CancellationToken cancellationToken)
        {
            await botClient.SendChatActionAsync(
                message.Chat.Id,
                ChatAction.UploadPhoto,
                cancellationToken: cancellationToken);

            const string filePath = "Files/tux.png";
            await using FileStream fileStream = new(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            var fileName = filePath.Split(Path.DirectorySeparatorChar).Last();

            return await botClient.SendPhotoAsync(
                chatId: message.Chat.Id,
                photo: new InputFileStream(fileStream, fileName),
                caption: "Nice Picture",
                cancellationToken: cancellationToken);
        }

        static async Task<Message> RequestContactAndLocation(ITelegramBotClient botClient, Message message,
            CancellationToken cancellationToken)
        {
            ReplyKeyboardMarkup RequestReplyKeyboard = new(
                new[]
                {
                    KeyboardButton.WithRequestLocation("Location"),
                    KeyboardButton.WithRequestContact("Contact"),
                });

            return await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Who or Where are you?",
                replyMarkup: RequestReplyKeyboard,
                cancellationToken: cancellationToken);
        }

        static async Task<Message> Usage(ITelegramBotClient botClient, Message message,
            CancellationToken cancellationToken)
        {
            const string usage = "Usage:\n" +
                                 "/inline_keyboard - send inline keyboard\n" +
                                 "/keyboard    - send custom keyboard\n" +
                                 "/remove      - remove custom keyboard\n" +
                                 "/photo       - send a photo\n" +
                                 "/request     - request location or contact\n" +
                                 "/inline_mode - send keyboard with Inline Query";

            return await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: usage,
                replyMarkup: new ReplyKeyboardRemove(),
                cancellationToken: cancellationToken);
        }

        static async Task<Message> StartInlineQuery(ITelegramBotClient botClient, Message message,
            CancellationToken cancellationToken)
        {
            InlineKeyboardMarkup inlineKeyboard = new(
                InlineKeyboardButton.WithSwitchInlineQueryCurrentChat("Inline Mode"));

            return await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Press the button to start Inline Query",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
    }

    private async Task BotOnCallbackQueryReceived(CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        switch (callbackQuery.Data)
        {
            case "subscribe":
                await SendSubscriptionMenu(callbackQuery.Message.Chat.Id, callbackQuery.Message.MessageId, cancellationToken);
                break;
            case "back_to_main":
                await SendMainMenu(callbackQuery.Message.Chat.Id, callbackQuery.Message.MessageId, cancellationToken);
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