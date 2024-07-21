using Asp.Versioning;
using Application.Extensions;
using Application.Services.Interface.Vpn;
using Domain.DTOs.Account;
using Domain.DTOs.Vpn;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Application.Services.Interface.Marzban;
using Domain.DTOs.Marzban;
using Api.Filters;
using Api.Controllers.Base;

namespace Api.Controllers.Vpn;

[ApiVersion(1)]
public class VpnController(IVpnService vpnService) : BaseController
{
    #region get
    /// <summary>
    /// get vpn by filter
    /// </summary>
    /// <param name="filter">set filter item</param>
    /// <returns>filterProduct</returns>
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult<FilterVpnDto>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.NotFound)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.BadRequest)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<FilterVpnDto>> GetVpns([FromQuery] FilterVpnDto filter)
    {
        FilterVpnDto vpn = await vpnService.FilterVpnAsync(filter, User.GetId());
        return Ok(filter);
    }

    #endregion

    #region buy

    [HttpPost]
    public async Task<ApiResult> BuyVpn([FromBody] BuyMarzbanVpnDto vpn)
    {
        // await vpnService.BuyMarzbanVpnAsync(vpn, User.GetUserId());
        return Ok();
    }
    #endregion
}