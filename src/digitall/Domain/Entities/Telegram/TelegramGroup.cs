using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Telegram;

public class TelegramGroup : BaseEntity
{
    public long ChatId { get; set; }

    [Display(Name = "نام گروه")]
    [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Name { get; set; }

    [Display(Name = "لینک گروه")]
    [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Link { get; set; }

    public long? TelegramBotId { get; set; }
    
    public TelegramBot? TelegramBot { get; set; }
    
    public ICollection<TelegramGroupTopics>? TelegramGroupTopics { get; set; }
}