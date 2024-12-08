using Domain.DTOs.Account;
using Domain.DTOs.Telegram;
using Domain.Entities.Account;
using Domain.Enums.Account;
using Domain.Enums.Category;
using Domain.Enums.Marzban;


namespace Application.Services.Interface.Account;

public interface IUserService
{
    Task DisabledAllUserAccount(long userId);
    Task ActiveAllUserAccount(long userId);
    Task DeleteAllUserAccount(long userId);
    Task<List<(CategoryType,long)>> GetUserServices(long userId,MarzbanUserStatus? status = null);
    IQueryable<User> GetAgentUsers(long agentId);
    Task<AddUserResult> AddUserAsync(AddUserDto user, long userId);
    Task<LoginUserResult> LoginAsync(LoginUserDto login);
    Task<LoginUserResult> LoginByEmailAsync(string email,string password);
    Task<LoginUserResult> LoginByChatIdAsync(long chatId,string password);
    Task<UserDto> GetUserByMobileAsync(string mobile);
    Task<RegisterUserResult> RegisterAsync(RegisterUserDto registerUser);
    Task RegisterUserFromTelegram(StartTelegramBotDto user);
    Task<ForgetPasswordResult> ForgetPasswordAsync(ForgetUserPasswordDto forget);
    Task<FilterUsersDto> GetUsersByFilterAsync(FilterUsersDto filter);
    Task<FilterUsersDto> GetAgentUsersByFilterAsync(FilterUsersDto filter,long userId);
    Task<UserDto?> GetUserByIdAsync(long id);
    Task<UserDto?> GetUserByEmailAsync(string email);
    Task<UpdateUserProfileResult> UpdateUserProfileAsync(UpdateUserProfileDto profile, long userId);
    Task<List<UserDto>> GetUserByAgentAsync(long userId);
    Task SendMobileActiveCode(string phone, long userId);
    Task<UserDto?> GetUserByChatIdAsync(long chatId);
    
    /// <summary>
    /// get child agent user by id async
    /// </summary>
    /// <param name="adminId"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<UserDto?> GetUserByIdAsync(long adminId, long userId);
    
    /// <summary>
    /// for update balanced user after append transaction
    /// </summary>
    /// <param name="price"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task UpdateUserBalanceAsync(long price, long userId);
}