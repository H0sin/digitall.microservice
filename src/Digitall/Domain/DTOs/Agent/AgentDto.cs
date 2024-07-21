namespace Domain.DTOs.Agent;

public class AgentDto
{
    public AgentDto()
    {
    }

    public AgentDto(Entities.Agent.Agent? agent)
    {
        BrandName = agent.BrandName;
        PersianBrandName = agent.PersianBrandName;
        AgentAdminId = agent.AgentAdminId;
        AgentCode = agent.AgentCode;
        BrandAddress = agent.BrandAddress;
        Percent = agent.AgentPercent;
        Id = agent.Id;
    }

    public long Id { get; set; }
    public string? BrandName { get; set; }
    public string? PersianBrandName { get; set; }
    public long AgentAdminId { get; set; }
    public long AgentCode { get; set; }
    public string? BrandAddress { get; set; }
    public string? AdminAgentName { get; set; }
    public long Percent { get; set; }
}