namespace Domain.DTOs.Marzban;

public class DeleteMarzbanUserDto
{
    public string? Username { get; set; }
    public long ChatId  { get; set; }
    public long UserId { get; set; }
    public long MarzbanUserId { get; set; }
    public long AgentAdminId { get; set; }
    public string? Message { get; set; }
}