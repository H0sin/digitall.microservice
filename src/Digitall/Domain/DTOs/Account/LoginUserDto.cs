using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Account;

public class LoginUserDto
{
    [Display(Name = "تلفن همراه")]
    public string? Email { get; set; }

    [Display(Name = "شناسه تلگرام")]
    public long? ChatId { get; set; }

    [Display(Name = "کلمه ی عبور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(30, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Password { get; set; }
}

public record LoginUserResponseDto(string Token, string UserName)
{
    [Display(Name = "توکن")] public string Token { get; set; } = Token;

    [Display(Name = "نام کاربری")] public string? UserName { get; set; } = UserName;
}