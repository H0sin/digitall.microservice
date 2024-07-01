using System.ComponentModel.DataAnnotations;
using Domain.Common;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Entities.Marzban;

public class MarzbanVpnTemplate : BaseEntity
{
    [Display(Name = "عنوان")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Title { get; set; }

    [Display(Name = "مبلغ")] public long Price { get; set; }

    [Display(Name = "تعداد روز")] public int Days { get; set; }

    [Display(Name = "گیگابایت")] public int Gb { get; set; }

    public long MarzbanVpnId { get; set; }

    public MarzbanVpn? MarzbanVpn { get; set; }
}