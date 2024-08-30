using System.Collections;
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
    public int GbMax { get; set; }

    [Display(Name = "کم ترین مقدار حجم")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public int GbMin { get; set; }

    [Display(Name = "قیمت هر گیگ")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long GbPrice { get; set; }

    [Display(Name = "نهایت روز")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public int DayMax { get; set; }

    [Display(Name = "کمترین روز")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public int DayMin { get; set; }

    [Display(Name = "قیمت هر روز")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long DayPrice { get; set; }

    [Display(Name = "نام هلدر بات")]
    [MaxLength(300)]
    public string? HolderBotInbound { get; set; } = null;

    [Display(Name = "وضعیت حجم و زمان دلخواه")]
    public bool Desired { get; set; }   
    
    public bool Test_Active { get; set; } = false;
    [Display(Name = "تعداد روز تست")] public int Test_Days { get; set; } = 1;
    [Display(Name = "حجم تست")] public int Test_TotalMg { get; set; } = 1;
    public List<string>? Vmess { get; set; }
    public List<string>? Vless { get; set; }
    public List<string>? Shadowsocks { get; set; }
    public List<string>? Trojan { get; set; }
    public List<string>? Proxies { get; set; }
    public long MarzbanServerId { get; set; }
    public MarzbanServer? MarzbanServer { get; set; }
    public ICollection<MarzbanVpnTemplate>? MarzbanVpnTemplate { get; set; }
}