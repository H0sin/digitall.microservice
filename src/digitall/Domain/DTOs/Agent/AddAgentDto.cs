using System.ComponentModel.DataAnnotations;
using Domain.DTOs.Transaction;

namespace Domain.DTOs.Agent;

public class AddAgentDto
{
    [Display(Name = "نام برند")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? BrandName { get; set; } = "";

    [Display(Name = "نام فارسی برند")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? PersianBrandName { get; set; } = "";

    [Display(Name = "شناسه نماینده")] public long AgentAdminId { get; set; }

    [Display(Name = "آدرس مغازه")] public string? BrandAddress { get; set; }

    [Display(Name = "درصد نماینده")] public int AgentPercent { get; set; } = 50;

    [Display(Name = "درصد کاربر")] public int UserPercent { get; set; } = 200;

    public AddTransactionDetailDto? AddTransactionDetail { get; set; }
}