using Domain.Entities.Telegram;

namespace Data.DefaultData;

public static class TelegramTopicItems
{
    public static List<TelegramTopic> TelegramTopics = new()
    {
        new TelegramTopic()
        {
            Name = "استارت ربات 🔧",
            TelegramTopicCategory = "StartReports",
            Id = 1,
            IconCustomEmojiId = "🔧",
        },
        new TelegramTopic()
        {
            Name = "گزارشات مالی 💰",
            TelegramTopicCategory = "FinancialReports",
            Id = 2,
            IconCustomEmojiId = "💰",
        },
        new TelegramTopic()
        {
            Name = "گزارشات باگ 🐞",
            TelegramTopicCategory = "BogsReports",
            Id = 3,
            IconCustomEmojiId = "🐞",
        },
        new TelegramTopic()
        {
            Name = "گزارشات خرید 🛒",
            TelegramTopicCategory = "BuyReports",
            Id = 4,
            IconCustomEmojiId = "🛒",
        },
        new TelegramTopic()
        {
            Name = "گزارشات تمدید 🔄",
            TelegramTopicCategory = "RenewReports",
            Id = 5,
            IconCustomEmojiId = "🔄",
        },
        new TelegramTopic()
        {
            Name = "گزارشات پرداخت 💳",
            TelegramTopicCategory = "PaymentReports",
            Id = 6,
            IconCustomEmojiId = "💳", // Example Emoji ID for Payment Reports
        },
        new TelegramTopic()
        {
            Name = "گزارشات حذفی ها ❌",
            TelegramTopicCategory = "DeletedReports",
            Id = 7,
            IconCustomEmojiId = "❌",
        },
    };
}