using Domain.DTOs.Notification;

namespace Application.Services.Interface.Notification;

public interface INotificationService
{
    Task AddNotificationAsync(AddNotificationDto notification,long userId);
    Task DeleteExpireNotificationAsync();
}