using Domain.DTOs.Account;
using Domain.Entities.Account;
using Domain.Enums.Account;


namespace Application.Services.Interface.Account;

public interface IUserService
{
    Task<AddUserResult> AddUserAsync(AddUserDto user, long userId);
    Task<LoginUserResult> LoginAsync(LoginUserDto login);
    Task<UserDto> GetUserByMobileAsync(string mobile);
    Task<RegisterUserResult> RegisterAsync(RegisterUserDto registerUser);
    Task<ForgetPasswordResult> ForgetPasswordAsync(ForgetUserPasswordDto forget);
    Task<FilterUsersDto> GetUsersByFilterAsync(FilterUsersDto filter);
    Task<FilterUsersDto> GetAgentUsersByFilterAsync(FilterUsersDto filter);
    Task<UserDto?> GetUserByIdAsync(long id);
    Task UpdateUserBalance(long balance, long userId, long updateBy);
    Task<UpdateUserProfileResult> UpdateUserProfileAsync(UpdateUserProfileDto profile, long userId);
    Task<List<UserDto>> GetUserByAgentAsync(long userId);
    Task SendMobileActiveCode(string phone, long userId);
}