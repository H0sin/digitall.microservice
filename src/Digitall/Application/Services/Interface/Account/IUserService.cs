using Application.Exceptions;
using Domain.DTOs.Account;
using Domain.DTOs.Telegram;
using Domain.Entities.Account;
using Domain.Enums.Account;


namespace Application.Services.Interface.Account;

public interface IUserService
{
    Task<AddUserResult> AddUserAsync(AddUserDto user, long userId);
    Task<LoginUserResult> LoginAsync(LoginUserDto login) => throw new AppException("از ورژن v2 استفاده کنید");
    Task<LoginUserResult> LoginByEmailAsync(string email,string password);
    Task<LoginUserResult> LoginByChatIdAsync(long chatId,string password);
    Task<UserDto> GetUserByMobileAsync(string mobile);
    Task<RegisterUserResult> RegisterAsync(RegisterUserDto registerUser);
    Task RegisterUserFromTelegram(AddUserFromTelegramDto user);
    Task<ForgetPasswordResult> ForgetPasswordAsync(ForgetUserPasswordDto forget);
    Task<FilterUsersDto> GetUsersByFilterAsync(FilterUsersDto filter);
    Task<FilterUsersDto> GetAgentUsersByFilterAsync(FilterUsersDto filter);
    Task<UserDto?> GetUserByIdAsync(long id);
    Task<UserDto?> GetUserByEmailAsync(string email);
    Task<UserDto?> GetUserByChatIdAsync(long chatId);
    Task UpdateUserBalance(long balance, long userId, long updateBy);
    Task<UpdateUserProfileResult> UpdateUserProfileAsync(UpdateUserProfileDto profile, long userId);
    Task<List<UserDto>> GetUserByAgentAsync(long userId);
    Task SendMobileActiveCode(string phone, long userId);
}