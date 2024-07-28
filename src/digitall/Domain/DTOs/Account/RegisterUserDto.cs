using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Account;

public class RegisterUserDto
{
    [Display(Name = "ایمیل")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Email { get; set; }

    [Display(Name = "نام")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? FirstName { get; set; }

    [Display(Name = "نام خانوادگی")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? LastName { get; set; }

    [Display(Name = "کلمه عبور")] public string? Password { get; set; }

    [Display(Name = "تکرار کلمه عبور")]
    [Compare(nameof(Password), ErrorMessage = "کلمه های عبور مغایرت دارند")]
    public string? ConfirmPassword { get; set; }

    [Display(Name = "کد نمایندگی")] public long? AgentCode { get; set; }

    [Display(Name = "توضیحات")]
    [MaxLength(3000, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Description { get; set; }
}