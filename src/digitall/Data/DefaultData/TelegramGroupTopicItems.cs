using Domain.Entities.Telegram;

namespace Data.DefaultData;

public static class TelegramGroupTopicItems
{
    public static List<TelegramGroupTopics> TelegramGroupTopics = new()
    {
        new TelegramGroupTopics()
        {
            Id = 1,
            TelegramGroupId = 1,
            TelegramTopicId = 1,
        },
        new TelegramGroupTopics()
        {
            Id = 2,
            TelegramGroupId = 1,
            TelegramTopicId = 2,
        },
        new TelegramGroupTopics()
        {
            Id = 3,
            TelegramGroupId = 1,
            TelegramTopicId = 3,
        },
        new TelegramGroupTopics()
        {
            Id = 4,
            TelegramGroupId = 1,
            TelegramTopicId = 4,
        },
        new TelegramGroupTopics()
        {
            Id = 5,
            TelegramGroupId = 1,
            TelegramTopicId = 5,
        },
        new TelegramGroupTopics()
        {
            Id = 6,
            TelegramGroupId = 1,
            TelegramTopicId = 6,
        },
        new TelegramGroupTopics()
        {
            Id = 7,
            TelegramGroupId=1,
            TelegramTopicId = 7
        }
    };
}