using Domain.Entities.Transaction;

namespace Domain.DTOs.Agent;

public class AgentIncomeDto
{
    public long AgentId { get; set; }
    public long Profit { get; set; }
    public long UserId { get; set; }
    public DateTime CreateDate { get; set; }

    public AgentIncomeDto(AgentsIncomesDetail income)
    {
        AgentId = income.AgentId;
        Profit = income.Profit;
        UserId = income.UserId;
        CreateDate = income.CreateDate;
    }

    public AgentIncomeDto()
    {
        
    }
}