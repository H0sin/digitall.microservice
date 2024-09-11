using Application.Factory;
using Application.Services.Interface.Notification;
using Application.Services.Interface.Telegram;
using Domain.DTOs.Notification;
using Domain.DTOs.Telegram;
using Domain.Entities.Telegram;
using Domain.Enums.Notification;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Serilog;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Application.Jobs;

public class SendTelegramNotificationJob : IJob
{
    private readonly IServiceScopeFactory _serviceScopeFactory;
    private readonly IMemoryCache _memoryCache;
    private readonly TelegramBotClientFactory _botClientFactory;

    public SendTelegramNotificationJob(IServiceScopeFactory serviceScopeFactory, IMemoryCache memoryCache,
        TelegramBotClientFactory botClientFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
        _memoryCache = memoryCache;
        _botClientFactory = botClientFactory;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        try
        {
            await using var scope = _serviceScopeFactory.CreateAsyncScope();

            var telegramService = scope.ServiceProvider.GetRequiredService<ITelegramService>();
            var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));

            List<NotificationDto> notifications =
                await notificationService
                    .GetNotificationsAsync();

            foreach (NotificationDto notification in notifications)
            {
                try
                {
                    await Task.Delay(TimeSpan.FromSeconds(.5));

                    if (notification.ChatId is not null && notification.BotId is not null)
                    {
                        TelegramBotDto? bot =
                            await telegramService.GetTelegramBotByBotIdAsync(notification.BotId ?? 0);

                        ITelegramBotClient botClient = _botClientFactory.GetOrAdd(bot.Token);

                        if (bot.Token != null)
                        {
                            if (notification.Forward)
                            {
                                await botClient.ForwardMessageAsync(
                                    chatId: notification.ChatId,
                                    fromChatId: notification.ForwardChatId ?? 0,
                                    messageId: notification.MessageId ?? 0,
                                    cancellationToken: default
                                );

                                await notificationService.UpdateSendNotification(notification.Id);
                            }
                            else
                            {
                                IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();
                                if (notification.Buttons is not null)
                                {
                                    for (int i = 0; i < notification.Buttons.Count; i++)
                                    {
                                        ButtonJsonDto? button_1 = notification.Buttons[i]!;
                                        ButtonJsonDto? button_2 =
                                            (i + 1 < notification.Buttons.Count) ? notification.Buttons[i + 1]! : null;

                                        if (button_1 is not null)
                                        {
                                            List<InlineKeyboardButton> key = new()
                                            {
                                                InlineKeyboardButton.WithCallbackData(button_1.Text,
                                                    button_1.CallbackQuery),
                                            };

                                            if (button_2 is not null)
                                                key.Add(
                                                    InlineKeyboardButton.WithCallbackData(button_2.Text,
                                                        button_2.CallbackQuery));

                                            keys.Add(key);
                                        }

                                        i++;
                                    }
                                }

                                if (!string.IsNullOrEmpty(notification.FileAddress))
                                {
                                    using (var stream = new FileStream(notification.FileAddress, FileMode.Open,
                                               FileAccess.Read,
                                               FileShare.Read))
                                    {
                                        var inputOnlineFile =
                                            new InputFileStream(stream, Path.GetFileName(notification.FileAddress));


                                        await botClient!.SendPhotoAsync(
                                            chatId: notification.ChatId,
                                            photo: inputOnlineFile,
                                            caption: notification.FileCaption,
                                            cancellationToken: default
                                        );
                                    }
                                }

                                string? text = notification?.Message!
                                    .Replace("_", "\\_")
                                    .Replace("*", "\\*")
                                    .Replace("[", "\\[")
                                    .Replace("]", "\\]")
                                    .Replace("(", "\\(")
                                    .Replace(")", "\\)")
                                    .Replace("~", "\\~")
                                    .Replace(">", "\\>")
                                    .Replace("#", "\\#")
                                    .Replace("+", "\\+")
                                    .Replace("-", "\\-")
                                    .Replace("=", "\\=")
                                    .Replace("|", "\\|")
                                    .Replace("{", "\\{")
                                    .Replace("}", "\\}")
                                    .Replace(".", "\\.")
                                    .Replace("!", "\\!");

                                if (notification?.NotificationType != NotificationType.BogsReports)
                                {
                                    await botClient!.SendTextMessageAsync(
                                        chatId: notification!.ChatId,
                                        text: text ?? "بدون پیام",
                                        replyMarkup: new InlineKeyboardMarkup(keys),
                                        cancellationToken: default,
                                        parseMode: ParseMode.MarkdownV2
                                    );
                                }

                                await notificationService.UpdateSendNotification(notification.Id);

                                TelegramBot? telegramBot = _botClientFactory.Get(7419690675);

                                if (telegramBot is not null)
                                {
                                    User botInfo = await botClient.GetMeAsync();

                                    ITelegramBotClient TBotClient = _botClientFactory.GetOrAdd(telegramBot.Token);
                                    TelegramGroup? telegramGroup = telegramBot.TelegramGroup;
                                    List<TelegramTopic> topics = telegramBot.TelegramGroup.TelegramGroupTopics
                                        .Select(x => x.TelegramTopic).ToList();

                                    switch (notification.NotificationType.ToString())
                                    {
                                        case "BuyReports":
                                            TelegramTopic? buy_topic = topics.SingleOrDefault(x =>
                                                x.TelegramTopicCategory == "BuyReports");
                                            if (buy_topic != null)
                                            {
                                                int? messageThreadId =
                                                    telegramBot.TelegramGroup.TelegramGroupTopics.SingleOrDefault(x =>
                                                        x.TelegramTopicId == buy_topic.Id)?.MessageThreadId;

                                                await TBotClient.SendTextMessageAsync(
                                                    chatId: telegramGroup!.ChatId,
                                                    text: $"""
                                                           نام ربات : {botInfo.Username.Replace("_", "\\_")}
                                                           {text}
                                                           """,
                                                    messageThreadId: messageThreadId,
                                                    parseMode: ParseMode.MarkdownV2,
                                                    cancellationToken: default
                                                );
                                            }

                                            break;
                                        case "StartReports":
                                            TelegramTopic? start_topic = topics.SingleOrDefault(x =>
                                                x.TelegramTopicCategory == "StartReports");
                                            if (start_topic != null)
                                            {
                                                int? messageThreadId =
                                                    telegramBot.TelegramGroup.TelegramGroupTopics.SingleOrDefault(x =>
                                                        x.TelegramTopicId == start_topic.Id)?.MessageThreadId;

                                                await TBotClient.SendTextMessageAsync(
                                                    chatId: telegramGroup!.ChatId,
                                                    text: $"""
                                                           نام ربات : {botInfo.Username.Replace("_", "\\_")}
                                                           {text}
                                                           """,
                                                    messageThreadId: messageThreadId,
                                                    parseMode: ParseMode.MarkdownV2,
                                                    cancellationToken: default
                                                );
                                            }

                                            break;
                                        case "FinancialReports":
                                            TelegramTopic? financial_topic = topics.SingleOrDefault(x =>
                                                x.TelegramTopicCategory == "FinancialReports");
                                            if (financial_topic != null)
                                            {
                                                int? messageThreadId =
                                                    telegramBot.TelegramGroup.TelegramGroupTopics.SingleOrDefault(x =>
                                                        x.TelegramTopicId == financial_topic.Id)?.MessageThreadId;

                                                await TBotClient.SendTextMessageAsync(
                                                    chatId: telegramGroup!.ChatId,
                                                    text: $"""
                                                           نام ربات : {botInfo.Username?.Replace("_", "\\_")}
                                                           {text}
                                                           """,
                                                    messageThreadId: messageThreadId,
                                                    parseMode: ParseMode.MarkdownV2,
                                                    cancellationToken: default
                                                );
                                            }

                                            break;
                                        case "RenewReports":
                                            TelegramTopic? renew_topic = topics.SingleOrDefault(x =>
                                                x.TelegramTopicCategory == "RenewReports");
                                            if (renew_topic != null)
                                            {
                                                int? messageThreadId =
                                                    telegramBot.TelegramGroup.TelegramGroupTopics.SingleOrDefault(x =>
                                                        x.TelegramTopicId == renew_topic.Id)?.MessageThreadId;

                                                await TBotClient.SendTextMessageAsync(
                                                    chatId: telegramGroup!.ChatId,
                                                    text: $"""
                                                           نام ربات : {botInfo.Username?.Replace("_", "\\_")}
                                                           {text}
                                                           """,
                                                    messageThreadId: messageThreadId,
                                                    parseMode: ParseMode.MarkdownV2,
                                                    cancellationToken: default
                                                );
                                            }

                                            break;

                                        case "BogsReports":
                                            TelegramTopic? bogs_topic = topics.SingleOrDefault(x =>
                                                x.TelegramTopicCategory == "BogsReports");
                                            if (bogs_topic != null)
                                            {
                                                int? messageThreadId =
                                                    telegramBot.TelegramGroup.TelegramGroupTopics.SingleOrDefault(x =>
                                                        x.TelegramTopicId == bogs_topic.Id)?.MessageThreadId;

                                                await TBotClient.SendTextMessageAsync(
                                                    chatId: telegramGroup!.ChatId,
                                                    text: $"""
                                                           نام ربات : {botInfo.Username?.Replace("_", "\\_")}
                                                           {text}
                                                           """,
                                                    messageThreadId: messageThreadId,
                                                    parseMode: ParseMode.MarkdownV2,
                                                    cancellationToken: default
                                                );
                                            }

                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    await notificationService.UpdateNotificationExeption(notification.Id,
                        e.Message + " -- | -- " + e.InnerException);
                }

                cts.Token.ThrowIfCancellationRequested();
            }
        }
        catch (Exception e)
        {
            Log.Error("Created {@Obj} on {@Created}", e.Message, DateTime.Now);
        }
    }
}