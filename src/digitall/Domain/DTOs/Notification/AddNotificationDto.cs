using System.ComponentModel.DataAnnotations;
using Domain.DTOs.Telegram;
using Domain.Entities.Account;
using Domain.Enums.Notification;

namespace Domain.DTOs.Notification;

public class AddNotificationDto
{
    public string Message { get; set; }
    public DateTime Expire { get; set; } = DateTime.Now.AddHours(1);
    public NotificationType NotificationType { get; set; }
    public bool ForAllMember { get; set; }
    public long? UserId { get; set; } = 0;
    public List<ButtonJsonDto>? Buttons { get; set; }
    public string? FileAddress { get; set; }
}