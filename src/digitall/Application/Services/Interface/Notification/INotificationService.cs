using Domain.DTOs.Notification;

namespace Application.Services.Interface.Notification;

public interface INotificationService
{

    /// <summary>
    /// added notification for role memebers
    /// </summary>
    /// <param name="notification"></param>
    /// <param name="roleName"></param>
    /// <returns></returns>
    Task AddNotificationForRole(AddNotificationDto notification,string roleName);
    
    /// <summary>
    /// added notification for role members
    /// </summary>
    /// <param name="notification"></param>
    /// <param name="roleId"></param>
    /// <returns></returns>
    Task AddNotificationForRole(AddNotificationDto notification,long roleId);
    
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
    /// update notification exeption
    /// </summary>
    /// <param name="notificationId"></param>
    /// <param name="ex"></param>
    /// <returns></returns>
    Task UpdateNotificationExeption(long notificationId,string ex);
    
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
    /// send notification for telegram
    /// </summary>
    /// <returns></returns>
    IQueryable<NotificationDto> GetQueryableNotifications();

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