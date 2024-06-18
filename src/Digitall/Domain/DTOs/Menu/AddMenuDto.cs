using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Menu;

public class AddMenuDto
{
    public long? ParentId { get; set; }

    [Display(Name = "نام نمایشی")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Title { get; set; }

    [Display(Name = "وضعیت")] public bool Active { get; set; } = true;

    [Display(Name = "نام نمایشی")]
    [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Icon { get; set; }

    [Display(Name = "ادرس")]
    [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? Link { get; set; }

    [Display(Name = "مرتب سازی")] public int Sorted { get; set; }
}