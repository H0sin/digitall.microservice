using Domain.DTOs.Agent;
using Domain.Entities.Transaction;

namespace Domain.DTOs.Transaction;

public class AgentsIncomesDetailByPriceDto
{
    public List<AgentsIncomesDetailDto>? AgentsIncomesDetail { get; set; }
    public long Price { get; set; } = 0;
    public long DayPrice { get; set; }
    public long GbPrice { get; set; }
}