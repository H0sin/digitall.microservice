using Domain.Entities.Telegram;
using Telegram.Bot;

namespace Application.Factory;

public class TelegramBotClientFactory
{
    /// <summary>
    /// list bot clients
    /// </summary>
    private static Dictionary<string, TelegramBotClient> _botClients = new();

    private static List<TelegramBot> _telegramClient = new();

    public TelegramBot? Get(long botId)
    {
        TelegramBot? telegramBot = _telegramClient.SingleOrDefault(x => x.BotId == botId);
        return telegramBot;
    }

    public void Add(TelegramBot telegramBot)
    {
        _telegramClient.Add(telegramBot);
    }

    public void AddRange(List<TelegramBot> telegramBots)
    {
        _telegramClient.AddRange(telegramBots);
    }

    public TelegramBotClient GetOrAdd(string token)
    {
        TelegramBotClient? botClient = _botClients
            .SingleOrDefault(x => x.Key == token).Value;

        if (botClient is not null)
            return botClient;

        _botClients.Add(token, new TelegramBotClient(token));

        return _botClients
            .SingleOrDefault(x => x.Key == token).Value;
    }
}