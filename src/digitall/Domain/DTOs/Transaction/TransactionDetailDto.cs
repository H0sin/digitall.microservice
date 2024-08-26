using Domain.Entities.Transaction;

namespace Domain.DTOs.Transaction;

public class TransactionDetailDto
{
    public long Id { get; set; }
    public long MaximumAmountForAgent { get; set; }
    public long MinimalAmountForAgent { get; set; }
    public long MaximumAmountForUser { get; set; }
    public long MinimalAmountForUser { get; set; }
    public string? CardNumber { get; set; }
    public string? CardHolderName { get; set; }
    public string? Description { get; set; }
    public long AgentId { get; set; }
    public long UserPercent { get; set; } = 0;
    public long AgentPercent { get; set; } = 0;

    public TransactionDetailDto()
    {
    }

    public TransactionDetailDto(TransactionDetail? detail)
    {
        MaximumAmountForAgent = detail?.MaximumAmountForAgent ?? 0;
        MinimalAmountForAgent = detail?.MinimalAmountForAgent ?? 0;
        MaximumAmountForUser = detail?.MaximumAmountForUser ?? 0;
        MinimalAmountForUser = detail?.MinimalAmountForUser ?? 0;
        CardNumber = detail?.CardNumber;
        CardHolderName = detail?.CardHolderName;
        AgentId = detail.AgentId;
        Description = detail?.Description;
        Id = detail?.Id ?? 0;
        UserPercent = detail!.Agent!.UserPercent;
        AgentPercent = detail!.Agent!.AgentPercent;
    }
}