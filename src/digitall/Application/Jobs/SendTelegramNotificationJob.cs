using Application.Services.Interface.Notification;
using Application.Services.Interface.Telegram;
using Domain.DTOs.Notification;
using Domain.DTOs.Telegram;
using Domain.Entities.Telegram;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Application.Jobs;

public class SendTelegramNotificationJob : IJob
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public SendTelegramNotificationJob(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        await using var scope = _serviceScopeFactory.CreateAsyncScope();

        var telegramService = scope.ServiceProvider.GetRequiredService<ITelegramService>();
        var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

        List<NotificationDto> notifications = await notificationService.GetNotificationsAsync();

        foreach (var notification in notifications)
        {
            if (notification.ChatId is not null && notification.BotId is not null)
            {
                TelegramBotDto? bot = await telegramService.GetTelegramBotByBotIdAsync(notification.BotId ?? 0);
                var botClient = new TelegramBotClient(bot.Token!);

                IList<List<InlineKeyboardButton>> keys = new List<List<InlineKeyboardButton>>();

                for (int i = 0; notification.Buttons!.Count > i; i++)
                {
                    ButtonJsonDto? button_1 = notification.Buttons[i]!;
                    ButtonJsonDto? button_2 = notification.Buttons[i + 1]!;
                    
                    if (button_1 is not null)
                    {
                        List<InlineKeyboardButton> key = new()
                        {
                            InlineKeyboardButton.WithCallbackData(button_1.Text, button_1.CallbackQuery),
                        };
                        
                        if(button_2 is not null)
                            key.Add(InlineKeyboardButton.WithCallbackData(button_2.Text, button_2.CallbackQuery));
                        keys.Add(key);
                    }
                    
                    i++;
                }

                await botClient.SendTextMessageAsync(
                    chatId: notification.ChatId,
                    text: notification.Message ?? "",
                    replyMarkup: new InlineKeyboardMarkup(keys),
                    parseMode: ParseMode.Markdown
                );

                await notificationService.UpdateSendNotification(notification.Id);

                Thread.Sleep(500);
            }
        }
    }
}