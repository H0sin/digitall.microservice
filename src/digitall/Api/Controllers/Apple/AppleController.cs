using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Application.Extensions;
using Application.Services.Implementation.Apple;
using Application.Services.Interface.Apple;
using Asp.Versioning;
using Domain.DTOs.Apple;
using Domain.Entities.Apple;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Apple;

/// <summary>
/// apple id controller
/// </summary>
/// <param name="appleService"></param>
[ApiVersion(1)]
public class AppleController(IAppleService appleService) : BaseController
{
    /// <summary>
    /// get GetAppleIdTypesAsync
    /// </summary>
    /// <returns></returns>
    [ProducesResponseType(typeof(List<GetAppleIdTypeDto>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    [HttpGet]
    public async Task<ApiResult<List<GetAppleIdTypeDto>>> GetAppleIdType()
    {
        return Ok(await appleService.GetAppleIdTypesAsync());
    }


    /// <summary>
    /// return list apple id
    /// </summary>
    /// <returns></returns>
    [ProducesResponseType(typeof(FilterAppleId), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    [HttpGet]
    public async Task<ApiResult<FilterAppleId>> FilterAppleId([FromQuery] FilterAppleId filter)
    {
        return Ok(await appleService.FilterAppleIdListAsync(filter));
    }

    /// <summary>
    /// return list apple id
    /// </summary>
    /// <returns></returns>
    [ProducesResponseType(typeof(AppleId), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    [HttpPost]
    public async Task<ApiResult<AppleId>> AddAppleId([FromBody] AddAppleIdDto appleId)
    {
        return Ok(await appleService.AddAppleIdAsync(appleId, User.GetId()));
    }
}