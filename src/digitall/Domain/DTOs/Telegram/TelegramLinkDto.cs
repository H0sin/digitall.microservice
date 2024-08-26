namespace Domain.DTOs.Telegram;

public record TelegramLinkDto(string? Link, long? AgentCode)
{
    public string GenerateLink(string? userInfo)
    {
        if (Link is null)
            return $"https://t.me/{userInfo}?start={AgentCode}";
        return $"{Link}?start={AgentCode}";
    }
};