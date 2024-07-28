namespace Domain.DTOs.Telegram;

public class StartTelegramBotDto
{
    public long? AgentCode { get; set; }
    public long ChatId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}