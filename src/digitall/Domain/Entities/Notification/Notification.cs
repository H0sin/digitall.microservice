using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;
using Domain.DTOs.Telegram;
using Domain.Entities.Account;
using Domain.Enums.Notification;
using Newtonsoft.Json;

namespace Domain.Entities.Notification;

public class Notification : BaseEntity
{
    public DateTime Expire { get; set; }
    public NotificationType NotificationType { get; set; }
    public bool ForAllMember { get; set; }

    [Display(Name = "پیغام")]
    public string? Message { get; set; }

    [Display(Name = "توضیحات فایل")]
    [MaxLength(500, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? FileCaption { get; set; }
    
    public bool Send { get; set; }

    [Column(TypeName = "nvarchar(max)")] public string? ButtonsJson { get; set; }

    [NotMapped]
    public List<ButtonJsonDto>? Buttons
    {
        get => ButtonsJson == null ? null : JsonConvert.DeserializeObject<List<ButtonJsonDto>>(ButtonsJson);
        set => ButtonsJson = value == null ? null : JsonConvert.SerializeObject(value);
    }

    public long? UserId { get; set; }
    public User? User { get; set; }

    public string? FileAddress { get; set; }
}