using Domain.Common;

namespace Domain.Entities.Telegram;

public class TelegramGroupTopics : BaseEntity
{
    public long? TelegramGroupId { get; set; }
    public TelegramGroup? TelegramGroup { get; set; }

    public long? TelegramTopicId { get; set; }
    public TelegramTopic? TelegramTopic { get; set; }
    
    public bool Created { get; set; } = false;

    public int? MessageThreadId { get; set; }  
}