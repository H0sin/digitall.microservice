using System.ComponentModel.DataAnnotations;
using Domain.Entities.Account;
using Domain.Enums.Notification;

namespace Domain.DTOs.Notification;

public class AddNotificationDto
{
    [Display(Name = "پیغام")]
    [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string Message { get; set; }

    public DateTime Expire { get; set; } = DateTime.Now.AddHours(1);
    public NotificationType NotificationType { get; set; }
    public bool ForAllMember { get; set; }
    public long? UserId { get; set; }
}