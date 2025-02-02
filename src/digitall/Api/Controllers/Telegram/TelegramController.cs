using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Api.Utitlities;
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
    [PermissionChecker("AddTelegramBot")]
    [Authorize]
    [HttpPost]
    [ProducesDefaultResponseType]
    [ProducesResponseType(typeof(AddTelegramBotDto), (int)HttpStatusCode.OK)]
    public async Task<ApiResult<AddTelegramBotDto>> AddTelegramBot([FromBody] AddTelegramBotDto bot)
    {
        return Ok(await telegramService.AddTelegramBotAsync(bot, User.GetId()));
    }

    /// <summary>
    /// stop telegram bot
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [PermissionChecker("StopTelegramBot")]
    [HttpPut("{id}")]
    public async Task<ApiResult> StopTelegramBot(long id)
    {
        await telegramService.StopTelegramBotAsync(id);
        return Ok();
    }

    /// <summary>
    /// start telegram bot
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [PermissionChecker("StartTelegramBot")]
    [HttpPut("{id}")]
    public async Task<ApiResult> StartTelegramBot(long id)
    {
        await telegramService.StartTelegramBotAsync(id);
        return Ok();
    }
}