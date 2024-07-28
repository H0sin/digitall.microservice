using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Asp.Versioning;
using Application.Extensions;
using Application.Services.Interface.Country;
using Application.Services.Interface.Sanaei;
using Domain.DTOs.Country;
using Domain.DTOs.Sanaei;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Country;

[ApiVersion(1)]
public class CountryController(ICountryService countryService) : BaseController
{
    #region get

    /// <summary>
    /// get list countries
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult<List<CountryDto>>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<List<CountryDto>>> GetCountris()
    {
        List<CountryDto> response = await countryService.GetCountriesAsync();
        return Ok(response);
    }

    #endregion

    #region add

    /// <summary>
    /// for added country if exists name return Application request
    /// </summary>
    /// <param name="country"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> AddCountry(AddCountryDto country)
    {
        await countryService.AddCountryAsync(country, User.GetId());
        return Ok();
    }

    #endregion
}