using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Web;
using Api.Filters;
using Application.Extensions;
using Application.Helper;
using Application.Services.Interface.Telegram;
using Application.Sessions;
using Application.Utilities;
using Domain.DTOs.Marzban;
using Domain.DTOs.Telegram;
using Domain.Entities.Marzban;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Api.Controllers.Telegram;

[ServiceFilter(typeof(ExceptionHandler))]
public class BotHookController(
    IServiceProvider serviceProvider,
    IBotService botService,
    ITelegramService telegramService
) : ControllerBase
{
    private ITelegramBotClient? _botClient;

    [HttpPost("{botName}")]
    public async Task<IActionResult> Post(string botName,
        [FromBody] Update update,
        CancellationToken cancellationToken)
    {
        string? token = await telegramService.GetTelegramBotAsyncByName(botName);
        if (token == null)
        {
            return NotFound();
        }

        _botClient = new TelegramBotClient(token);

        await HandleUpdateAsync(update, new CancellationToken());

        return Ok();
    }

    public async Task HandleUpdateAsync(Update update,
        CancellationToken cancellationToken)
    {
        var handler = update switch
        {
            { Message: { } message } => BotOnMessageReceived(message, cancellationToken),
            { EditedMessage: { } message } => BotOnMessageReceived(message, cancellationToken),
            { CallbackQuery: { } callbackQuery } => BotOnCallbackQueryReceived(callbackQuery,
                cancellationToken)
        };

        await handler;
    }

    private async Task BotOnMessageReceived(Message message,
        CancellationToken cancellationToken)
    {
        if (message.Photo is not { } photo & message.Text is not { } messageText)
            return;

        KeyValuePair<long, TelegramMarzbanVpnSession>? user = BotSessions.users_Sessions!
            .SingleOrDefault(x => x.Key == message.Chat.Id);

        if (user.Value.Value is not null)
        {
            switch (user.Value.Value.State)
            {
                case TelegramMarzbanVpnSessionState.AwaitingGb:
                    int gb = 0;
                    Int32.TryParse(message?.Text, out gb);
                    user.Value.Value.Gb = gb;
                    BotSessions
                        .users_Sessions?
                        .AddOrUpdate(message.Chat.Id,
                            user.Value.Value, (key, old) => old = user.Value.Value);

                    await botService.SendDaysPriceAsync(_botClient, message, cancellationToken);
                    break;

                case TelegramMarzbanVpnSessionState.AwaitingDate:
                    int date = 0;
                    Int32.TryParse(message?.Text, out date);
                    user.Value.Value.Date = date;
                    BotSessions
                        .users_Sessions?
                        .AddOrUpdate(message.Chat.Id,
                            user.Value.Value, (key, old) => old = user.Value.Value);

                    await botService.SendCustomFactorVpnAsync(_botClient, message, cancellationToken);
                    break;
                case TelegramMarzbanVpnSessionState.AwatingSendPrice:
                    int price = 0;
                    Int32.TryParse(message?.Text, out price);
                    user.Value.Value.Price = price;

                    BotSessions
                        .users_Sessions?
                        .AddOrUpdate(message.Chat.Id,
                            user.Value.Value, (key, old) => old = user.Value.Value);

                    await botService.SendCardNumberAndDetailAsync(_botClient, message, cancellationToken);
                    break;
                case TelegramMarzbanVpnSessionState.AwaitingSendTransactionImage:
                    await botService.AddTrnasactionAsync(_botClient, message, cancellationToken);
                    break;
            }
        }

        var action = message?.Text?.Split(' ')[0] switch
        {
            "/start" => await botService.StartLinkAsync(_botClient, message, cancellationToken),
        };

        Message sentMessage = action;
    }

    private async Task BotOnCallbackQueryReceived(CallbackQuery callbackQuery,
        CancellationToken cancellationToken)
    {
        string data = callbackQuery.Data.Split('?')[0];

        switch (data)
        {
            case "subscribe":
                await botService.SendListVpnsAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "test_free":
                await botService.SendListVpnsHaveTestAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "back_to_main":
                await botService.SendMainMenuAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "vpn_template":
                await botService.SendListVpnsTemplateAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "factor_subscribe":
                await botService.SendFactorVpnAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "buy_subscribe":
                await botService.SendSubscriptionAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "custom_subscribe":
                await botService.SendGbPriceAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "my_services":
                await botService.SendListServicesAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "subscribe_info":
                await botService.SendSubscribeInformationAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "createtestsub":
                await botService.SendTestSubscibeAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "subscription_link":
                await botService.SendSubscribeAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "get_traffic":
                await botService.SendConfigsAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "wallet":
                await botService.SendUserInformationAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "inventory_increase":
                await botService.SendTransactionDetailsAsync(_botClient, callbackQuery, cancellationToken);
                break;
            case "send_transaction_image":
                await botService.WatingForTransactionImageAsync(_botClient, callbackQuery, cancellationToken);
                break;
            default:
                break;
        }
    }
}