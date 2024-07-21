using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Asp.Versioning;
using Api.Filters;
using Application.Exceptions;
using Application.Extensions;
using Application.Services.Interface.Notification;
using Application.Utilities;
using Domain.DTOs.Notification;
using Domain.Enums;
using Domain.Enums.Notification;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;

namespace Api.Controllers.Notification;

[ApiVersion(1)]
public class NotificationController(INotificationService notificationService) : BaseController
{
    /// <summary>
    /// send notfication types
    /// just accept 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<string>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public ApiResult<List<string>> GetNotificationType()
        => Ok(Enum.GetNames(typeof(NotificationType)).ToList());
    
    
    /// <summary>
    /// add notification
    /// </summary>
    /// <param name="notification"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> AddNotification([FromBody] AddNotificationDto notification)
    {
        await notificationService.AddNotificationAsync(notification, User.GetId());
        return Ok();
    }
}