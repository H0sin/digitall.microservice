using System.ComponentModel.DataAnnotations;
using Domain.Common;
using Domain.DTOs.Transaction;
using Domain.Entities.Account;

namespace Domain.Entities.Agent;

public class AgentRequest : BaseEntity
{
    public long UserId { get; set; }
    public User User { get; set; }
    
    [Display(Name = "نام برند")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? BrandName { get; set; }

    [Display(Name = "نام فارسی برند")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string? PersianBrandName { get; set; }

    [Display(Name = "آدرس مغازه")] public string? BrandAddress { get; set; }

    [Display(Name = "درصد نماینده")] public long? AgentPercent { get; set; } = 0;

    [Display(Name = "درصد کاربر")] public long? UserPercent { get; set; } = 0;

    [Display(Name = "توضیحات")] public string? Description { get; set; } = "";
    
    [Display(Name = "بیشترین مقدار تراکنش")]
    public int MaximumAmount { get; set; } = 2000000;

    [Display(Name = "کمترین مقدار تراکنش")]
    public int MinimalAmount { get; set; } = 0;

    [Display(Name = "شماره کارت")]
    [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? CardNumber { get; set; } = "";

    [Display(Name = "صاحب کارت")]
    [MaxLength(300, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? CardHolderName { get; set; } = "";

    [Display(Name = "توضیحات پرداخت")]
    [MaxLength(700)]
    public string? PaymentDescription { get; set; }
    
    [Display(Name = "وضعیت درخواست نمایندگی")]
    public string? AgentRequestStatus { get; set; } = "wating";
}