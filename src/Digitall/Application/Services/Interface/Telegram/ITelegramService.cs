using Domain.DTOs.Account;
using Domain.DTOs.Marzban;
using Domain.DTOs.Telegram;
using Domain.Entities.Account;

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
    Task<List<TelegramBotDto>> GetAllTelegramBotAsync();

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
    Task StartTelegramBot(StartTelegramBotDto start);
    
    Task<List<MarzbanVpnTestDto>> GetListMarzbanVpnTest()
}