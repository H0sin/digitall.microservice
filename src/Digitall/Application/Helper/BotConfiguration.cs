namespace Application.Helper;

public class BotConfiguration
{
    public string Name { get; set; }
    public string Token { get; set; }
    public string HostAddress { get; set; }
    public string Route { get; set; }
    public string SecretToken { get; set; }
}


public class BotInfo
{
    public string Name { get; init; } = default!;
    public string Route { get; init; } = default!;
    public string SecretToken { get; init; } = default!;
    public string BotToken { get; set; } = string.Empty;
    public string HostAddress { get; set; } = string.Empty;
}