using System.ComponentModel.DataAnnotations;
using Domain.Common;
using Domain.Enums.Agent;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Agent;

public class AgentRequest : BaseEntity
{
    [Display(Name = "نام برند")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? BrandName { get; set; }

    [Display(Name = "نام فارسی برند")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? PersianBrandName { get; set; }

    [Display(Name = "شناسه مدیر برند")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    public long AgentAdminId { get; set; } = 1;

    [Display(Name = "کد برند")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long AgentCode { get; set; }

    [Display(Name = "آدرس مغازه")] public string? BrandAddress { get; set; }

    [Display(Name = "درصد نماینده")] public long AgentPercent { get; set; }

    [Display(Name = "درصد کاربران")] public long UserPercent { get; set; }

    [Display(Name = "شماره کارت نماینده")]
    [Length(16, 16, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? CardNumber { get; set; }

    [Display(Name = "توضیحات")]
    [MaxLength(3000, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Description { get; set; }

    public AgentRequestStatus? AgentRequestStatus { get; set; } = Enums.Agent.AgentRequestStatus.Wating;
}