using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Telegram;

public class TelegramButtons : BaseEntity
{
    [Display(Name = "نام دکمه")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public required string Name { get; set; }

    [Display(Name = "نام نمایشی")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public required string Title { get; set; }

    [Display(Name = "کال بک")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? CallBackQuery { get; set; }

    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? AdditionalProp1 { get; set; } = null;

    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? AdditionalProp2 { get; set; } = null;

    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? AdditionalProp3 { get; set; } = null;

    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? AdditionalProp4 { get; set; } = null;
    
    [Display(Name = "لینک")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Link { get; set; }

    public bool IsLike { get; set; } = false;
    
    public long? TelegramBotId { get; set; }
    public TelegramBot? TelegramBot { get; set; }
}