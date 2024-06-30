using Application.Helper;
using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using Api.Factory;

namespace Api.Services;

public class BotService(
    IServiceProvider serviceProvider,
    ILogger<BotService> logger,
    IConfiguration configuration,
    TelegramBotClientFactory botClientFactory)
{
    private readonly List<BotConfiguration> _botConfigurations = configuration.GetSection("Bots").Get<List<BotConfiguration>>();
    private readonly TelegramBotClientFactory _botClientFactory = botClientFactory;

    public async Task StartAllBotsAsync(CancellationToken cancellationToken)
    {
        foreach (var bot in _botConfigurations)
        {
            await StartBotAsync(bot, cancellationToken);
        }
    }

    private async Task StartBotAsync(BotConfiguration bot, CancellationToken cancellationToken)
    {
        Thread.Sleep(500);  // Optional: برای اینکه به هر بات زمان بدهیم

        using var scope = serviceProvider.CreateScope();
        var botClient = botClientFactory.Create(bot.Token); // Create a new instance with the bot's token

        var webhookAddress = $"{bot.HostAddress}{bot.Route}";
        logger.LogInformation("Setting webhook for bot {BotName}: {WebhookAddress}", bot.Name, webhookAddress);

        await botClient.SetWebhookAsync(
            url: webhookAddress,
            allowedUpdates: Array.Empty<UpdateType>(),
            secretToken: bot.SecretToken,
            cancellationToken: cancellationToken);
    }
}



