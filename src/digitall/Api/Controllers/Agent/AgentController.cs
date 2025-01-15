using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Asp.Versioning;
using Application.Extensions;
using Application.Services.Interface.Agent;
using Domain.DTOs.Agent;
using Domain.Entities.Agent;
using Domain.Enums;
using Domain.Enums.Agent;
using Domain.Enums.Notification;
using Domain.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Agent;

/// <inheritdoc />
[ApiVersion(1)]
public class AgentController(IAgentService agentService) : BaseController
{
    #region get

    /// <summary>
    /// agency information
    /// </summary>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApiResult<AgencyInformationDto>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [HttpGet]
    public async Task<ApiResult<AgencyInformationDto>> AgencyInformation()
    {
        return Ok(await agentService.GetMyAgencyInformation(User.GetId()));
    }
    
    /// <summary>
    /// get agent after login my admin agent information
    /// </summary>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApiResult), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ApiResult<AgentTreeDto>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [HttpGet]
    public async Task<ApiResult<AgentTreeDto>> GetAgentTree()
    {
        AgentTreeDto? agent = await agentService.GetAgentsChildByFilterAsync(User.GetId());
        return Ok(agent);
    }


    /// <summary>
    /// get agent after login my admin agent information
    /// </summary>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApiResult), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ApiResult<AgentDto>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [HttpGet]
    public async Task<ApiResult<AgentDto>> GetAdminAgentInformation()
    {
        AgentDto? agent = await agentService.GetAgentByAdminIdAsync(User.GetId());
        return Ok(agent);
    }

    /// <summary>
    /// get agent information by agent code
    /// for login and register  
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApiResult), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ApiResult<AgentDto>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [AllowAnonymous]
    [HttpGet("{code:long}")]
    public async Task<ApiResult<AgentDto>> GetAgentByCode([FromRoute] long code)
    {
        AgentDto? agent = await agentService.GetAgentByCode(code);
        return Ok(agent);
    }

    /// <summary>
    /// get user agent
    /// </summary>
    /// <returns>AgentDto</returns>
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ApiResult<AgentDto>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<AgentDto>> GetUserAgent()
    {
        AgentDto? agent = await agentService.GetAgentByUserIdAsync(User.GetId());
        return Ok(agent);
    }


    /// <summary>
    /// get agent by id
    /// </summary>
    /// <param name="Id">Send Agent Id</param>
    /// <returns>AgentDto</returns>
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ApiResult<AgentDto>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<AgentDto>> GetAgentById(long id)
    {
        AgentDto? agent = await agentService.GetAgentByIdAsync(id);
        return Ok(agent);
    }

    /// <summary>
    /// get agent list
    /// </summary>
    /// <returns>List AgentDto</returns>
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ApiResult<List<AgentDto>>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<List<AgentDto>>> GetAgents()
    {
        List<AgentDto> agents = await agentService.GetAgentsListAsync();
        return Ok(agents);
    }


    /// <summary>
    /// get agent after login set agent and used
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(AgentDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), StatusCodes.Status204NoContent)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<AgentDto>> GetAgentInformation() =>
        Ok(await agentService.GetAgentByUserIdAsync(User.GetId()));


    [HttpGet]
    [ProducesResponseType(typeof(InformationPaymentDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult<InformationPaymentDto>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<InformationPaymentDto>> GetAgentInformationPayment() =>
        Ok(await agentService.GetAgentInformationPaymentAsync(User.GetId()));

    /// <summary>
    /// get agent request
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<AgentRequestDto>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult<List<AgentRequestDto>>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<List<AgentRequestDto>>> GetAgentRequests() =>
        Ok(await agentService.GetListAgentRequestAsync(User.GetId()));

    #endregion

    #region filter

    /// <summary>
    /// filter agent list
    /// </summary>
    /// <param name="filter">FilterAgentDto</param>
    /// <returns>FilterAgentDto</returns>
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ApiResult<FilterAgentDto>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<List<AgentDto>>> FilterAgents([FromQuery] FilterAgentDto filter)
    {
        FilterAgentDto agents = await agentService.FilterAgentAsync(filter);
        return Ok(agents);
    }

    // [HttpGet]
    // [ProducesResponseType(typeof(ApiResult), StatusCodes.Status204NoContent)]
    // [ProducesResponseType(typeof(ApiResult<FilterAgentDto>), StatusCodes.Status200OK)]
    // [ProducesDefaultResponseType]
    // public async Task<ApiResult<List<AgentDto>>> FilterAgents([FromQuery] FilterAgentDto filter)
    // {
    //     FilterAgentDto agents = await agentService.FilterAgentAsync(filter);
    //     return Ok(agents);
    // }

    /// <summary>
    /// return agent status
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<string>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public ApiResult<List<string>> GetAgentStatus() => Ok(Enum.GetNames(typeof(AgentRequestStatus)).ToList());

    #endregion

    #region add

    /// <summary>
    /// add agent send user for admin and agent parent
    /// </summary>
    /// <param name="agent"></param>
    /// <returns>ok or bad request</returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult),(int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> AddAgent([FromBody] AddAgentDto agent)
    {
        await agentService.AddAgentAsync(agent, User.GetId());

        return Ok();
    }

    /// <summary>
    /// add request for agent
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
    public async Task<ApiResult> AddRequestForAgent([FromBody] AddRequestAgentDto request)
    {
        await agentService.AddAgentRequestAsync(request, User.GetId());
        return Ok();
    }

    #endregion

    #region update

    /// <summary>
    /// updateRequestStatus
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPut]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> ChangeRequestStatus([FromBody] UpdateAgentRequestDto request)
    {
        await agentService.UpdateAgentRequest(request, User.GetId());
        return Ok();
    }

    
    /// <summary>
    /// update agent information 
    /// </summary>
    /// <param name="agency"></param>
    /// <returns></returns>
    [HttpPut]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> Update([FromBody] AgencyInformationDto agency)
    {
        await agentService.UpdateAgencyAsync(agency, User.GetId());
        return Ok();
    }
    
    #endregion

    #region report

    /// <summary>
    /// report agent incomes
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApiResult<FilterProfitReportDto>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    [HttpGet]
    public async Task<ApiResult<FilterProfitReportDto>> ProfitReport([FromQuery] FilterProfitReportDto filter)
    {
        return Ok(await agentService.FilterProfitReportAsync(filter,User.GetId()));
    }
    
    /// <summary>
    /// report agent input user
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApiResult<FilterInputUserReportDto>), (int)HttpStatusCode.OK)]
    [ProducesDefaultResponseType]
    [HttpGet]
    public async Task<ApiResult<FilterInputUserReportDto>> InputUserReport([FromQuery] FilterInputUserReportDto filter)
    {
        return Ok(await agentService.FilterInputUserReportAsync(filter,User.GetId()));
    }
    
    #endregion
}