namespace Domain.DTOs.Telegram;

public class SubscribeFactorBotDto
{
    public string? Title { get; set; }
    public int Days { get; set; }
    public long Price { get; set; }
    public int Gb { get; set; }
    public string? Description { get; set; }
    public long Balance { get; set; }
    public long Count { get; set; } 
}