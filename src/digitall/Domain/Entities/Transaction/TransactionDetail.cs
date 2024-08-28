using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Transaction;

public class TransactionDetail : BaseEntity
{
    [Display(Name = "بیشترین مقدار تراکنش برای نماینده")]
    public long? MaximumAmountForAgent { get; set; } = 10000000;

    [Display(Name = "کمترین مقدار تراکنش برای نماینده")]
    public long? MinimalAmountForAgent { get; set; } = 100000;

    [Display(Name = "بیشترین مقدار تراکنش برای کاربر")]
    public long? MaximumAmountForUser { get; set; } = 10000000;
    
    [Display(Name = "کمترین مقدار تراکنش برای کاربر")]
    public long? MinimalAmountForUser { get; set; } = 20000;

    [Display(Name = "شماره کارت")]
    [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? CardNumber { get; set; }

    [Display(Name = "صاحب کارت")]
    [MaxLength(300, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? CardHolderName { get; set; }

    [Display(Name = "توضیحات")]
    [MaxLength(3000, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Description { get; set; }

    public long AgentId { get; set; }
    
    public Agent.Agent? Agent { get; set; }

    public ICollection<Transaction>? Transactions { get; set; }
}