
using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using Application.Factory;
using Application.Services.Interface.Telegram;
using Domain.DTOs.Telegram;
using Domain.Entities.Telegram;

namespace Api.Services;

public class BotService(
    IServiceProvider serviceProvider,
    ILogger<BotService> logger,
    TelegramBotClientFactory botClientFactory)
{
    public async Task StartAllBotsAsync(CancellationToken cancellationToken)
    {
        await using var scope = serviceProvider.CreateAsyncScope();

        ITelegramService telegramService =  scope
            .ServiceProvider.GetRequiredService<ITelegramService>();

         List<TelegramBot>? bots = await telegramService.GetAllTelegramBotAsync();
        
         for (int i = 0; i < bots.Count; i++)
         {
             if(!bots[i].IsDelete)
                await StartBotAsync(bots[i], cancellationToken);
         }
         
    }

    private async Task StartBotAsync(TelegramBot bot, CancellationToken cancellationToken)
    {
        try
        {
            Thread.Sleep(500);

            ITelegramBotClient botClient = botClientFactory.GetOrAdd(bot?.Token!);

            var webhookAddress = $"{bot?.HostAddress}{bot?.Route}";
            logger.LogInformation("Setting webhook for bot {BotName}: {WebhookAddress}", bot.Name, webhookAddress);
            
            // foreach (TelegramGroupTopics telegramGroupTopic in bots[i]?.TelegramGroup?.TelegramGroupTopics ?? new List<TelegramGroupTopics>())
            // {
            //     TelegramTopic? topic = telegramGroupTopic.TelegramTopic;
            //     TelegramGroup? group = telegramGroupTopic.TelegramGroup;
            //     
            //     logger.LogInformation("Setting topic for bot {BotName}: {topic}", bot.Name, topic?.Name);
            //
            //     long chatId = group.ChatId;
            //     
            //                      
            //     var createdtopic = await botClient.CreateForumTopicAsync(
            //         chatId: chatId,
            //         name: "",
            //         iconCustomEmojiId: null,
            //         cancellationToken: CancellationToken.None
            //     );
            //     
            //     await botClient.SendTextMessageAsync(chatId, "فثسف",replyToMessageId:topic.MessageThreadId, cancellationToken: cancellationToken);
            //     // await handler;
            // }
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



