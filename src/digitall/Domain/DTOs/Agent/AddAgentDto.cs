using System.ComponentModel.DataAnnotations;
using Domain.DTOs.Transaction;

namespace Domain.DTOs.Agent;

public class AddAgentDto
{
    [Display(Name = "نام برند")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? BrandName { get; set; }

    [Display(Name = "نام فارسی برند")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? PersianBrandName { get; set; }

    [Display(Name = "شناسه نماینده")] public long AgentAdminId { get; set; }

    [Display(Name = "آدرس مغازه")] public string? BrandAddress { get; set; }

    [Display(Name = "درصد")] public long Percent { get; set; }

    public AddTransactionDetailDto? AddTransactionDetialDto { get; set; }
}