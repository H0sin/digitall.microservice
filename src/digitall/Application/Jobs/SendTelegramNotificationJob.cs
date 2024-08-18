using Application.Services.Interface.Notification;
using Application.Services.Interface.Telegram;
using Domain.DTOs.Notification;
using Domain.DTOs.Telegram;
using Domain.Entities.Telegram;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

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
        using (var scope = _serviceScopeFactory.CreateScope())
        {
            var telegramService = scope.ServiceProvider.GetRequiredService<ITelegramService>();
            var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

            List<NotificationDto> notifications = await notificationService.GetNotificationsAsync();

            foreach (var notification in notifications)
            {
                if (notification.ChatId is not null && notification.BotId is not null)
                {
                    TelegramBotDto? bot = await telegramService.GetTelegramBotByBotIdAsync(notification.BotId ?? 0);
                    var botClient = new TelegramBotClient(bot.Token!);

                    await botClient.SendTextMessageAsync(
                        chatId: notification.ChatId,
                        text: notification.Message,
                        parseMode: ParseMode.Markdown
                    );

                    await notificationService.UpdateSendNotification(notification.Id);

                    Thread.Sleep(500);
                }
            }
        }
    }
}