using Domain.Common;

namespace Domain.Entities.Transaction;

public class AgentsIncomesDetail : BaseEntity
{
    public long AgentId { get; set; }
    public long Profit { get; set; }
    public long OrderDetailId { get; set; }
    public Agent.Agent Agent { get; set; } = null!;
}