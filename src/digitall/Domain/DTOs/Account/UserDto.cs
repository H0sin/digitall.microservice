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
    public string Mobile { get; set; }

    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(20, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string MobileActiveCode { get; set; }

    [Display(Name = "موبایل فعال / غیرفعال")]
    public bool IsMobileActive { get; set; }

    [Display(Name = "نام")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string FirstName { get; set; }

    [Display(Name = "نام خانوادگی")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
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
    

    public UserDto()
    {
    }

    public UserDto(User user)
    {
        this.Id = user.Id;
        this.Email = user.Email;
        this.Mobile = user.Mobile!;
        this.MobileActiveCode = user.MobileActiveCode!;
        this.IsMobileActive = user.IsMobileActive;
        this.FirstName = user.FirstName!;
        this.LastName = user.LastName!;
        this.Avatar = user.Avatar;
        this.Address = user.Address;
        this.AgentId = user.AgentId;
        this.ModifiedDate = user.ModifiedDate;
        this.Balance = user.Balance;
        this.ChatId = user.ChatId;
    }
}