using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Marzban;

public class UpdateMarzbanVpnTemplatesDto
{
    [Display(Name = "عنوان")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Title { get; set; }

    [Display(Name = "مبلغ")] public long Price { get; set; }

    [Display(Name = "تعداد روز")] public int Days { get; set; }

    [Display(Name = "گیگابایت")] public int Gb { get; set; }

    public long MarzbanVpnId { get; set; }
}