using Application.Sessions;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Marzban;
using Domain.DTOs.Telegram;
using Domain.DTOs.Transaction;
using Domain.Entities.Account;
using Domain.Entities.Agent;
using Domain.Entities.Marzban;
using Domain.Enums.Agent;
using Domain.Enums.Marzban;

namespace Application.Services.Interface.Telegram;

public interface ITelegramService
{
    /// <summary>
    /// add telegram bot summery
    /// </summary>
    /// <param name="bot"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<AddTelegramBotDto> AddTelegramBotAsync(AddTelegramBotDto bot, long userId);

    /// <summary>
    /// get all bot for started
    /// </summary>
    /// <returns></returns>
    Task<List<TelegramBotDto>?> GetAllTelegramBotAsync();

    /// <summary>
    /// get telegram bot by name async
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    Task<string?> GetTelegramBotAsyncByName(string name);

    /// <summary>
    /// for get agent by telegram token
    /// </summary>
    /// <param name="token"></param>
    /// <returns></returns>
    Task<AgentDto?> GetAgentByTelegramToken(string token);

    /// <summary>
    /// get user by chat id
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<User?> GetUserByChatIdAsync(long chatId);

    /// <summary>
    /// get list vpn have test account
    /// </summary>
    /// <returns></returns>
    Task<List<MarzbanVpnTestDto>> GetListMarzbanVpnTestAsync();

    /// <summary>
    /// get list vpn have test account
    /// </summary>
    /// <returns>MarzbanUserInformationDto</returns>
    Task<List<MarzbanVpnBotDto>> GetMarzbanVpnsAsync();


    /// <summary>
    /// generate test file and send 
    /// </summary>
    /// <param name="vpnId">for create user in vpn</param>
    /// <param name="chatId">for get user</param>
    /// <returns>MarzbanUserInformationDto</returns>
    Task<MarzbanUserInformationDto> GetMarzbanTestVpnsAsync(long vpnId, long chatId);

    /// <summary>
    /// get marzban vpm by vpnid
    /// </summary>
    /// <param name="vpnId"></param>
    /// <returns></returns>
    Task<MarzbanVpnDto?> GetMarzbanVpnInformationByIdAsync(long vpnId, long chatId);

    /// <summary>
    /// get marzban template by vpn id
    /// </summary>
    /// <param name="vpnId"></param>
    /// <returns></returns>
    Task<List<MarzbanVpnTemplateDto>>
        GetMarzbanVpnTemplatesByVpnIdAsync(long vpnId, long chatId);

    /// <summary>
    /// buy marzban vpn
    /// </summary>
    /// <param name="buy"></param>
    /// <returns></returns>
    Task<List<MarzbanUser>> BuySubscribeAsync(BuyMarzbanVpnDto buy, long chatId);

    /// <summary>
    /// befor buy vpn send pish factor
    /// </summary>
    /// <param name="buy"></param>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<SubscribeFactorBotDto> SendFactorSubscribeAsync(BuyMarzbanVpnDto buy, long chatId);

    /// <summary>
    /// get marzban template by id for information 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<MarzbanVpnTemplateDto?> GetMarzbanTemplateByIdAsync(long id);

    /// <summary>
    /// get filter marzban users name
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<FilterMarzbanUser> FilterMarzbanUsersList(FilterMarzbanUser filter);

    /// <summary>
    /// get marzban user dto
    /// </summary>
    /// <param name="id"></param>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<SubescribeStatus.ServiceStatus?> GetMarzbanUserByChatIdAsync(long id, long chatId);

    /// <summary>
    /// get marzban subscibetion links
    /// </summary>
    /// <param name="id"></param>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<List<string>> GetMarzbanSubscibtionLiknsAsync(long id, long chatId);

    /// <summary>
    /// get subscribe
    /// </summary>
    /// <param name="id"></param>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<string> GetSubscibetionAsync(long id, long chatId);

    /// <summary>
    /// get transaction deatil
    /// </summary>
    /// <returns></returns>
    Task<TransactionDetailDto?> GetTransactionDetailAsync(long chatId);

    /// <summary>
    /// for reset user password when get password
    /// </summary>
    /// <param name="chatId">get from telegram</param>
    /// <param name="charter">for len password defualt is 6</param>
    /// <returns></returns>
    Task<string> ResetUserPasswordAsync(long chatId, int charter = 6);

    Task UpdateMarzbanUserAsync(MarzbanUserDto user, long serverId);

    Task AddTransactionAsync(AddTransactionDto transaction, long chatId);

    /// <summary>
    /// started bot async
    /// </summary>
    /// <param name="start"></param>
    /// <returns>welcome message</returns>
    Task<AgentOptionDto?> StartTelegramBotAsync(StartTelegramBotDto start);

    /// <summary>
    /// change marzban user status
    /// </summary>
    /// <param name="status"></param>
    /// <param name="marzbanUserId"></param>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task ChangeMarzbanUserStatusAsync(MarzbanUserStatus status, long marzbanUserId, long chatId);

    /// <summary>
    /// have chat id request for agent 
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<bool> HaveRequestForAgentAsync(long chatId);

    /// <summary>
    /// for add request agent
    /// </summary>
    /// <param name="description"></param>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task AddRequestAgentAsync(string description, string phone, long chatId);

    /// <summary>
    /// delete marzban user
    /// </summary>
    /// <param name="marzbanUserId"></param>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task DeleteMarzbanUserAsync(long marzbanUserId, long chatId);

    /// <summary>
    /// revoke marzban user async
    /// </summary>
    /// <param name="marzbanUserId"></param>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<string> RevokeMarzbanUserAsync(long marzbanUserId, long chatId);

    /// <summary>
    /// get agent by chat id
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<AgentDto?> GetAgentByChatIdAsync(long chatId);

    /// <summary>
    /// Is Agent By Chat Id
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<bool> IsAgentAsyncByChatIdAsync(long chatId);

    /// <summary>
    /// send agent bot link
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<TelegramLinkDto?> GetAgentBotLinkAsync(long chatId);

    /// <summary>
    /// get telegramBot by bot Id
    /// </summary>
    /// <param name="botId"></param>
    /// <returns></returns>
    Task<TelegramBotDto> GetTelegramBotByBotIdAsync(long botId);

    /// <summary>
    /// update user transaction detial card
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="session"></param>
    /// <returns></returns>
    Task<bool> EditeAgentTransactionDetailAsync(long chatId, TelegramMarzbanVpnSession session);

    /// <summary>
    /// get agent transaction deatil dto
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<TransactionDetailDto?> GetAgentTransactionDetailAsync(long chatId);

    /// <summary>
    /// send agent information 
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<AgentInformationDto> GetAgentInformationAsync(long chatId);

    /// <summary>
    /// update agent percent
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="percent"></param>
    /// <returns></returns>
    Task<bool> UpdateAgentPercentAsync(long chatId, long percent);

    /// <summary>
    /// update user percent
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="percent"></param>
    /// <returns></returns>
    Task<bool> UpdateUserPercentAsync(long chatId, long percent);

    /// <summary>
    /// update user brand name
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="englishBrandName"></param>
    /// <param name="persionBrandName"></param>
    /// <returns></returns>
    Task<bool> UpdateAgentBrandNames(long chatId, string? persionBrandName, string? englishBrandName);

    /// <summary>
    /// change agent request async
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="i"></param>
    /// <param name="accept"></param>
    /// <returns></returns>     
    Task ChangeAgentRequestAsync(long chatId, UpdateAgentRequestDto status);

    /// <summary>
    /// active or not active card to card
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="action"></param>
    /// <returns></returns>
    Task<bool> ActionForCardToCardAsync(long chatId, long userchatId, bool action);

    /// <summary>
    /// for send management user 
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="userchatId"></param>
    /// <returns></returns>
    Task<UserInformationDto> GetUserInformationAsync(long chatId, long userchatId);

    /// <summary>
    /// increase user balanse
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="valueUserChatId"></param>
    /// <param name="transaction"></param>
    /// <returns></returns> 
    Task IncreaseUserAsync(long chatId, long valueUserChatId, AddTransactionDto transaction);

    /// <summary>
    /// decrease user balanse
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="valueUserChatId"></param>
    /// <param name="transaction"></param>
    /// <returns></returns>
    Task DecreaseUserAsync(long chatId, long valueUserChatId, AddTransactionDto transaction);

    /// <summary>
    /// update transaction status
    /// </summary>
    /// <param name="status"></param>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task UpdateTransactionAsync(UpdateTransactionStatusDto status, long chatId);

    /// <summary>
    /// block user async
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="userChatId"></param>
    /// <param name="block"></param>
    /// <returns></returns>
    Task BlockUserAsync(long chatId, long userChatId, bool block);

    /// <summary>
    /// update agent payemnt information 
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="minimalAmountForAgent"></param>
    /// <param name="maximumAmountForAgent"></param>
    /// <returns></returns>
    Task UpdateAgentPaymentAsync(long chatId, long minimalAmountForAgent, long maximumAmountForAgent);

    /// <summary>
    /// update user payment async
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="minimalAmountForUser"></param>
    /// <param name="maximumAmountForUser"></param>
    /// <returns></returns>
    Task UpdateUserPaymentAsync(long chatId, long minimalAmountForUser, long maximumAmountForUser);

    /// <summary>
    /// send list agents
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<FilterAgentDto> FilterAgentsAsync(long chatId);
    
    /// <summary>
    /// return agent by information Id
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="agentId"></param>
    /// <returns></returns>
    Task<AgentInformationDto> GetAgentInformationByIdAsync(long chatId,long agentId);

    /// <summary>
    /// update agent percent
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="childAgentId"></param>
    /// <param name="specialPercent"></param>
    /// <returns></returns>
    Task UpdateAgentSpecialPercent(long chatId,long childAgentId, long specialPercent);


    /// <summary>
    /// get agent by admin chatId
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<AgentDto?> GetAgentByAdminChatIdAsync(long chatId);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="vpnId"></param>
    /// <param name="days"></param>
    /// <returns></returns>
    Task<List<MarzbanVpnTemplateDto>>  SendTemplatesGroupingByDays(long chatId, long vpnId, int days);

    /// <summary>
    /// add agent async
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="id"></param>
    /// 
    /// <returns></returns>
    Task AddAgentAsync(long chatId, long id);
    
    /// <summary>
    /// send list transactions
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<List<TransactionDto>> GetTransactionsAsync(long chatId);

    /// <summary>
    /// update message id
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="messageId"></param>
    /// <returns></returns>
    Task UpdateUserMessageId(long chatId,int messageId);
}