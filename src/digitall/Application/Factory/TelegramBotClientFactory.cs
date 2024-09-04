using Telegram.Bot;

namespace Application.Factory;

public class TelegramBotClientFactory
{
    /// <summary>
    /// list bot clients
    /// </summary>
    private static Dictionary<string, TelegramBotClient> _botClients = new();

    public ITelegramBotClient GetOrAdd(string token)
    {
        TelegramBotClient? botClient = _botClients.SingleOrDefault(x => x.Key == token).Value;
        if (botClient is not null)
            return botClient;
        return new TelegramBotClient(token);
    }
}