using Domain.DTOs.Paging;

namespace Domain.DTOs.Agent;

public class FilterAgentDto : BasePaging<AgentDto>
{
    public string? AgentName { get; set; }
    public string? AdminAgentName { get; set; }
}