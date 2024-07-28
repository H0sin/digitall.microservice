using Domain.Entities.Transaction;

namespace Domain.DTOs.Transaction;

public class TransactionDetailDto
{
    public int    MaximumAmount { get; set; }
    public int    MinimalAmount { get; set; }
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public string? Description { get; set; }

    public TransactionDetailDto(TransactionDetail detail)
    {
        MaximumAmount = detail.MaximumAmount;
        MinimalAmount = detail.MinimalAmount;
        CardNumber = detail.CardNumber;
        CardHolderName = detail.CardHolderName;
        Description = detail.Description;
    }
}