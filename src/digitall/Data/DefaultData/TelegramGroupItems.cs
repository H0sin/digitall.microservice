using Domain.Entities.Telegram;

namespace Data.DefaultData;

public static class TelegramGroupItems
{
    public static List<TelegramGroup> TelegramGroups = new()
    {
        new()
        {
            Name = "مستر گروه",
            TelegramBotId = 1,
            Id = 1,
            ChatId = -1002449260173,
        }
    };
}