using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Authorization;

public class AddRoleDto
{
    [Display(Name = "نام نمایشی")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string Title { get; set; }
}