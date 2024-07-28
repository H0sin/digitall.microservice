using System.ComponentModel.DataAnnotations;
using Domain.Enums.Server;

namespace Domain.DTOs.Server;

public class AddServerDto
{
    [Display(Name = "نام سرور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]

    public required string ServerName { get; set; }

    [Display(Name = "آدرس سرور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]

    public required string ServerAddress { get; set; }

    [Display(Name = "نام کاربری")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]

    public required string UserName { get; set; }

    [Display(Name = "کلمه عبور سرور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]

    public required string Password { get; set; }

    [Display(Name = "پورت سروس")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

    public string? Port { get; set; }

    [Display(Name = "ساب پورت")] public string SubPort { get; set; }

    [Display(Name = "پس")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public string SubPath { get; set; }

    [Display(Name = "ساب دومین")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public string SubDomain { get; set; }

    public ServerStatus ServerStatus { get; set; }

    public required long CountryId { get; set; }
}