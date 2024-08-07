using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Marzban;
using Domain.DTOs.Telegram;
using Domain.DTOs.Transaction;
using Domain.Entities.Account;
using Domain.Entities.Agent;
using Domain.Entities.Marzban;
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
    Task<GetMarzbanVpnDto?> GetMarzbanVpnInformationByIdAsync(long vpnId, long chatId);

    /// <summary>
    /// get marzban template by vpn id
    /// </summary>
    /// <param name="vpnId"></param>
    /// <returns></returns>
    Task<List<MarzbanVpnTemplateDto>> GetMarzbanVpnTemplatesByVpnIdAsync(long vpnId, long chatId);

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
    Task AddRequestAgentAsync(string description, long chatId);

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
}