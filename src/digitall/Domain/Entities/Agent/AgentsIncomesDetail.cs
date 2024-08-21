using Domain.Common;
using Domain.Entities.Order;

namespace Domain.Entities.Transaction;

public class AgentsIncomesDetail : BaseEntity
{
    public long AgentId { get; set; }
    public long Profit { get; set; }
    public long OrderDetailId { get; set; }
    public Agent.Agent Agent { get; set; } = null!;
    public long UserId { get; set; }
    public OrderDetail OrderDetail { get; set; }
}