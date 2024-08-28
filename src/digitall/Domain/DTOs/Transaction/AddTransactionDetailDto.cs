using System.ComponentModel.DataAnnotations;
using Domain.Entities.Transaction;

namespace Domain.DTOs.Transaction;

public class AddTransactionDetailDto
{
    [Display(Name = "بیشترین مقدار تراکنش")]
    public long MaximumAmountForAgent { get; set; } = 2000000;

    [Display(Name = "کمترین مقدار تراکنش")]
    public long MinimalAmountForAgent { get; set; } = 0;

    [Display(Name = "بیشترین مقدار تراکنش برای کاربر")]
    public long MaximumAmountForUser { get; set; } = 2000000;
    
    [Display(Name = "کمترین مقدار تراکنش برای کاربر")]
    public long MinimalAmountForUser { get; set; } = 0;
    
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
    
    
    public TransactionDetail _GenerateTransaction()
    {
        return new()
        {
            MaximumAmountForAgent = MaximumAmountForAgent,
            MaximumAmountForUser = MaximumAmountForUser,
            MinimalAmountForUser = MinimalAmountForUser,
            CardNumber = CardNumber,
            Description = Description,
            MinimalAmountForAgent = MinimalAmountForAgent,
            CardHolderName = CardHolderName,
            AgentId = AgentId
        };
    }
}