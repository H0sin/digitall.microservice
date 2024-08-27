using Domain.Enums.Agent;
using Microsoft.EntityFrameworkCore;

namespace Domain.DTOs.Agent;

public class AgentDto
{
    public AgentDto(Entities.Agent.Agent? agent)
    {
        TransactionDetailId = agent?.TransactionDetail?.Id ?? 0;
        BrandName = agent!.BrandName;
        PersianBrandName = agent!.PersianBrandName;
        AgentAdminId = agent!.AgentAdminId;
        AgentCode = agent!.AgentCode;
        BrandAddress = agent!.BrandAddress;
        AgentPercent = agent!.AgentPercent;
        UserPercent = agent!.UserPercent;
        AgentPath = agent!.AgentPath;
        Id = agent!.Id;
        SpecialPercent = agent.SpecialPercent ?? 0;
    }

    public AgentDto()
    {
        
    }
    
    public HierarchyId? AgentPath { get; set; }
    public long Id { get; set; }
    public string? BrandName { get; set; }
    public string? PersianBrandName { get; set; }
    public long AgentAdminId { get; set; }
    public long AgentCode { get; set; }
    public string? BrandAddress { get; set; }
    public string? AdminAgentName { get; set; }
    public string AgentRequestStatus { get; set; }
    public long TransactionDetailId { get; set; }
    public long AgentPercent { get; set; }
    public long UserPercent { get; set; }
    public long SpecialPercent { get; set; } = 0;
}