using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;
using Domain.Entities.Account;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Agent;

[Table("Agent")]
public class Agent : BaseEntity
{
    #region relation

    public ICollection<User>? Users { get; set; } = null;

    #endregion

    #region peroperties

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

    [Display(Name = "درصد")] public long Percent { get; set; }

    public HierarchyId? AgentPath { get; set; }

    #endregion
}