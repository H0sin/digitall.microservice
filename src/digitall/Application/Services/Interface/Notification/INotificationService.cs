using Domain.DTOs.Notification;

namespace Application.Services.Interface.Notification;

public interface INotificationService
{
    /// <summary>
    /// add notification admin added notification
    /// </summary>
    /// <param name="notification"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task AddNotificationAsync(AddNotificationDto notification,long userId);
    
    /// <summary>
    /// add notifications
    /// </summary>
    /// <param name="notifications"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task AddNotificationsAsync(List<AddNotificationDto> notifications,long userId);
    
    /// <summary>
    /// for get list notifications and show user
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<List<NotificationDto>> GetNotificationsAsync(long userId);

    /// <summary>
    /// send notification for telegram
    /// </summary>
    /// <returns></returns>
    Task<List<NotificationDto>> GetNotificationsAsync();

    /// <summary>
    /// after send notification update filed is send
    /// </summary>
    /// <param name="notificationId"></param>
    /// <returns></returns>
    Task UpdateSendNotification(long notificationId);
    
    /// <summary>
    /// service for job delete expire notifications
    /// </summary>
    /// <returns></returns>
    Task DeleteExpireNotificationAsync();
}