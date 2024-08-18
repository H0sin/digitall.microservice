using System.ComponentModel.DataAnnotations;
using Domain.Common;
using Domain.Entities.Account;
using Domain.Enums.Notification;

namespace Domain.Entities.Notification;

public class Notification : BaseEntity
{
    public DateTime Expire { get; set; }
    public NotificationType NotificationType { get; set; }
    public bool ForAllMember { get; set; }

    [Display(Name = "پیغام")]
    [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Message { get; set; }
    
    public bool Send { get; set; }
    
    public long? UserId { get; set; }
    public User? User { get; set; }
}