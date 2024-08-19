namespace Domain.DTOs.Agent;

public class AgentInformationDto
{
    public string? BrandName { get; set; }
    public string? PersianBrandName { get; set; }
    public long AgentAdminId { get; set; }
    public long AgentCode { get; set; }
    public string? BrandAddress { get; set; }
    public long AgentPercent { get; set; }
    public long UserPercent { get; set; }
    public long? TelegramBotId { get; set; }
    public string? BotName { get; set; }
    public string? BotToken { get; set; }
    public string? BotId { get; set; }
    public string? AdminName { get; set; }
    public int CountUser { get; set; }
    public long Sale { get; set; }
}