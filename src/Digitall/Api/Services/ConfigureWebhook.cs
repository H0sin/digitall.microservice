using Application.Helper;
using Microsoft.Extensions.Options;
using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.Services;

public class ConfigureWebhook(
    ILogger<ConfigureWebhook> logger,
    IServiceProvider serviceProvider,
    IOptions<BotConfiguration> botOptions) : IHostedService
{
    private readonly ILogger<ConfigureWebhook> _logger = logger;
    private readonly IServiceProvider _serviceProvider = serviceProvider;
    private readonly BotConfiguration _botConfig = botOptions.Value;

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        //Thread.Sleep(1000);
        //using var scope = _serviceProvider.CreateScope();
        //var botClient = scope.ServiceProvider.GetRequiredService<ITelegramBotClient>();
        //var webhookAddress = $"{botClient.HostAddress}{botClient.Route}";
        //_logger.LogInformation("Setting webhook: {WebhookAddress}", webhookAddress);
        //await botClient.SetWebhookAsync(
        //    url: webhookAddress,
        //    allowedUpdates: Array.Empty<UpdateType>(),
        //    secretToken: botClient.SecretToken,
        //    cancellationToken: cancellationToken);

    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        using var scope = _serviceProvider.CreateScope();
        var botClient = scope.ServiceProvider.GetRequiredService<ITelegramBotClient>();

        // Remove webhook on app shutdown
        _logger.LogInformation("Removing webhook");
        await botClient.DeleteWebhookAsync(cancellationToken: cancellationToken);
    }
}
