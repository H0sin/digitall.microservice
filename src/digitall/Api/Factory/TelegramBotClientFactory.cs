using Telegram.Bot;

namespace Api.Factory;

public class TelegramBotClientFactory
{
    public ITelegramBotClient Create(string token)
    {
        return new TelegramBotClient(token);
    }
}