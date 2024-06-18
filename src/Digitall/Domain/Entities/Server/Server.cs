using System.ComponentModel.DataAnnotations;
using Domain.Common;
using Domain.Entities.Sanaei;
using Domain.Enums.Server;

namespace Domain.Entities.Server;

public class Server : BaseEntity
{
    [Display(Name = "نام سرور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]

    public string ServerName { get; set; }

    [Display(Name = "آدرس سرور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]

    public string ServerAddress { get; set; }

    [Display(Name = "نام کاربری")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]

    public string UserName { get; set; }

    [Display(Name = "کلمه عبور سرور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]

    public string Password { get; set; }

    [Display(Name = "پورت سروس")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public string Port { get; set; }

    [Display(Name = "پس")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public string SubPath { get; set; }

    [Display(Name = "ساب دومین")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public string SubDomain { get; set; }

    [Display(Name = "ساب پورت")] public string SubPort { get; set; }

    [Display(Name = "وضعیت سرور")] public ServerStatus ServerStatus { get; set; } = ServerStatus.Active;

    public long CountryId { get; set; }

    #region relations

    public Country.Country Country { get; set; }
    public ICollection<Inbound> Inbounds { get; set; }

    #endregion
}