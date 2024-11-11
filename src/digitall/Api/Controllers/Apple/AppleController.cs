using System.Net;
using Api.Controllers.Base;
using Api.Filters;
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
    [ProducesResponseType(typeof(AppleId),(int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<FilterAppleId>> AddAppleId([FromBody] AddAppleIdDto appleId)
    {
        throw new NotImplementedException();
        // return Ok(await appleService.FilterAppleIdListAsync(filter));
    }
}