using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;
using Domain.DTOs.Agent;
using Domain.Entities.Account;
using Domain.Entities.Telegram;
using Domain.Entities.Transaction;
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
    public long AgentCode { get; set; }

    [Display(Name = "آدرس مغازه")] public string? BrandAddress { get; set; }
    [Display(Name = "درصد نماینده")] public long AgentPercent { get; set; }

    [Display(Name = "درصد کاربران")] public long UserPercent { get; set; }

    [Display(Name = "درصد ویژه")] public long? SpecialPercent { get; set; } = null;

    public HierarchyId? AgentPath { get; set; }

    public bool AllowNegative { get; set; } = false;

    public long AmountWithNegative { get; set; } = 0;

    public long NegativeChargeCeiling { get; set; } = 0;
    
    #endregion

    #region relation

    public ICollection<User>? Users { get; set; } = null;
    public TelegramBot? TelegramBot { get; set; }
    public AgentOptions? AgentOptions { get; set; }
    public TransactionDetail? TransactionDetail { get; set; }
    public ICollection<AgentsIncomesDetail>? AgentsIncomesDetail { get; set; }

    #endregion
}