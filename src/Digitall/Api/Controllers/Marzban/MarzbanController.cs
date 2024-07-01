using System.Collections;
using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Asp.Versioning;
using Application.Exceptions;
using Application.Extensions;
using Application.Services.Interface.Marzban;
using Domain.DTOs.Marzban;
using Domain.Entities.Marzban;
using Domain.Enums.Marzban;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Api.Controllers.Marzban;

[ApiVersion("1")]
public class MarzbanController(IMarzbanService marzbanService) : BaseController
{
    /// <summary>
    /// for add marzban server
    /// </summary>
    /// <param name="marzban"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> AddMarzbanServer([FromBody] AddMarzbanServerDto marzban)
    {
        await marzbanService.AddMarzbanServerAsync(marzban, User.GetUserId());
        return Ok();
    }

    /// <summary>
    /// for get marzban server by id
    /// </summary>
    /// <remarks>for counting vpn price</remarks>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(GetMarzbanServerOptionDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(GetMarzbanServerOptionDto), (int)HttpStatusCode.NoContent)]
    [ProducesResponseType(typeof(GetMarzbanServerOptionDto), (int)HttpStatusCode.NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<GetMarzbanServerOptionDto>> GetMarzbanServer([FromQuery] long id)
        => Ok(await marzbanService.GetMarzbanServerAsync(id));

    /// <summary>
    /// for get marzban servers
    /// </summary>
    /// <remarks>for selected server Ip or Price Or ......</remarks>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<GetMarzbanServerOptionDto>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<List<GetMarzbanServerOptionDto>>> GetMarzbanServers()
        => Ok(await marzbanService.GetMarzbanServersAsync());

    /// <summary>
    /// reastart xray core
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> ReasetMarzbanServerCore(long serverId)
    {
        await marzbanService.ReasetMarzbanServerCore(serverId);
        return Ok();
    }

    /// <summary>
    /// get marzban config core
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<string>> GetMarzbanServerCoreConfig(long serverId)
    {
        string response = await marzbanService.GetMarzbanServerCoreConfigAsync(serverId);
        return Ok(response);
    }

    /// <summary>
    /// update marzban config before get and after add add inboud or user 
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<string>> UpdateMarzbanServerCoreConfig(long serverId,
        [FromBody] object core)
    {
        string response = await marzbanService.UpdateMarzbanServerCoreConfigAsync(serverId, core);
        return Ok(response);
    }

    /// <summary>
    /// get marzban server settings 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(MarzbanNodeSettingDto), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<MarzbanNodeSettingDto>> GetMarzbanServerNodeSettings(long serverId)
    {
        MarzbanNodeSettingDto response = await marzbanService.GetMarzbanServerNodeSettingsAsync(serverId);
        return Ok(response);
    }

    /// <summary>
    /// add marzbannode server
    /// </summary>
    /// <param name="serverId"></param>
    /// <param name="node"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(MarzbanNodeDto), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<MarzbanNodeDto>> GetMarzbanServerNodeSettings(long serverId,
        [FromBody] AddMarzbanNodeDto node)
    {
        MarzbanNodeDto response = await marzbanService.AddMarzbanNodeAsync(serverId, node);
        return Ok(response);
    }

    /// <summary>
    /// get marzban node by Id
    /// </summary>
    /// <param name="serverId"></param>
    /// <param name="nodeId"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(MarzbanNodeDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(Nullable), (int)HttpStatusCode.NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<MarzbanNodeDto>> GetMarzbanServerNodeById(long serverId,
        [FromQuery] long nodeId)
    {
        MarzbanNodeDto response = await marzbanService.GetMarzbanNodeByIdAsync(serverId, nodeId);
        return Ok(response);
    }

    /// <summary>
    /// update marzban config before get and after add add inboud or user 
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    [ProducesResponseType(typeof(MarzbanNodeDto), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<MarzbanNodeDto>> UpdateMarzbanServerNode(long serverId, [FromQuery] long nodeId,
        [FromBody] AddMarzbanNodeDto node)
    {
        MarzbanNodeDto response = await marzbanService.UpdateMarzbanServerNodeAsync(serverId, nodeId, node);
        return Ok(response);
    }

    /// <summary>
    /// delete marzban node send node id form query
    /// </summary>
    /// <param name="serverId"></param>
    /// <param name="nodeId"></param>
    /// <returns></returns>
    [HttpDelete]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> DeleteMarzbanServerNode(long serverId, [FromQuery] long nodeId)
    {
        await marzbanService.DeleteNodeByIdAsync(serverId, nodeId);
        return Ok();
    }

    /// <summary>
    /// get all nodes
    /// </summary>
    /// <param name="serverId"></param>
    /// <param name="nodeId"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<MarzbanNodeDto>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<List<MarzbanNodeDto>>> GetMarzbanServerNodes(long serverId)
    {
        List<MarzbanNodeDto> response = await marzbanService.GetMarzbanNodeAsync(serverId);
        return Ok(response);
    }

    // inbounds

    /// <summary>
    /// get all inbouds
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<MarzbanInboundsDto>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<MarzbanInboundsDto>> GetMarzbanInbouds(long serverId)
    {
        MarzbanInboundsDto response = await marzbanService.GetMarzbanInboudsAsync(serverId);
        return Ok(response);
    }


    /// <summary>
    /// get list protocol
    /// </summary>
    /// <returns>[vless,trojan,vmess,shadowshoks]</returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<string>), (int)HttpStatusCode.OK)]
    public ApiResult<List<string>> Portocols() => Ok(Enum.GetNames(typeof(Protocols)).ToList());

    //vpn 

    /// <summary>
    /// add vpn for marzban send inbounds name in vmess or trojan
    /// </summary>
    /// <param name="vpn"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> AddMarzbanVpn(AddMarzbanVpnDto vpn)
    {
        await marzbanService.AddMarzbanVpnAsync(vpn, User.GetUserId());
        return Ok();
    }

    /// <summary>
    /// return marzban vpn list for buy
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<GetMarzbanVpnDto>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(IReadOnlyList<GetMarzbanVpnDto>), (int)HttpStatusCode.OK)]
    public async Task<ApiResult<IReadOnlyList<GetMarzbanVpnDto>>> GetMarzbanVpn()
    {
        var respoonse = await marzbanService.GetMarzbanVpnAsync();
        return Ok(respoonse);
    }

    /// <summary>
    /// buy vpn for marzban affter append template
    /// </summary>
    /// <param name="vpn"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> BuyMarzbanVpn(BuyMarzbanVpnDto vpn)
    {
        await marzbanService.BuyMarzbanVpnAsync(vpn, User.GetUserId());
        return Ok();
    }


    // todo : get sub link create 2 action 
    // action 1 get sub by user accesss
    // action 2 get all sub 

    // action 1
    [HttpPost]
    [ProducesResponseType(typeof(MarzbanUserInformationDto), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    // [ProducesErrorResponseType(typeof(NotFoundException))]
    public async Task<ApiResult<MarzbanUserInformationDto>> GetMarzbanUser([FromQuery] string Username)
    {
        return Ok(await marzbanService.GetMarzbanUserInformationAsync(Username, User.GetUserId()));
    }

    /// <summary>
    /// add vpn template
    /// </summary>
    /// <param name="template"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> AddMarzbanVpnTemplate([FromBody] AddMarzbanVpnTemplatesDto template)
    {
        await marzbanService.AddMarzbanVpnTemplateAsync(template, User.GetUserId());
        return Ok();
    }

    /// <summary>
    /// get marzban vpn template list by vpn id
    /// </summary>
    /// <param name="vpnId"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<MarzbanVpnTemplateDto>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<List<MarzbanVpnTemplateDto>>> GetMarzbanVpnTemplateByVpnId([FromQuery] long vpnId)
    {
        return Ok(await marzbanService.GetMarzbanVpnTemplateByVpnIdAsync(vpnId));
    }
}