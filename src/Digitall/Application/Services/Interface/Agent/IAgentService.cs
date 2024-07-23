using Domain.DTOs.Agent;
using Domain.Entities.Account;
using Domain.Enums.Agent;


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
    Task<AgentDto> GetAgentByUserIdAsync(long userId);

    /// <summary>
    /// add request for agent
    /// </summary>
    /// <param name="request"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task AddAgentRequestAsync(AddRequestAgentDto request,long userId);

    /// <summary>
    /// update request agent
    /// </summary>
    /// <param name="agent"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task UpdateAgentRequest(UpdateAgentRequestDto agent,long userId);

    /// <summary>
    /// get list agent nested object
    /// </summary>
    /// <param name="agentId"></param>
    /// <returns></returns>
    Task<AgentTreeDto> GetAgentsChild(long userId); 
    
    Task<List<AgentDto>> GetAgentsListAsync();
    Task<FilterAgentDto> FilterAgentAsync(FilterAgentDto filter);
    Task<AddAgentResult> AddAgentAsync(AddAgentDto agent, long userId);
    Task<List<long>> GetAgentRoot(long agentId);
    Task<AgentDto?> GetAgentByAdminId(long adminId);
}