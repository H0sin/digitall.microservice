using Domain.Entities.Transaction;

namespace Domain.DTOs.Transaction;

public class TransactionDetailDto
{
    public long Id { get; set; }
    public int MaximumAmount { get; set; }
    public int MinimalAmount { get; set; }
    public string? CardNumber { get; set; }
    public string? CardHolderName { get; set; }
    public string? Description { get; set; }
    public long AgentId { get; set; }

    public TransactionDetailDto()
    {
        
    }

    public TransactionDetailDto(TransactionDetail? detail)
    {
        MaximumAmount = detail?.MaximumAmount ?? 0;
        MinimalAmount = detail?.MinimalAmount ?? 0;
        CardNumber = detail?.CardNumber;
        CardHolderName = detail?.CardHolderName;
        AgentId = detail.AgentId;
        Description = detail?.Description;
        Id = detail?.Id ?? 0;
    }

    public string GetTransactionMessage()
    {
        return
            $"\ud83d\udcb8 مبلغ را به تومان وارد کنید:\n\u2705 حداقل مبلغ {MinimalAmount} حداکثر مبلغ {MaximumAmount} تومان می باشد";
    }
}