using System.ComponentModel.DataAnnotations;
using Domain.Entities.Transaction;

namespace Domain.DTOs.Transaction;

public class AddTransactionDetialDto
{
    [Display(Name = "بیشترین مقدار تراکنش")]
    public int MaximumAmount { get; set; } = 2000000;

    [Display(Name = "کمترین مقدار تراکنش")]
    public int MinimalAmount { get; set; }

    [Display(Name = "شماره کارت")]
    [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string CardNumber { get; set; }

    [Display(Name = "صاحب کارت")]
    [MaxLength(300, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string CardHolderName { get; set; }

    [Display(Name = "توضیحات")]
    [MaxLength(3000, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Description { get; set; }

    public TransactionDetail _GenerateTransaction()
    {
        return new()
        {
            MaximumAmount = MaximumAmount,
            CardNumber = CardNumber,
            Description = Description,
            MinimalAmount = MinimalAmount,
            CardHolderName = CardHolderName
        };
    }
}