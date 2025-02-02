using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Api.Utitlities;
using Asp.Versioning;
using Application.Extensions;
using Application.Services.Interface.Sanaei;
using Domain.DTOs.Sanaei;
using Domain.DTOs.Sanaei.Client;
using Domain.DTOs.Sanaei.Inbound;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Sanaei;

[ApiVersion(1)]
public class SanaeiController(ISanaeiService sanaeiService) : BaseController
{
    #region get inbounds

    /// <summary>
    /// get list sanaei inbound
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    [PermissionChecker("GetInboundsList")]
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult<List<SanaeiInboundDto>>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<List<SanaeiInboundDto>>> GetInboundsListAsync(long serverId)
    {
        List<SanaeiInboundDto> response = await sanaeiService.GetInboundsListAsync(serverId);
        return Ok(response);
    }


    /// <summary>
    /// get inbound by id
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    [PermissionChecker("GetInboundsbyId")]
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult<InboundDto>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<InboundDto>> GetInboundsById(long serverId, long inboundId)
    {
        InboundDto response = await sanaeiService.GetInboundByIdAsync(serverId, inboundId);
        return Ok(response);
    }

    #endregion

    #region add inbound

    /// <summary>
    /// add inbound for digitalll data base after add inbound in sanaei update inbpund in sanaei panel 
    /// </summary>
    /// <param name="addInbound"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    [PermissionChecker("AddInbound")]
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> AddInbound(AddInboundDto addInbound)
    {
        await sanaeiService.AddInboundAsync(addInbound, User.GetId());
        return Ok();
    }

    #endregion

    #region update inbound

    /// <summary>
    /// update inboud in digitall data base after update inbound in sanaei update inbound in sanaei panel
    /// </summary>
    /// <param name="updateInbound"></param>
    /// <returns></returns>
    [PermissionChecker("UpdateInbound")]
    [HttpPut]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> UpdateInbound(UpdateInboundDto updateInbound)
    {
        await sanaeiService.UpdateInboundAsync(updateInbound, User.GetId());
        return Ok();
    }

    #endregion

    #region delete 

    /// <summary>
    /// delete inbound by server async 
    /// </summary>
    /// <param name="updateInbound"></param>
    /// <returns></returns>
    [PermissionChecker("DeleteInbound")]
    [HttpDelete]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> DeleteInbound(long inboundId)
    {
        await sanaeiService.DeleteInboundAsync(inboundId);
        return Ok();
    }

    #endregion

    #region client
    
    [PermissionChecker("GetClientConfig")]

    [HttpPost]
    public async Task<ApiResult> GetClientConfig([FromBody] GetClientDto client)
    {
        string response = await sanaeiService.GetClientConfigAsync(client);
        return Ok();
    }

    #endregion

}