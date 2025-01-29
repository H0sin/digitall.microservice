using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Api.Utitlities;
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
    [PermissionChecker("GetAppleIdType")]
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
    [PermissionChecker("FilterAppleId")]
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
    [PermissionChecker("AddAppleId")]
    [ProducesResponseType(typeof(AppleId), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    [HttpPost]
    public async Task<ApiResult<AppleId>> AddAppleId([FromBody] AddAppleIdDto appleId)
    {
        return Ok(await appleService.AddAppleIdAsync(appleId, User.GetId()));
    }


    /// <summary>
    /// return appleId dto
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [PermissionChecker("GetAppleIdById")]
    [ProducesResponseType(typeof(AppleIdDto), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    [HttpGet("{id}")]
    public async Task<ApiResult<AppleIdDto>> GetAppleIdById(long id)
    {
        return Ok(await appleService.GetAppleIdByIdAsync(id));
    }

    /// <summary>
    /// update appleid async
    /// </summary>
    /// <param name="account"></param>
    /// <returns></returns>
    [PermissionChecker("UpdateAppleId")]
    [HttpPut]
    public async Task<ApiResult> UpdateAppleId([FromBody] AppleIdDto account)
    {
        await appleService.UpdateAppleIdAsync(account, User.GetId());
        return Ok();
    }
}