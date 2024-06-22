namespace Domain.DTOs.Telegram;

public class AddUserFromTelegramDto
{
    public long ChatId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}