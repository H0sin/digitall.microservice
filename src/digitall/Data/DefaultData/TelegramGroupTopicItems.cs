using Domain.Entities.Telegram;

namespace Data.DefaultData;

public static class TelegramGroupTopicItems
{
    public static List<TelegramGroupTopics> TelegramGroupTopics = new()
    {
        new TelegramGroupTopics()
        {
            Id=1,
            TelegramGroupId = 1,
            TelegramTopicId = 1,
        }
    };
}