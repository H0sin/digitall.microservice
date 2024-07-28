using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Account;

public class ForgetUserPasswordDto
{
    [Display(Name = "تلفن همراه")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(12, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string Mobile { get; set; }
}