using Domain.Entities.Telegram;

namespace Data.DefaultData;

public static class TelegramTopicItems
{
    public static List<TelegramTopic> TelegramTopics = new()
    {
        new TelegramTopic()
        {
            Name = "استارت ربات",
            TelegramTopicCategory = "start",
            Id = 1,
        }
    };
}