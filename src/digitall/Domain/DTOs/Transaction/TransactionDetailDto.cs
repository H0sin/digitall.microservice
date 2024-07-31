using Domain.Entities.Transaction;

namespace Domain.DTOs.Transaction;

public class TransactionDetailDto
{
    public int MaximumAmount { get; set; }
    public int MinimalAmount { get; set; }
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public string? Description { get; set; }

    public TransactionDetailDto(TransactionDetail? detail)
    {
        MaximumAmount = detail.MaximumAmount;
        MinimalAmount = detail.MinimalAmount;
        CardNumber = detail?.CardNumber;
        CardHolderName = detail?.CardHolderName;
        Description = detail?.Description;
    }

    public string GetTransactionMessage()
    {
        return
            $"\ud83d\udcb8 مبلغ را به تومان وارد کنید:\n\u2705 حداقل مبلغ {MinimalAmount} حداکثر مبلغ {MaximumAmount} تومان می باشد";
    }
}