using Domain.DTOs.Agent;
using Domain.DTOs.Telegram;
using Domain.Entities.Telegram;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramUser = Domain.Entities.Telegram.TelegramUser;
using User = Domain.Entities.Account.User;


namespace Application.Services.Interface.Telegram;

public interface ITelegramService
{
    /// <summary>
    /// show wireguard service information
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task ShowPeerInformation(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list my products
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendListMyProductsAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send product list
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendProductListAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send product
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendProductTemplatesAsync(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list wireguard templates
    /// vpn by vpn id in callbackQuery get
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendListWireguardVpnTemplateAsync(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list wireguard templates price
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendWireguardVpnGbAndPriceAsync(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send wireguard factor
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendWireguardServiceFactorVpnAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser);

    /// <summary>
    /// send wireguard subscriber
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendWireguardSubscriptionAsync(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send list product have test
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendListProductHaveTestAsync(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send product have test
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendProductTemplatesHaveTestAsync(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list wireguard account test
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendWireguardAccountTest(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// added user if not exist
    /// </summary>
    /// <param name="botId"></param>
    /// <param name="message"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<AgentDto?> CreateUserAfterStartedBot(long botId, Message message, User? user);

    /// <summary>
    /// get user by chatId
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<User?> GetUserByChatIdAsync(long chatId);

    /// <summary>
    /// start bot async
    /// </summary>
    /// <returns></returns>
    Task<Message> StartedTelegramBotAsync(ITelegramBotClient botClient, Message message,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send main menui async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendMainMenuAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// add telegram bot summery
    /// </summary>
    /// <param name="bot"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<AddTelegramBotDto> AddTelegramBotAsync(AddTelegramBotDto bot, long userId);

    /// <summary>
    /// stop telegram bot async
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task StopTelegramBotAsync(long id);

    /// <summary>
    /// stop telegram bot async
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task StartTelegramBotAsync(long id);

    /// <summary>
    /// get all bot for started
    /// </summary>
    /// <returns></returns>
    Task<List<TelegramBot>?> GetAllTelegramBotAsync();

    /// <summary>
    /// get telegramBot by bot Id
    /// </summary>
    /// <param name="botId"></param>
    /// <returns></returns>
    Task<TelegramBotDto> GetTelegramBotByBotIdAsync(long botId);

    /// <summary>
    /// send list vpns hase test
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendListVpnHaveTestAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);


    /// <summary>
    /// send list vpn
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendListVpnAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list vpn
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendListVpnTemplateAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list vpn gb and price
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendVpnGbAndPriceAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send factor async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    Task SendFactorVpnAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser user);

    /// <summary>
    /// send subscribe test async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendSubscriptionTestAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send config after buy
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    Task SendSubscriptionAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser user);

    /// <summary>
    /// send list service
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="username"></param>
    /// <returns></returns>
    Task SendListServicesAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, string? username = null);

    /// <summary>
    /// send sub service
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    Task SendSubscribeInformationAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser user);

    /// <summary>
    /// send subscribe config async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendConfigsAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send subscription async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendSubscriptionLinkAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// filter by name service
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task GiveServiceNameForFilterAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// when change link subscription
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task RevokesubscriptionAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// delete service
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextDeleteMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);


    /// <summary>
    /// delete marzban user
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task DeleteMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// delete service by agent
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeletedMarzbanUserServiceByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// not delete service by agent
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task NotDeleteMarzbanUserServiceByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// active marzban user 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task ActiveMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// disabled marzban user 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task DisabledMarzbanUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send supporting menu
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendSupportingMenuAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
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
    /// send text message
    /// </summary>
    /// <returns></returns>
    Task SendTextForSendMessageSupporting(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send message for agent for supporting
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendMessageForSupporting(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send user information for wallet
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendUserInformationAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send transaction detail
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTransactionDetailsAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send card number for user 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendCardNumberAndDetailAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// after transaction images
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task GiveTransactionImageAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// after added image complete transaction
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task AddTransactionAsync(ITelegramBotClient? botClient, CallbackQuery? callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser);

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
    /// send text for agent request
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextAgentRequest(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send text
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendDescriptionTextForAddedAgent(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// request for agent
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task RequestForAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// accept agent request async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task AcceptAgentRequestAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// reject agent request async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task RejectAgentRequestAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

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
    /// send list transactions
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTransactionsAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send user transactions
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendUserTransactionsAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

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
    /// agency management
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendMenuAgencyManagementAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send agent management
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Message> AgencyManagementAsync(ITelegramBotClient botClient, Message message,
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
    /// management user
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task ManagementUserAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);


    /// <summary>
    /// increase user by agent 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task IncreaseUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send text for description increase
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task GiveDescriptionForIncreaseTransactionAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// increase user balance
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>\
    Task IncreaseUserBalanceAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// decrease user by agent 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task DecreaseUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send text for description increase
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task GiveDescriptionForDecreaseTransactionAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// increase user balance
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>\
    Task DecreaseUserBalanceAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// on blocked user
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task BlockUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken,
        TelegramUser telegramUser);

    /// <summary>
    /// on blocked user
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task OnBlockUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextGiveMessageForUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser telegramUser);

    /// <summary>
    /// send message
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendMessageForUserByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// change card to card async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task ChangeStateCardToCardAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send message befor update agent percent
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextForGiveSpecialPercent(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// update agent percent
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task UpdateAgentSpecialPercentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// update Persion and english brandName
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task UpdateAgentBrandingNameAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send engilish brand name
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextEngilishBrandNameAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// set brand name
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SetBrandingNameAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// edite agent card information
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextForUpdateAgentCardDetailInformationAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// set card number by agent async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SetCardNumberAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// update anget card information
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task UpdateAgentCardDetailAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send agent transaction payment async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendAgentTransactionPaymentDetailAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);


    /// <summary>
    /// update agent percent
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextUpdateAgentPercentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// update agent user percent 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextUpdateUserPercentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// update agent percent
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task UpdateAgentPercentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// update agent user percent 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task UpdateUserPercentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// update agnet payment
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextUpdatePaymentForAgentOptionAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// give maximum text
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task GiveMaximumPaymentForAgent(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// set
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SetPaymentOptionForAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// update user payment
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextUpdatePaymentForUserOptionAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// give maximum text
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task GiveMaximumPaymentForUser(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// set
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SetPaymentOptionForUserAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send agent information async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendAgentInformationAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send user management by chat id
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextSearchUserByChatAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// added agent async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task AddAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);


    /// <summary>
    /// send message before
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendMenuForSendMessageByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// selected user grouping
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendMenuForSelectedUserGroupingByAgentAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send buttons for selected send message
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SubmitListingsButtonsAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// forward message async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task ForwardMessageForUserAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// send list buttons
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendListButtonsForSendMessage(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser? telegramUser);

    /// <summary>
    /// send message
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendMessageAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken,
        TelegramUser? telegramUser);

    /// <summary>
    /// after created topic updated
    /// </summary>
    /// <param name="telegramGroupTopic"></param>
    Task UpdateCreatedTopicAsync(TelegramGroupTopics telegramGroupTopic);

    /// <summary>
    /// send list transaction services
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendTransactionsWaitingQueAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list deleted service in que
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendDeletedServiceInQueAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list my products
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendMyProductsAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send list wireguard services async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    Task SendListWireguardServicesAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, string? name = null);

    /// <summary>
    /// get wireguard services name for filter async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task GiveWireguardServiceNameForFilterAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser? telegramUser);

    /// <summary>
    /// send file peer async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendPeerConfigFileAsync(TelegramBotClient botClient, CallbackQuery? callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// send peer qr async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendPeerQrAsync(TelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken);


    /// <summary>
    /// send delete wireguard account async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextDeleteWireguardAccountAsync(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);


    /// <summary>
    /// delete wireguard account async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task DeleteWireguardAccountAsync(ITelegramBotClient? botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);


    /// <summary>
    /// delete main wireguard account async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task MainDeleteWireguardAccountAsync(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// not delete wireguard account async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task NotDeleteWireguardAccountAsync(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// active wireguard services async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task ActiveWireguardAccountAsync(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// disabled wireguard services async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DisabledWireguardAccountAsync(TelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// request for wireguard services async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task RequestForSpecialBotAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    
    /// <summary>
    /// active telegram bot async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task ActiveTelegramBotAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task ChangeAgentAmountNegative(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken,TelegramUser telegramUser);

    /// <summary>
    /// send factor apple id 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendFactorAppleIdAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken);

    /// <summary>
    /// buy apple id
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task BuyAppleIdAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken,TelegramUser telegramUser);

    /// <summary>
    /// filter list apple id
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendListAppleIdServiceAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery,
        CancellationToken cancellationToken);

    /// <summary>
    /// search apple id by email
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendTextForSearchAppleIdAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken,TelegramUser telegramUser);

    /// <summary>
    /// send appleId information async
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="telegramUser"></param>
    /// <returns></returns>
    Task SendAppleIdInformationAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken, TelegramUser telegramUser);

    /// <summary>
    /// appleid warranty
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task AppleIdWarrantyAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken);

    /// <summary>
    /// fixed for warantty
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendAppleIdForWarrantyAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken);

    
    /// <summary>
    /// assign to me appleid for warranty
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task AssignToMeAppleIdAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task WrongAppleIdInformationAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken);

    /// <summary>
    /// reject 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task RejectWarrantyRequestBecauseTrueAppleIdAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken);
    
    /// <summary>
    /// reject
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task RejectWarrantyRequestBecauseChangeAppleIdAsync(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="botClient"></param>
    /// <param name="callbackQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task AcceptWarrantyAsync(TelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken);
}