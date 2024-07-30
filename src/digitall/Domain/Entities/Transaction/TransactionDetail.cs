using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Transaction;

public class TransactionDetail : BaseEntity
{
    [Display(Name = "بیشترین مقدار تراکنش")]
    public int MaximumAmount { get; set; } = 2000000;

    [Display(Name = "کمترین مقدار تراکنش")]
    public int MinimalAmount { get; set; } = 1000000;

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