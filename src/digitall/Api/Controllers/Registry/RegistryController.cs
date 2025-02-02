using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Api.Utitlities;
using Application.Extensions;
using Application.Services.Interface.Registry;
using Asp.Versioning;
using Domain.DTOs.Registry;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Registry;

/// <summary>
/// for registry phone
/// </summary>
[ApiVersion(1)]
public class RegistryController(IRegistryService registryService) : BaseController
{
    /// <summary>
    /// add registry action
    /// </summary>
    /// <param name="registry"></param>
    /// <returns></returns>
    [PermissionChecker("Add")]
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> Add(AddRegistryDto registry)
    {
        await registryService.AddRegistryAsync(registry, User.GetId());
        return Ok();
    }


    /// <summary>
    /// filter registry
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    [PermissionChecker("Filter")]
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult<FilterRegistryDto>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<FilterRegistryDto>> Filter([FromQuery] FilterRegistryDto filter)
    {
        return Ok(await registryService.FilterRegistryAsync(filter, User.GetId()));
    }

    /// <summary>
    /// filter registry
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    [PermissionChecker("FilterAll")]
    [HttpGet]
    [PermissionChecker("AllRegistryItem")]
    [ProducesResponseType(typeof(ApiResult<FilterRegistryDto>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<FilterRegistryDto>> FilterAll([FromQuery] FilterRegistryDto filter)
    {
        return Ok(await registryService.FilterRegistryAsync(filter));
    }

    /// <summary>
    /// update registry price and model
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    [PermissionChecker("Update")]
    [HttpPut]
    [PermissionChecker("UpdateRegistryAmountModel")]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> Update(RegistryAmountModelDto amountModel)
    {
        await registryService.UpdateRegistryAmountModel(amountModel, User.GetId());
        return Ok();
    }

    /// <summary>
    /// upload transaction images
    /// </summary>
    /// <param name="images"></param>
    /// <returns></returns>
    [PermissionChecker("UploadRegistryTransactionImages")]
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> UploadRegistryTransactionImages([FromForm] UploadRegistryTransactionImagesDto images)
    {
        await registryService.UploadRegistryTransactionImagesAsync(images, User.GetId());
        return Ok();
    }
    
    // [PermissionChecker("")]
}