namespace Domain.DTOs.Account;

public class LoginDto
{
    public string? Email { get; set; }
    public string? Password { get; set; }
    public long? ChatId { get; set; }
}