using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;
using Domain.Entities.Account;
using Domain.Entities.Telegram;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Agent;

[Table("Agent")]
public class Agent : BaseEntity
{
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
    [Display(Name = "درصد نماینده")] public long AgentPercent { get; set; }

    [Display(Name = "درصد کاربران")] public long UserPercent { get; set; }
    public HierarchyId? AgentPath { get; set; }

    public long? TelegramBotId { get; set; }

    #endregion

    #region relation

    public ICollection<User>? Users { get; set; } = null;

    [ForeignKey(nameof(TelegramBotId))] public TelegramBot? TelegramBot { get; set; }

    #endregion
}