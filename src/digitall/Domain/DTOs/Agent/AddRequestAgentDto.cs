using System.ComponentModel.DataAnnotations;
using Domain.DTOs.Transaction;
using Domain.Enums.Agent;

namespace Domain.DTOs.Agent;

public class AddRequestAgentDto
{
    [Display(Name = "نام برند")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? BrandName { get; set; }

    [Display(Name = "نام فارسی برند")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? PersianBrandName { get; set; }

    [Display(Name = "آدرس مغازه")] public string? BrandAddress { get; set; }

    [Display(Name = "درصد نماینده")] public long AgentPercent { get; set; } = 0;

    [Display(Name = "درصد کاربر")] public long UserPercent { get; set; } = 0;

    [Display(Name = "توضیحات")] public string? Description { get; set; }

    public AddTransactionDetialDto transactionDetial { get; set; }
}