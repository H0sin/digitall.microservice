using System.ComponentModel.DataAnnotations;
using Domain.Entities.Account;

namespace Domain.DTOs.Account;

public class UserDto
{
    [Display(Name = "شناسه")] public long Id { get; set; }

    [Display(Name = "ایمیل")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [Display(Name = "تلفن همراه")]
    [MaxLength(12, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    [MinLength(11, ErrorMessage = "{0} نمی تواند کمتر از {1} کاراکتر باشد")]
    public string? Mobile { get; set; }

    public string MobileActiveCode { get; set; }

    [Display(Name = "موبایل فعال / غیرفعال")]
    public bool IsMobileActive { get; set; }

    [Display(Name = "نام")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? FirstName { get; set; }

    [Display(Name = "نام خانوادگی")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string LastName { get; set; }

    [Display(Name = "تصویر آواتار")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Avatar { get; set; }


    [Display(Name = "آدرس")]
    [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Address { get; set; }

    [Display(Name = "کد")] public long AgentId { get; set; }

    public DateTime ModifiedDate { get; set; }

    [Display(Name = "موجودی")] public long Balance { get; set; }

    public long? ChatId { get; set; }

    public string? TelegramUsername { get; set; }

    public bool UserStatus { get; set; }

    public bool IsBlocked { get; set; }

    public bool CardToCardPayment { get; set; }
    public DateTime CreateDate { get; set; }
    
    public bool IsAgent { get; set; }

    public UserDto()
    {
    }

    public UserDto(User user)
    {
        Id = user.Id;
        Email = user.Email;
        Mobile = user.Mobile!;
        MobileActiveCode = user.MobileActiveCode!;
        IsMobileActive = user.IsMobileActive;
        FirstName = user.FirstName!;
        LastName = user.LastName!;
        Avatar = user.Avatar;
        Address = user.Address;
        AgentId = user.AgentId;
        ModifiedDate = user.ModifiedDate;
        Balance = user.Balance;
        ChatId = user.ChatId;
        TelegramUsername = user.TelegramUsername;
        UserStatus = user.UserStatus;
        CreateDate = user.CreateDate;
        CardToCardPayment = user.CardToCardPayment;
        IsBlocked = user.IsBlocked;
        IsAgent = user.IsAgent;
    }
}