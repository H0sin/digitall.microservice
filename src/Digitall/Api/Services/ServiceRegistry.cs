using Telegram.Bot;

namespace Api.Services;
public class ServiceRegistry
{
    private readonly Dictionary<string, ITelegramBotClient> _services = new();

    public void Register(string key, ITelegramBotClient service)
    {
        _services[key] = service;
    }

    public ITelegramBotClient GetService(string key)
    {
        return _services.TryGetValue(key, out var service) ? service : null;
    }
}

