using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Application.Extensions;
using Application.Services.Interface.Telegram;
using Asp.Versioning;
using Domain.DTOs.Telegram;
using Domain.Entities.Telegram;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Telegram;

[ApiVersion(1)]
public class TelegramController(
    ITelegramService telegramService
) : BaseController
{
    /// <summary>
    /// add telegram bot for agent
    /// </summary>
    /// <param name="bot"></param>
    /// <returns></returns>
    [Authorize]
    [HttpPost]
    [ProducesDefaultResponseType]
    [ProducesResponseType(typeof(AddTelegramBotDto), (int)HttpStatusCode.OK)]
    public async Task<ApiResult<AddTelegramBotDto>> AddTelegramBot([FromBody] AddTelegramBotDto bot)
    {
        return Ok(await telegramService.AddTelegramBotAsync(bot, User.GetUserId()));
    }
}
