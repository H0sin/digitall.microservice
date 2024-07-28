using System.ComponentModel.DataAnnotations;
using Domain.Entities.Marzban;

namespace Domain.DTOs.Marzban;

public class AddMarzbanServerDto
{
    [Display(Name = "نام سرور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? ServerName { get; set; }

    [Display(Name = "ای پی سرور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(40, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? ServerIp { get; set; }

    [Display(Name = "پورت سرور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? ServerPort { get; set; }

    [Display(Name = "ssl")] public bool Ssl { get; set; } = false;

    [Display(Name = "Path")] public string? Path { get; set; }

    [Display(Name = "نام")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? UserName { get; set; }

    [Display(Name = "کلمه عبور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Password { get; set; }

    [Display(Name = "تعداد کاربر ها سرور")]
    public long Users { get; set; } = 0;

    public MarzbanServer _CreateMarzban()
    {
        return new MarzbanServer
        {
            ServerIp = ServerIp,
            Password = Password,
            ServerName = ServerName,
            Ssl = Ssl,
            ServerPort = ServerPort,
            UserName = UserName,
            Path = Path,
            Users = Users
        };
    }
}