using System.ComponentModel.DataAnnotations;
using Domain.Entities.Account;
using Domain.Enums.Notification;

namespace Domain.DTOs.Notification;

public class NotificationDto
{
    public DateTime Expire { get; set; }
    public NotificationType NotificationType { get; set; }
    public string? Message { get; set; }

    public NotificationDto()
    {
    }

    public NotificationDto(Entities.Notification.Notification notification)
    {
        Expire = notification.Expire;
        this.NotificationType = notification.NotificationType;
        Message = notification.Message;
    }
}