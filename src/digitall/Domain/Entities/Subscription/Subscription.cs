using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Subscription;

public class Subscription : BaseEntity
{
    [Display(Name = "نام ساب")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(40, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Name { get; set; }

    [Display(Name = "مقدار ساب")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(40, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Value { get; set; } = Guid.NewGuid().ToString("N");
}