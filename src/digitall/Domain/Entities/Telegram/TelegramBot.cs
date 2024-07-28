using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Telegram;

public class TelegramBot : BaseEntity
{
    [Display(Name = "توکن")]
    [MaxLength(200)]
    public string? Token { get; set; } = default!;

    [Display(Name = "نام")]
    [MaxLength(50)]
    public string? Name { get; set; }

    [Display(Name = "نام فارسی")]
    [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? PersionName { get; set; }

    [Display(Name = "توضیحات")]
    [MaxLength(3000, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Description { get; set; }

    [Display(Name = "Route")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Route { get; set; } = Guid.NewGuid().ToString("N");

    [Display(Name = "HostAddress ")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? HostAddress { get; set; }

    [Display(Name = "SecretToken ")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? SecretToken { get; set; }

    public Agent.Agent? Agent { get; set; }
}