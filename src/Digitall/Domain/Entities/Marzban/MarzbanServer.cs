using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Marzban;

public class MarzbanServer : BaseEntity
{
    [Display(Name = "نام سرور")]
    [MaxLength(100, ErrorMessage = "")]
    public string? ServerName { get; set; }

    [Display(Name = "ای پی سرور")]
    [MaxLength(40)]
    public string? ServerIp { get; set; }

    [Display(Name = "پورت سرور")]
    [MaxLength(10)]
    public string? ServerPort { get; set; }

    [Display(Name = "ssl")] public bool Ssl { get; set; } = false;

    [Display(Name = "Path")] public string? Path { get; set; }

    [Display(Name = "نام")] public string? UserName { get; set; }

    [Display(Name = "کلمه عبور")]
    [MaxLength(50)]
    public string? Password { get; set; }
    
    public ICollection<MarzbanVpn>? MarzbanVpns { get; set; }

    [Display(Name = "تعداد کاربر ها سرور")]
    public long Users { get; set; }
}