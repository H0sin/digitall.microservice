using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.MikroTik;

public class MikroTikServer : BaseEntity
{
    [Display(Name = "ای پی")]
    [MaxLength(40, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Ip { get; set; }
    
    [Display(Name = "نام")]
    [MaxLength(30, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Name { get; set; }
    
    [Display(Name = "پسورد")]
    [MaxLength(30, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Password { get; set; }

    [Display(Name = "پورت")]
    public int Port { get; set; }

    [Display(Name = "نام کاریری")]
    [MaxLength(30, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Username { get; set; }
}