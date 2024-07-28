using Domain.Common;

namespace Application.Services.Interface.Notification;

public interface ISendNotificationService<T> where T : BaseNotification
{
    Task<bool> SendNotificationAsync(T notification);
}