namespace Domain.DTOs.Wireguard;

public class DeleteWireguardServiceDto
{
    public string? Username { get; set; }
    public long ChatId  { get; set; }
    public long UserId { get; set; }
    public long PeerId { get; set; }
    public long AgentAdminId { get; set; }
    public string? Message { get; set; }
}