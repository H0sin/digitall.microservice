namespace Domain.DTOs.Telegram;

public class ButtonJsonDto
{
    public ButtonJsonDto(string text,string callbackQuery)
    {
        Text = text;
        CallbackQuery = callbackQuery;
    }
    
    public string? Text { get; set; } = string.Empty;
    public string? CallbackQuery { get; set; }
}