using System.Net;
using System.Text;
using Api.Controllers.Base;
using Api.Filters;
using Asp.Versioning;
using Application.Extensions;
using Application.Helper;
using Application.Http.Request;
using Application.Services.Interface.Server;
using Application.Static;
using Domain.DTOs.Sanaei;
using Domain.DTOs.Sanaei.Base;
using Domain.DTOs.Sanaei.Client;
using Domain.DTOs.Server;
using Domain.Entities.Account;
using Domain.Enums;
using Domain.Enums.Server;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Api.Controllers.Server;

[ApiVersion(1)]
public class ServerController : BaseController
{
    #region constructor

    private readonly IServerService _serverService;
    private readonly IConfiguration _configuration;

    public ServerController(IServerService serverService, IHttpContextAccessor contextAccessor,
        IConfiguration configuration)
    {
        serverService.UserId = contextAccessor.HttpContext!.User.GetId();
        _serverService = serverService;
        _configuration = configuration;
    }

    #endregion

    #region add

    /// <summary>
    /// get transaction list by filter
    /// </summary>
    /// <returns>FilterTransaction</returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.BadRequest)]
    [ProducesDefaultResponseType]
    [Authorize]
    public async Task<ApiResult> AddServer([FromBody] AddServerDto server)
    {
        AddServerResult response = await _serverService.AddServerAsync(server);

        return Ok();
    }

    #endregion

    #region get

    /// <summary>
    /// get active servers list for drop down
    /// </summary>
    /// <returns>List Server Dto</returns>
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult<List<ServerDto>>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<List<ServerDto>>> GetServers()
    {
        List<ServerDto> servers = await _serverService.GetServersAsync();
        return Ok(servers);
    }

    /// <summary>
    /// get server by id
    /// </summary>
    /// <returns>Server Dto</returns>
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult<ServerDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResult), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResult), StatusCodes.Status500InternalServerError)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<ServerDto>> GetServerById(long id)
    {
        ServerDto servers = await _serverService.GetServerByIdAsync(id);
        return Ok(servers);
    }

    #endregion

    #region filter

    /// <summary>
    /// filter servers
    /// </summary>
    /// <returns>List Server Dto</returns>
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult<FilterServerDto>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<FilterServerDto>> FilterServers([FromQuery] FilterServerDto filter)
    {
        FilterServerDto servers = await _serverService.FilterServerAsync(filter);
        return Ok(servers);
    }

    #endregion

    #region get inbounds list

    // /// <summary>
    // /// get inbounds list
    // /// </summary>
    // /// <param name="id">server sanaei id</param>
    // /// <returns>Test</returns>
    // [HttpGet]
    // [ProducesDefaultResponseType]
    // public async Task<ApiResult> InboundsList(long id)
    // {
    //     ServerDto? server = await _serverService.GetServerByIdAsync(id);
    //     PathUri url = new PathUri(server);
    //
    //     await SetCookieHandler(server);
    //
    //     SanaeiDto<List<SanaeiInboundDto>> response =
    //         await RequestHandler.GetRequestAsync<SanaeiDto<List<SanaeiInboundDto>>>(url.InboundsList,
    //             "faraji.samanii.com", _configuration);
    //
    //     return response.Success switch
    //     {
    //         true => new ApiResult<SanaeiDto<List<SanaeiInboundDto>>>(true, ApiResultStatusCode.Success, response,
    //             "لیست این باندا."),
    //         false => new ApiResult(false, ApiResultStatusCode.ServerError, "اطلاعات اشتباه است.")
    //     };
    // }

    #endregion

    #region test server

    /// <summary>
    /// جهت تست برسی اتصال به سرور
    /// for success test connecting to server
    /// </summary>
    /// <returns>Test</returns>
    // [HttpPost]
    // [ProducesDefaultResponseType]
    // public async Task<ApiResult> TestServer([FromForm] long id)
    // {
    //     ServerDto? server = await _serverService.GetServerByIdAsync(id);
    //     PathUri url = new PathUri(server);
    //
    //     await SetCookieHandler(server);
    //
    //     object body = new
    //     {
    //         UserName = server.UserName,
    //         Password = server.Password
    //     };
    //
    //     SanaeiDto response =
    //         await RequestHandler.PostRequestAsync<SanaeiDto>(url.Login, body, _configuration);
    //     return response.Success switch
    //     {
    //         true => new ApiResult(true, ApiResultStatusCode.Success, "اطلاعات سرور درست است."),
    //         false => new ApiResult(false, ApiResultStatusCode.ServerError, "اطلاعات اشتباه است.")
    //     };
    // }

    #endregion

    #region add client

    [HttpPost]
    // public async Task<ApiResult> AddClient([FromBody] List<AddClientDto> clients, long id)
    // {
    //     ServerDto? server = await _serverService.GetServerByIdAsync(id);
    //     PathUri url = new PathUri(server);
    //
    //     await SetCookieHandler(server);
    //
    //     object body = new BaseRequestSanaei()
    //     {
    //         Id = 1,
    //         Settings = new { Clients = clients }.LowercaseContractResolver()
    //     };
    //
    //     SanaeiDto response =
    //         await RequestHandler.PostRequestAsync<SanaeiDto>(url.AddClient, body, _configuration);
    //
    //     return response.Success switch
    //     {
    //         true => new ApiResult(true, ApiResultStatusCode.Success, "کلاینت با موفقیت ساخته شد"),
    //         false => new ApiResult(false, ApiResultStatusCode.ServerError, response.Msg)
    //     };
    // }

    #endregion

    #region methods

    private async Task SetCookieHandler(ServerDto? server)
    {
        using var client = new HttpClient();

        var response = await client.PostAsync("https://faraji.samanii.com:1999/hosein/login",
            new StringContent(JsonConvert.SerializeObject(
                    new { server.UserName, server.Password }),
                Encoding.UTF8, "application/json")
        );

        var cookie = response.Headers.SingleOrDefault(x => x.Key == "Set-Cookie").Value;
        var listCookie = cookie.ToList()[0].Split(';');

        _configuration["Request:CookieToken"] = listCookie[0];
    }

    #endregion

    #region login to server

    // /// <summary>
    // /// for login to sanaei server
    // /// </summary>
    // /// <param name="id">server sanaei id</param>
    // /// <returns>Test</returns>
    // [HttpPost]
    // [ProducesDefaultResponseType]
    // [ApiVersion(1, Deprecated = true)]
    // public async Task<ApiResult> LoginToServer([FromForm] long id)
    // {
    //     ServerDto? server = await _serverService.GetServerByIdAsync(id);
    //     PathUri url = new PathUri(server);
    //
    //     object body = new
    //     {
    //         UserName = server.UserName,
    //         Password = server.Password
    //     };
    //
    //     SanaeiDto response =
    //         await RequestHandler.PostRequestAsync<SanaeiDto>(url.Login, body, _configuration);
    //     return response.Success switch
    //     {
    //         true => new ApiResult(true, ApiResultStatusCode.Success, "با موفقیت وارد شدید."),
    //         false => new ApiResult(false, ApiResultStatusCode.ServerError, "اطلاعات اشتباه است.")
    //     };
    // }

    #endregion
}