using Domain.Common;

namespace Domain.Entities.Telegram;

public class TelegramTopic : BaseEntity
{
    public string? Name { get; set; }
    public string? TelegramTopicCategory { get; set; }
    public ICollection<TelegramGroupTopics>? TelegramGroupTopics { get; set; }
    public string? IconCustomEmojiId { get; set; }
}