using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;
using Domain.DTOs.Agent;
using Domain.Entities.Account;
using Domain.Entities.Telegram;
using Domain.Enums.Agent;
using Microsoft.AspNetCore.Mvc;
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
    public long AgentCode { get; set; } = new Random().Next(10000, 9999999);

    [Display(Name = "آدرس مغازه")] public string? BrandAddress { get; set; }
    [Display(Name = "درصد نماینده")] public long AgentPercent { get; set; }

    [Display(Name = "درصد کاربران")] public long UserPercent { get; set; }

    [Display(Name = "شماره کارت نماینده")]
    [Length(16, 16, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? CardNumber { get; set; }

    [Display(Name = "وضعیت درخواست نمایندگی")]
    public string? AgentRequestStatus { get; set; } = "wating";

    public HierarchyId? AgentPath { get; set; }
    public long? TelegramBotId { get; set; }

    #endregion

    #region relation

    public ICollection<User>? Users { get; set; } = null;

    [ForeignKey(nameof(TelegramBotId))] public TelegramBot? TelegramBot { get; set; }

    #endregion
}