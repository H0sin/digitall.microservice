using System.ComponentModel.DataAnnotations;
using Domain.Entities.Telegram;

namespace Domain.DTOs.Telegram;

public class TelegramBotDto
{
    public long Id { get; set; }
    public string? Token { get; set; } = default!;
    public string? Name { get; set; }
    public string? PersionName { get; set; }
    public string? Description { get; set; }
    public string? Route { get; set; }
    public string? HostAddress { get; set; }
    public string? SecretToken { get; set; }
    public long? BotId { get; set; }
    public long? AgentId { get; set; }
    
    public TelegramBotDto(long id, string? token, string? name, string? persionName, string? description, string? route, string? hostAddress, string? secretToken)
    {
        Id = id;
        Token = token;
        Name = name;
        PersionName = persionName;
        Description = description;
        Route = route;
        HostAddress = hostAddress;
        SecretToken = secretToken;
    }

    public TelegramBotDto()
    {

    }

    public TelegramBotDto(TelegramBot? bot)
    {
        Token = bot?.Token;
        Name = bot?.Name;
        PersionName = bot?.PersionName;
        Description = bot?.Description;
        Route = bot?.Route;
        HostAddress = bot?.HostAddress;
        SecretToken = bot?.SecretToken;
        BotId = bot?.BotId;
        AgentId = bot?.AgentId;
    }
}