using Domain.Entities.Transaction;

namespace Domain.DTOs.Agent;

public class AgencyInformationDto
{
    public long Id { get; set; }
    public string? BrandName { get; set; }
    public string? PersianBrandName { get; set; }
    public long AgentAdminId { get; set; }
    public long AgentCode { get; set; }
    public string? BrandAddress { get; set; }
    public long TransactionDetailId { get; set; }
    public long AgentPercent { get; set; }
    public long UserPercent { get; set; }
    public bool AllowNegative { get; set; } = false;
    public long MaximumAmountForAgent { get; set; }
    public long MinimalAmountForAgent { get; set; }
    public long MaximumAmountForUser { get; set; }
    public long MinimalAmountForUser { get; set; }
    public string? CardNumber { get; set; }
    public string? CardHolderName { get; set; }
    public string? Description { get; set; }

    public AgencyInformationDto(Entities.Agent.Agent agent, TransactionDetail transactionDetail)
    {
        BrandName = agent.BrandName;
        PersianBrandName = agent.PersianBrandName;
        AgentCode = agent.AgentCode;
        BrandAddress = agent.BrandAddress;
        AgentPercent = agent.AgentPercent;
        UserPercent = agent.UserPercent;
        AllowNegative = agent.AllowNegative;
        MaximumAmountForAgent = transactionDetail.MaximumAmountForAgent ?? 0;
        MinimalAmountForAgent = transactionDetail.MaximumAmountForAgent ?? 0;
        MaximumAmountForUser = transactionDetail.MaximumAmountForAgent ?? 0;
        MinimalAmountForUser = transactionDetail.MaximumAmountForAgent ?? 0;
        CardNumber = transactionDetail.CardNumber;
        CardHolderName = transactionDetail.CardHolderName;
        Description = transactionDetail.Description;
        TransactionDetailId = transactionDetail.Id;
        AgentAdminId = agent.AgentAdminId;
        Id = agent.Id;
    }
}





















