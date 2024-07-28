using Application.Services.Interface.Notification;
using Domain.DTOs.Notification;
using Domain.Enums.Notification;
using Domain.IRepositories.Notification;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation.Notification;

public class NotificationService(INotificationRepository notificationRepository) : INotificationService
{
    public async Task AddNotificationAsync(AddNotificationDto notification, long userId)
    {
        Domain.Entities.Notification.Notification notif = new()
        {
            Expire = notification.Expire,
            UserId = notification.UserId,
            ForAllMember = notification.ForAllMember,
            Message = notification.Message,
            NotificationType = notification.NotificationType
        };

        await notificationRepository.AddEntity(notif);
        await notificationRepository.SaveChanges(userId);
    }

    public async Task<List<NotificationDto>> GetNotificationsAsync(long userId)
    {
        List<NotificationDto> notifications = await notificationRepository
            .GetQuery()
            .Where(x => x.UserId == userId | x.ForAllMember == true)
            .Select(x => new NotificationDto(x))
            .ToListAsync();

        return notifications;
    }

    public async Task DeleteExpireNotificationAsync()
    {
        DateTime now = DateTime.UtcNow;

        List<Domain.Entities.Notification.Notification> notifications =
            await notificationRepository
                .GetQuery().Where(n => n.Expire < now)
                .ToListAsync();

        await notificationRepository.Deletes(notifications);
    }
}