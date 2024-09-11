using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Web;
using Api.Filters;
using Application.Extensions;
using Application.Factory;
using Application.Helper;
using Application.Services.Interface.Notification;
using Application.Services.Interface.Telegram;
using Application.Sessions;
using Application.Utilities;
using Domain.DTOs.Transaction;
using Domain.Enums.Transaction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using User = Domain.Entities.Account.User;

namespace Api.Controllers.Telegram;

/// <summary>
/// web hock for telegram bot
/// </summary>
/// <param name="serviceProvider"></param>
/// <param name="telegramService"></param>
/// <param name="botClientFactory"></param>
/// <param name="memoryCache"></param>
[ServiceFilter(typeof(ExceptionHandler))]
public class BotHookController(
    IServiceProvider serviceProvider,
    ITelegramService telegramService,
    TelegramBotClientFactory botClientFactory,
    IMemoryCache memoryCache,
    INotificationService notificationService
) : ControllerBase
{
    private TelegramBotClient? _botClient;
    private string? _token;

    /// <summary>
    /// post method for web hook
    /// </summary>
    /// <param name="token"></param>
    /// <param name="update"></param>
    /// <param name="cancellationToken"></param>
    [HttpPost("{token}")]
    public async Task Post(string token,
        [FromBody] Update update,
        CancellationToken cancellationToken)

    {
        try
        {
            _token = token;
            _botClient = botClientFactory.GetOrAdd(token);

            await HandleUpdateAsync(update, new CancellationToken());
            await Task.CompletedTask;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    /// <summary>
    /// update
    /// </summary>
    /// <param name="update"></param>
    /// <param name="cancellationToken"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public async Task HandleUpdateAsync(Update update,
        CancellationToken cancellationToken)

    {
        await Task.Delay(TimeSpan.FromMilliseconds(300.100), cancellationToken);

        var handler = update switch
        {
            { Message: { } message } => BotOnMessageReceived
                .Action(
                    message,
                    _botClient!,
                    memoryCache!,
                    telegramService,
                    notificationService,
                    cancellationToken
                ),
            { EditedMessage : { } message } => BotOnMessageReceived
                .Action(
                    message,
                    _botClient!,
                    memoryCache!,
                    telegramService,
                    notificationService,
                    cancellationToken
                ),
            { CallbackQuery: { } callbackQuery } => BotOnCallbackQueryReceived
                .Action(
                    telegramService,
                    _botClient!,
                    callbackQuery,
                    memoryCache!,
                    notificationService,
                    cancellationToken
                ),
            _ => throw new ArgumentOutOfRangeException(nameof(update), update, null)
        };

        await handler;
    }
}