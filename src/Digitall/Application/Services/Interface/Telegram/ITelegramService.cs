using Domain.DTOs.Account;
using Domain.DTOs.Marzban;
using Domain.DTOs.Telegram;
using Domain.Entities.Account;
using Domain.Entities.Marzban;

namespace Application.Services.Interface.Telegram;

public interface ITelegramService : IAsyncDisposable
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
    Task<GetMarzbanVpnDto?> GetMarzbanVpnInformationByIdAsync(long vpnId);

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
    Task<SubescribeStatus.ServiceStatus?> GetMarzbanUserByChatIdAsync(long id,long chatId);

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
    
    Task StartTelegramBot(StartTelegramBotDto start);
}