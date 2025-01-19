using Domain.DTOs.Agent;
using Domain.Entities.Account;
using Domain.Entities.Telegram;

namespace Domain.DTOs.Account;

public class UserInformationDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? TelegramUsername { get; set; }
    public bool IsAgent { get; set; }
    public long ChatId { get; set; }
    public long Id { get; set; }
    public AgentDto? Agency { get; set; }
    public string? BotName { get; set; }
    public string? BotLink { get; set; }
    public long Balance { get; set; }
    public string? Avatar { get; set; }

    public UserInformationDto(User? user, AgentDto? agent, TelegramBot? bot,string? avatar = null)
    {
        FirstName = user?.FirstName;
        LastName = user?.LastName;
        TelegramUsername = user?.TelegramUsername;
        IsAgent = user?.IsAgent ?? false;
        ChatId = user?.ChatId ?? 0;
        Id = user.Id;
        Balance = user.Balance;
        Agency = agent;
        BotName = bot?.Link?.Replace("https://t.me/", "").Replace("_", " ") ?? "";
        BotLink = bot?.Link;
        Avatar = avatar ?? user.Avatar;
    }

    public UserInformationDto()
    {
    }
}