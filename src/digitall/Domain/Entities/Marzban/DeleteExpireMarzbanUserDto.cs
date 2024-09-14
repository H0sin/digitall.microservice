namespace Domain.Entities.Marzban;

public class DeleteExpireMarzbanUserDto
{
    public DateTime? Expired_Before { get; set; }
    public DateTime? Expired_After { get; set; }
}