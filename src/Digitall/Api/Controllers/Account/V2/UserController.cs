using System.Net;
using Api.Filters;
using Application.Extensions;
using Application.Helper;
using Application.Services.Interface.Account;
using Asp.Versioning;
using Domain.DTOs.Account;
using Domain.Enums;
using Domain.Enums.Account;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Account.V2;

[ApiVersion(2)]
[Route("api/v{v:apiVersion}/[controller]/[action]")]
[ServiceFilter(typeof(ExceptionHandler))]
[ApiResultFilter]
[ApiController]
public class UserController(IUserService userService) : ControllerBase
{
    /// <summary>
    /// login user api after login active user phone
    /// </summary>
    /// <returns>Token</returns>
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.NotFound)]
    [ProducesResponseType(typeof(ApiResult<LoginUserResponseDto>), (int)HttpStatusCode.OK)]
    [HttpPost]
    public async Task<ApiResult> Login([FromBody] LoginDto login)
    {
        LoginUserResult response = login.Email != null
            ? await userService.LoginByEmailAsync(login.Email, login.Password)
            : await userService.LoginByChatIdAsync(login.ChatId ?? 0, login.Password);

        switch (response)
        {
            case LoginUserResult.NotFound:
                return new ApiResult(false, ApiResultStatusCode.InValidUserPass, "کاربری با مشخصات زیر یافت نشد");
            case LoginUserResult.Blocked:
                return new ApiResult(false, ApiResultStatusCode.Blocked, "حساب کاربری شما مسدود شدع است");
            case LoginUserResult.Success:
                UserDto? user =
                    login.Email != null
                        ? await userService.GetUserByEmailAsync(login.Email!)
                        : await userService.GetUserByChatIdAsync(login.ChatId ?? 0);
                string token = JwtHelper.GenerateToken(user);
                return new ApiResult<LoginUserResponseDto>
                (true, ApiResultStatusCode.Success, new LoginUserResponseDto(token, user.UserFullName()),
                    $"{user.UserFullName()} خوش آمدید");
        }

        return NotFound();
    }
}