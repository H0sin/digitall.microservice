using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Domain.Common;

namespace Domain.Entities.Marzban;

public class MarzbanVpn : BaseEntity
{
    [Display(Name = "نام")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Name { get; set; }

    [Display(Name = "نهایت حجم")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long GbMax { get; set; }

    [Display(Name = "کم ترین مقدار حجم")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long GbMin { get; set; }

    [Display(Name = "قیمت هر گیگ")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long GbPrice { get; set; }

    [Display(Name = "نهایت روز")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long DayMax { get; set; }

    [Display(Name = "کمترین روز")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long DayMin { get; set; }

    [Display(Name = "قیمت هر روز")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long DayPrice { get; set; }

    public bool Test_Active { get; set; }

    [Display(Name = "تعداد روز تست")] public long Test_Days { get; set; } = 1;

    [Display(Name = "حجم تست")] public long Test_TotalGb { get; set; } = 1;

    public List<string>? Vmess { get; set; }
    public List<string>? Vless { get; set; }
    public List<string>? Shadowsocks { get; set; }
    public List<string>? Trojan { get; set; }
    public List<string>? Proxies { get; set; }

    public long MarzbanServerId { get; set; }

    public MarzbanServer? MarzbanServer { get; set; }
}