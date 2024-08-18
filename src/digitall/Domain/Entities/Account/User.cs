using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;
using Domain.Entities.Agent;
using Domain.Entities.Authorization;

namespace Domain.Entities.Account;

public class User : BaseEntity
{
    #region properties

    [Display(Name = "ایمیل")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [Display(Name = "تلفن همراه")]
    [MaxLength(12, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Mobile { get; set; }

    [Display(Name = "کلمه ی عبور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Password { get; set; }

    [Display(Name = "کد فعال سازی مبایل")]
    [MaxLength(20, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? MobileActiveCode { get; set; }

    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(40, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? EmailActiveCode { get; set; }

    [Display(Name = "موبایل فعال / غیرفعال")]
    public bool IsMobileActive { get; set; }

    [Display(Name = "ایمیل فعال / غیرفعال")]
    public bool IsEmailActive { get; set; }

    [Display(Name = "نام")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? FirstName { get; set; }

    [Display(Name = "نام خانوادگی")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? LastName { get; set; }

    [Display(Name = "تصویر آواتار")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Avatar { get; set; }

    [Display(Name = "بلاک شده / نشده")] public bool IsBlocked { get; set; }

    [Display(Name = "آدرس")]
    [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Address { get; set; }

    [Display(Name = "شناسه نمایندگی")] public long AgentId { get; set; }

    [Display(Name = "موجودی")] public long Balance { get; set; }

    [Display(Name = "شناسه چت تلگرام")] public long? ChatId { get; set; }

    [Display(Name = "توضیحات")]
    [MaxLength(3000, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Description { get; set; }

    public bool UserStatus { get; set; } = false; // not active defualt

    [Display(Name = "نهایت تعداد اکانت تست")]
    public long FinalCountTestMarzbanAccount { get; set; }

    [Display(Name = "شناسه ربات عضو شده")] public long? BotId { get; set; }

    [Display(Name = "شناسه تلگرام")]
    public string? TelegramUsername { get; set; }

    #endregion

    #region relations

    public ICollection<UserRole>? UserRoles { get; set; }

    [ForeignKey(nameof(AgentId))] public Agent.Agent Agent { get; set; }

    public AgentRequest AgentRequest { get; set; }

    public ICollection<Notification.Notification>? Notifications { get; set; }

    #endregion
}