using Microsoft.EntityFrameworkCore;

namespace Domain.DTOs.Agent;

public class AgentTreeDto
{
    public long Id { get; set; }
    public string? BrandName { get; set; }
    public string? PersianBrandName { get; set; }
    public long AgentAdminId { get; set; }
    public long AgentCode { get; set; }
    public string? BrandAddress { get; set; }
    public long AgentPercent { get; set; }
    public long UserPercent { get; set; }
    public string? CardNumber { get; set; }
    public string? AgentRequestStatus { get; set; }
    public long? TelegramBotId { get; set; }
    public List<AgentTreeDto> SubAgents { get; set; } = new List<AgentTreeDto>();
}