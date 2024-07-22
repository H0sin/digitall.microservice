using Domain.DTOs.Notification;

namespace Application.Services.Interface.Notification;

public interface INotificationService
{
    /// <summary>
    /// add notification admin aded notification
    /// </summary>
    /// <param name="notification"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task AddNotificationAsync(AddNotificationDto notification,long userId);
    
    /// <summary>
    /// for get list notifications and show user
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<List<NotificationDto>> GetNotificationsAsync(long userId);
    
    /// <summary>
    /// service for job delete expire notifications
    /// </summary>
    /// <returns></returns>
    Task DeleteExpireNotificationAsync();
}