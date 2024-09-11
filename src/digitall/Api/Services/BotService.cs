using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using Application.Factory;
using Application.Services.Interface.Telegram;
using Domain.DTOs.Telegram;
using Domain.Entities.Telegram;
using Telegram.Bot.Types;

namespace Api.Services;

public class BotService(
    IServiceProvider serviceProvider,
    ILogger<BotService> logger,
    TelegramBotClientFactory botClientFactory)
{
    public async Task StartAllBotsAsync(CancellationToken cancellationToken)
    {
        await using var scope = serviceProvider.CreateAsyncScope();

        ITelegramService telegramService = scope
            .ServiceProvider.GetRequiredService<ITelegramService>();

        List<TelegramBot>? bots = await telegramService.GetAllTelegramBotAsync();

        botClientFactory.AddRange(bots);

        for (int i = 0; i < bots.Count; i++)
        {
            if (!bots[i].IsDelete)
                await StartBotAsync(bots[i], cancellationToken, telegramService);
        }
    }

    private async Task StartBotAsync(TelegramBot bot, CancellationToken cancellationToken,
        ITelegramService telegramService)
    {
        try
        {
            Thread.Sleep(500);

            ITelegramBotClient botClient = botClientFactory.GetOrAdd(bot?.Token!);

            var webhookAddress = $"{bot?.HostAddress}{bot?.Route}";
            logger.LogInformation("Setting webhook for bot {BotName}: {WebhookAddress}", bot.Name, webhookAddress);

            foreach (TelegramGroupTopics telegramGroupTopic in bot?.TelegramGroup?.TelegramGroupTopics ??
                                                               new List<TelegramGroupTopics>())
            {
                if (!telegramGroupTopic.Created)
                {
                    TelegramTopic? topic = telegramGroupTopic.TelegramTopic;
                    TelegramGroup? group = telegramGroupTopic.TelegramGroup;

                    logger.LogInformation("Setting topic for bot {BotName}: {topic}", bot.Name, topic?.Name);

                    long chatId = group.ChatId;

                    var createdtopic = await botClient.CreateForumTopicAsync(
                        chatId: chatId,
                        name: topic.Name,
                        iconCustomEmojiId: topic.IconCustomEmojiId,
                        cancellationToken: CancellationToken.None
                    );

                    telegramGroupTopic.Created = true;
                    telegramGroupTopic.MessageThreadId = createdtopic.MessageThreadId;
                    await telegramService.UpdateCreatedTopicAsync(telegramGroupTopic);
                }
            }

            await botClient.SetWebhookAsync(
                url: webhookAddress,
                allowedUpdates: Array.Empty<UpdateType>(),
                secretToken: bot.SecretToken,
                cancellationToken: cancellationToken);
        }
        catch (Exception e)
        {
            // throw new AppException($"ربات  {bot.Name}استارت نشد");
        }
    }
}