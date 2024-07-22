using Domain.DTOs.Paging;

namespace Domain.DTOs.Agent;

public class FilterAgentDto : BasePaging<AgentDto>
{
    public long? AdminId { get; set; }
    public string? PersianBrandName { get; set; }
    public string? AdminAgentName { get; set; }
}