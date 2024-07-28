namespace Domain.DTOs.Telegram;

public class BaseTelegramFilter
{
    public int Skip { get; set; } = 0;
    public int Take { get; set; } = 15;
}