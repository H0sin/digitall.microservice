using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Asp.Versioning;
using Application.Exceptions;
using Application.Extensions;
using Application.Services.Interface.Agent;
using Domain.DTOs.Agent;
using Domain.Enums;
using Domain.Enums.Agent;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Agent;

/// <inheritdoc />
[ApiVersion(1)]
public class AgentController(IAgentService agentService) : BaseController
{
    #region get

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
        Ok(await agentService.GetAgentByUserIdAsync(User.GetUserId()));

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

    #endregion

    #region add

    /// <summary>
    /// add agent send user for admin and agent parent
    /// </summary>
    /// <param name="agent"></param>
    /// <returns>ok or bad request</returns>
    [HttpPost]
    [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
    public async Task<ApiResult> AddAgent([FromBody] AddAgentDto agent)
    {
        if (User.GetUserId() == 0)
            throw new AppException(ApiResultStatusCode.UnAuthorized);

        AddAgentResult result = await agentService.AddAgentAsync(agent, User.GetUserId());

        return result switch
        {
            AddAgentResult.Success => Ok(),
            _ => BadRequest()
        };
    }

    #endregion
}