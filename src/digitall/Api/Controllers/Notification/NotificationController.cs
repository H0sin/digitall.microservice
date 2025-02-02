using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Api.Utitlities;
using Asp.Versioning;
using Application.Extensions;
using Application.Services.Interface.Notification;
using Domain.DTOs.Notification;
using Domain.Enums.Notification;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Notification;

/// <summary>
/// Notification Controller
/// </summary>
/// <param name="notificationService"></param>
[ApiVersion(1)]
public class NotificationController(INotificationService notificationService) : BaseController
{
    /// <summary>
    /// send notfication types
    /// just accept 
    /// </summary>
    /// <returns></returns>
    [PermissionChecker("GetNotificationType")]
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
    [PermissionChecker("AddNotification")]
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> AddNotification([FromBody] AddNotificationDto notification)
    {
        await notificationService.AddNotificationAsync(notification, User.GetId());
        return Ok();
    }

    /// <summary>
    /// get list notifications
    /// </summary>
    /// <returns></returns>
    [PermissionChecker("GetNotifications")]
    [HttpGet]
    [ProducesResponseType(typeof(List<NotificationDto>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<List<NotificationDto>>> GetNotifications()
        => Ok(await notificationService.GetNotificationsAsync(User.GetId()));
}