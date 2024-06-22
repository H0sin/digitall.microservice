// namespace Telegram.Data;
//
// public class MenusData
// {
//     using System;
// using System.Threading;
// using System.Threading.Tasks;
// using Telegram.Bot;
// using Telegram.Bot.Exceptions;
// using Telegram.Bot.Extensions.Polling;
// using Telegram.Bot.Types;
// using Telegram.Bot.Types.Enums;
// using Telegram.Bot.Types.ReplyMarkups;
//
// class Program
// {
//     private static readonly TelegramBotClient BotClient = new TelegramBotClient("YOUR_BOT_TOKEN");
//
//     static async Task Main(string[] args)
//     {
//         var cts = new CancellationTokenSource();
//         var cancellationToken = cts.Token;
//         var receiverOptions = new ReceiverOptions
//         {
//             AllowedUpdates = { } // دریافت همه نوع پیام‌ها
//         };
//
//         BotClient.StartReceiving(
//             HandleUpdateAsync,
//             HandleErrorAsync,
//             receiverOptions,
//             cancellationToken
//         );
//
//         Console.WriteLine("Bot is up and running.");
//         Console.ReadLine();
//         cts.Cancel();
//     }
//
//     private static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
//     {
//         if (update.Type == UpdateType.Message && update.Message.Text != null)
//         {
//             var message = update.Message;
//
//             if (message.Text == "/start")
//             {
//                 var mainMenu = new InlineKeyboardMarkup(new[]
//                 {
//                     new [] 
//                     {
//                         InlineKeyboardButton.WithCallbackData("🛒 خرید اشتراک", "buy_subscription"),
//                         InlineKeyboardButton.WithCallbackData("😎 تست رایگان", "free_test")
//                     },
//                     new [] 
//                     {
//                         InlineKeyboardButton.WithCallbackData("🎁 سرویس های من", "my_services"),
//                     },
//                     new []
//                     {
//                         InlineKeyboardButton.WithCallbackData("🏦 کیف پول + شارژ", "wallet"),
//                         InlineKeyboardButton.WithCallbackData("💰 همکاری در فروش", "collaboration")
//                     },
//                     new []
//                     {
//                         InlineKeyboardButton.WithCallbackData("☎️ پشتیبانی", "support"),
//                         InlineKeyboardButton.WithCallbackData("📚 آموزش", "education")
//                     },
//                     new []
//                     {
//                         InlineKeyboardButton.WithCallbackData("👨‍💼 پنل مدیریت", "admin_panel"),
//                         InlineKeyboardButton.WithCallbackData("🔐 پنل نمایندگی", "agency_panel")
//                     }
//                 });
//
//                 await botClient.SendTextMessageAsync(
//                     chatId: message.Chat.Id,
//                     text: "به صفحه اصلی بازگشتید!",
//                     replyMarkup: mainMenu,
//                     cancellationToken: cancellationToken
//                 );
//             }
//         }
//         else if (update.Type == UpdateType.CallbackQuery)
//         {
//             var callbackQuery = update.CallbackQuery;
//             InlineKeyboardMarkup inlineKeyboard = null;
//             string messageText = "";
//
//             switch (callbackQuery.Data)
//             {
//                 case "buy_subscription":
//                     inlineKeyboard = new InlineKeyboardMarkup(new[]
//                     {
//                         new []
//                         {
//                             InlineKeyboardButton.WithCallbackData("🇩🇪🇺🇸🇹🇷 سرویس ویژه آلمان آمریکا ترکیه", "premium_service"),
//                         },
//                         new []
//                         {
//                             InlineKeyboardButton.WithCallbackData("🇩🇪🇳🇱🇫🇷🇹🇷 سرویس اقتصادی آلمان هلند فرانسه ترکیه", "economic_service"),
//                         },
//                         new []
//                         {
//                             InlineKeyboardButton.WithCallbackData("🏠 بازگشت به منوی اصلی", "mainmenu")
//                         }
//                     });
//                     messageText = "موقعیت سرویس را انتخاب نمایید. 📌";
//                     break;
//
//                 case "mainmenu":
//                     inlineKeyboard = new InlineKeyboardMarkup(new[]
//                     {
//                         new [] 
//                         {
//                             InlineKeyboardButton.WithCallbackData("🛒 خرید اشتراک", "buy_subscription"),
//                             InlineKeyboardButton.WithCallbackData("😎 تست رایگان", "free_test")
//                         },
//                         new [] 
//                         {
//                             InlineKeyboardButton.WithCallbackData("🎁 سرویس های من", "my_services"),
//                         },
//                         new []
//                         {
//                             InlineKeyboardButton.WithCallbackData("🏦 کیف پول + شارژ", "wallet"),
//                             InlineKeyboardButton.WithCallbackData("💰 همکاری در فروش", "collaboration")
//                         },
//                         new []
//                         {
//                             InlineKeyboardButton.WithCallbackData("☎️ پشتیبانی", "support"),
//                             InlineKeyboardButton.WithCallbackData("📚 آموزش", "education")
//                         },
//                         new []
//                         {
//                             InlineKeyboardButton.WithCallbackData("👨‍💼 پنل مدیریت", "admin_panel"),
//                             InlineKeyboardButton.WithCallbackData("🔐 پنل نمایندگی", "agency_panel")
//                         }
//                     });
//                     messageText = "به صفحه اصلی بازگشتید!";
//                     break;
//
//                 default:
//                     messageText = $"Received parameter: {callbackQuery.Data}";
//                     break;
//             }
//
//             await botClient.EditMessageTextAsync(
//                 chatId: callbackQuery.Message.Chat.Id,
//                 messageId: callbackQuery.Message.MessageId,
//                 text: messageText,
//                 replyMarkup: inlineKeyboard,
//                 cancellationToken: cancellationToken
//             );
//         }
//     }
//
//     private static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
//     {
//         var errorMessage = exception switch
//         {
//             ApiRequestException apiRequestException
//                 => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
//             _ => exception.ToString()
//         };
//
//         Console.WriteLine(errorMessage);
//         return Task.CompletedTask;
//     }
// }
//
// }