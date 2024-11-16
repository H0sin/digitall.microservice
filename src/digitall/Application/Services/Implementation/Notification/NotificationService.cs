using Application.Services.Interface.Authorization;
using Application.Services.Interface.Notification;
using Data.Repositories.Account;
using Domain.DTOs.Notification;
using Domain.Entities.Account;
using Domain.Enums.Notification;
using Domain.IRepositories.Notification;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation.Notification;

public class NotificationService(INotificationRepository notificationRepository,IAuthorizeService authorizeService) : INotificationService
{
    public async Task AddNotificationForRole(AddNotificationDto notification, string roleName)
    {
        List<User> users = await authorizeService.GetUsersByRoleNameAsync(roleName);

        foreach (var user in users)
        {
            notification.UserId = user.Id;
            await AddNotificationAsync(notification,user.Id);
        }
    }

    public Task AddNotificationForRole(AddNotificationDto notification, long roleId)
    {
        throw new NotImplementedException();
    }

    public async Task AddNotificationAsync(AddNotificationDto notification, long userId)
    {
        Domain.Entities.Notification.Notification notify = new()
        {
            Expire = notification.Expire,
            UserId = notification.UserId,
            ForAllMember = notification.ForAllMember,
            Message = notification.Message,
            NotificationType = notification.NotificationType,
            Buttons = notification.Buttons,
            FileAddress = notification.FileAddress,
            FileCaption = notification.FileCaption,
            Forward = notification.Forward,
            ForwarderChatId = notification.ForwardChatId,
            MessageId = notification.MessageId
        };

        await notificationRepository.AddEntity(notify);
        await notificationRepository.SaveChanges(userId);
    }

    public async Task AddNotificationsAsync(List<AddNotificationDto> notifications, long userId)
    {
        List<Domain.Entities.Notification.Notification> notifies = notifications.Select(x =>
            new Domain.Entities.Notification.Notification()
            {
                Expire = x.Expire,
                UserId = x.UserId,
                ForAllMember = x.ForAllMember,
                Message = x.Message,
                NotificationType = x.NotificationType,
                Buttons = x.Buttons,
                FileAddress = x.FileAddress,
                FileCaption = x.FileCaption,
                Forward = x.Forward,
                ForwarderChatId = x.ForwardChatId,
                MessageId = x.MessageId
            }).ToList();
        
        await notificationRepository.AddEntities(notifies);
        await notificationRepository.SaveChanges(userId);
    }

    public async Task UpdateNotificationExeption(long notificationId, string ex)
    {
        Domain.Entities.Notification.Notification? notification =
            await notificationRepository.GetEntityById(notificationId);

        if (notification is not null)
        {
            notification.Execption = ex;
            await notificationRepository.UpdateEntity(notification);
        }

        await notificationRepository.SaveChanges(1);
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

    public async Task<List<NotificationDto>> GetNotificationsAsync()
    {
        List<NotificationDto> notifications = await notificationRepository
            .GetQuery()
            .Where(x => x.Send == false & string.IsNullOrEmpty(x.Execption))
            .Include(x => x.User)
            .Take(5)
            .Select(x => new NotificationDto(x))
            .ToListAsync();

        return notifications;
    }

    public IQueryable<NotificationDto> GetQueryableNotifications()
    {
        return notificationRepository
            .GetQuery()
            .Where(x => x.Send == false)
            .Include(x => x.User)
            .Select(x => new NotificationDto(x));
    }

    public async Task UpdateSendNotification(long notificationId)
    {
        Domain.Entities.Notification.Notification? notification =
            await notificationRepository.GetEntityById(notificationId);

        if (notification is not null)
        {
            notification.Send = true;
            await notificationRepository.UpdateEntity(notification);
        }

        await notificationRepository.SaveChanges(1);
    }

    public async Task DeleteExpireNotificationAsync()
    {
        DateTime now = DateTime.UtcNow;

        List<Domain.Entities.Notification.Notification> notifications =
            await notificationRepository
                .GetQuery().Where(n => n.Expire < now)
                .ToListAsync();

        await notificationRepository.Deletes(notifications);
        await notificationRepository.SaveChanges(1);
    }
}