using Telegram.Bot;
using Telegram.Bot.Types;

namespace Application.Services.Interface.Telegram;

public interface IBotService
{
    /// <summary>
    ///  send user information for login to web
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendUserForLoginToWebAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);
    /// <summary>
    /// start bot
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> StartLinkAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// send main menu for users
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendMainMenuAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,string? title = null);

    /// <summary>
    /// send list exist vpn
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendListVpnsAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list vpns hase test
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendListVpnsHaveTestAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send test subscibe
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendTestSubscibeAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send exists template for vpns
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendListVpnsTemplateAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send befor buy vpn factor
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendFactorVpnAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// create and send subscribetion
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendSubscriptionAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list my services
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendListServicesAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send subscibe information for user
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendSubscribeInformationAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send subscibe configs async
    /// </summary>
    /// <param name="telegramBotClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendConfigsAsync(ITelegramBotClient? telegramBotClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send subscibetion asunc
    /// </summary>
    /// <param name="telegramBotClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendSubscribeAsync(ITelegramBotClient? telegramBotClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send vpn gb price async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendGbPriceAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send vpn days price async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendDaysPriceAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// after send days send factor
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendCustomFactorVpnAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// send user information for walet
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendUserInformationAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send transaction deatail
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendTransactionDetailsAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// sned card number for user 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendCardNumberAndDetailAsync(ITelegramBotClient? botClient, Message? message, CancellationToken cancellationToken);

    
    /// <summary>
    /// affter wating for transaction images
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task WatingForTransactionImageAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// after added image complate transaction
    /// </summary>
    /// <returns></returns>
    Task AddTrnasactionAsync(ITelegramBotClient? botClient, Message? message, CancellationToken cancellationToken);
    
    //
    // /// <summary>
    // /// update subscribe
    // /// </summary>
    // /// <param name="botClient"></param>
    // /// <param name="callbackQuery"></param>
    // /// <param name="cancellationToken"></param>
    // /// <returns></returns>
    // Task SubscribeExtension(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
    //     CancellationToken cancellationToken);
}