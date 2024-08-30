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
        CancellationToken cancellationToken, string? title = null);

    /// <summary>
    /// send main menu for users
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> SendMainMenuAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken, string? title = null);

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
    Task SendCardNumberAndDetailAsync(ITelegramBotClient? botClient, Message? message,
        CancellationToken cancellationToken);


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
    Task AddTransactionAsync(ITelegramBotClient? botClient, Message? message, CancellationToken cancellationToken);

    /// <summary>
    /// send factor for append gb for service
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendFactorAppendGbAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);


    /// <summary>
    /// send factor for append days for service
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendFactorAppendDaysAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);


    /// <summary>
    /// accept after show factor for buy gb append
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task AcceptAppendGbAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// accept after show factor for buy days append
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task AcceptAppendDaysAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send days price
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendDaysPriceForAppendDaysAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// actived marzban user 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task ActiveMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// disabled marzban user 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DisabledMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send request for agent
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task RequestForAgentAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// delete service
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// when change link subscrive
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task RevokeSubscribeAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send link start by agent code
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendTelegramInviteLinkAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// if user is agent send agent option menu 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="chatId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendAgentMenuForAdmin(ITelegramBotClient botClient, long chatId, CancellationToken cancellationToken);

    /// <summary>
    /// send list button for agent for chane items
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"> </param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> SendAgentInformationMenuAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// edite agent card information
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> EditeAgentCardNumberInformationAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// send card holder name
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> EditeAgentCardHolderNameInformationAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// send agent transaction payment async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> SendAgentTransactionPaymentDetailAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// send agent information async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> SendAgentInformationAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// update child agent percent 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> UpdateAgentPercentAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// update agent user percent 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> UpdateUserPercentAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// update Persion and english brandName
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> UpdateAgentPersionBrandNameAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// accept agent request async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task AcceptAgentRequestAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// reject agent request async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task RejectAgentRequestAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// change state card to card 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task ChangeStateCardToCard(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// management user
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="userId"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task ManagementUserAsync(ITelegramBotClient botClient, long chatId, long userId,
        CancellationToken cancellationToken);

    /// <summary>
    /// increase user by agent 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task IncreaseUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// decrease user by agent 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DecreaseUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send user management by chat id
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> SearchUserByChatAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// update transaction status
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateTransactionStatusAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// block user async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task BlockUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// on blocked user
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task OnBlockUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// change payment
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> ChangeAgentPaymentOptionAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// change user payment
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> ChangeUserPaymentOptionAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list agent by filter
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> SendListAgentsAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);

    /// <summary>
    /// send agent information async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendChildAgentInformation(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send message befor update agent percent
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendMessageForUpdateSpecialPercent(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);


    /// <summary>
    /// send message for agnet
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendTicketMenuAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send static text default question
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendDefaultQuestionAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);


    /// <summary>
    /// send ticket grouping async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendTicketGroupingAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);
    
    /// <summary>
    /// send ticket for agent async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> SendTicketAsync(ITelegramBotClient? botClient, Message message,
        CancellationToken cancellationToken);
}