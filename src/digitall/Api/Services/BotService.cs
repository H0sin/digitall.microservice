
using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using Application.Factory;
using Application.Services.Interface.Telegram;
using Domain.DTOs.Telegram;

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

         List<TelegramBotDto>? bots = await telegramService.GetAllTelegramBotAsync();
        
         for (int i = 0; i < bots.Count; i++)
         {
             await StartBotAsync(bots[i], cancellationToken);
         }
         
    }

    private async Task StartBotAsync(TelegramBotDto bot, CancellationToken cancellationToken)
    {
        try
        {
            Thread.Sleep(500);

            ITelegramBotClient botClient = botClientFactory.GetOrAdd(bot?.Token!);

            var webhookAddress = $"{bot?.HostAddress}{bot?.Route}";
            logger.LogInformation("Setting webhook for bot {BotName}: {WebhookAddress}", bot.Name, webhookAddress);

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



