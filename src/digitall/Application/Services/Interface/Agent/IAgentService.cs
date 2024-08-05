using Domain.DTOs.Agent;
using Domain.Entities.Account;
using Domain.Entities.Agent;
using Domain.Enums.Agent;
using Microsoft.EntityFrameworkCore;


namespace Application.Services.Interface.Agent;

public interface IAgentService : IAsyncDisposable
{
    /// <summary>
    /// get agent information by code
    /// </summary>
    /// <param name="agentCode"></param>
    /// <returns></returns>
    Task<AgentDto?> GetAgentByCode(long agentCode);

    /// <summary>
    /// get agent by telegram chat id async
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<AgentDto?> GetAgentByIdAsync(long id);

    /// <summary>
    /// get agent information after login for show user
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>Agent</returns>
    Task<AgentDto?> GetAgentByUserIdAsync(long userId);

    /// <summary>
    /// add request for agent
    /// </summary>
    /// <param name="request"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task AddAgentRequestAsync(AddRequestAgentDto request, long userId);

    /// <summary>
    /// update request agent
    /// </summary>
    /// <param name="agentRequestam>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task UpdateAgentRequest(UpdateAgentRequestDto agentRequest, long userId);

    /// <summary>
    /// get list agent nested object
    /// </summary>
    /// <param name="agentId"></param>
    /// <returns></returns>
    Task<AgentTreeDto> GetAgentsChildByFilterAsync(long userId);

    /// <summary>
    /// when user wish payment show agent card information
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<InformationPaymentDto?> GetAgentInformationPaymentAsync(long userId);

    /// <summary>
    /// get agent by path
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    Task<Domain.Entities.Agent.Agent?> GetAgentByPathAsync(HierarchyId path);

    /// <summary>
    /// get admin by agent id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<User?> GetAdminAgentUserAsync(long id);

    /// <summary>
    /// get agent option by agent id 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<AgentOptionDto?> GetAgentOptionByAgentIdAsync(long id);
    
    /// <summary>
    /// get list agentrequest admin see request agent
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<List<AgentRequestDto>> GetListAgentRequest(long userId);
    
    Task<List<AgentDto>> GetAgentsListAsync();
    Task<FilterAgentDto> FilterAgentAsync(FilterAgentDto filter);
    Task<AddAgentResult> AddAgentAsync(AddAgentDto agent, long userId);
    Task<List<long>> GetAgentRoot(long agentId);
    Task<AgentDto?> GetAgentByAdminId(long adminId);
}