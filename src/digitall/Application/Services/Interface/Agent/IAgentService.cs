using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Telegram;
using Domain.Entities.Account;
using Domain.Entities.Agent;
using Domain.Entities.Transaction;
using Domain.Enums.Agent;
using Microsoft.EntityFrameworkCore;


namespace Application.Services.Interface.Agent;

public interface IAgentService
{

    /// <summary>
    /// get agent information agency
    /// </summary>
    /// <returns></returns>
    Task<AgencyInformationDto> GetMyAgencyInformation(long userId);

    /// <summary>
    /// get list agent negative
    /// </summary>
    /// <returns></returns>
    Task<List<AgentDto>> AgentsReachedNegativeLimit();
    
    /// <summary>
    /// agents 
    /// </summary>
    /// <returns></returns>
    Task<List<AgentDto>> AgentsReachedNegativeNotLimit();
    
    /// <summary>
    /// send list agent
    /// </summary>
    /// <param name="agentId"></param>
    /// <returns></returns>
    Task<List<AgentsIncomesDetail>> ListAgentIncomeDetailsByAgentId(long agentId);

    /// <summary>
    /// get users  by agent Id
    /// </summary>
    /// <param name="agentId"></param>
    /// <returns></returns>
    Task<List<UserDto>?> GetAgentUserAsync(long agentId);

    ///<summary>
    /// after add transaction added agent transaction details 
    /// </summary>
    /// <param name="agentsTransactionsDetails"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task AddAgentsIncomesDetailAsync(List<AgentsIncomesDetail> agentsIncomesDetail, long userId);

    /// <summary>
    /// add agent income async
    /// </summary>
    /// <param name="agentsIncomesDetail"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task AddAgentsIncomesDetailAsync(AgentsIncomesDetail agentsIncomesDetail, long userId);

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
    Task<List<AgentRequestDto>> GetListAgentRequestAsync(long userId);

    /// <summary>
    /// get agent link
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<TelegramLinkDto?> GetAgentTelegramLink(long userId);

    /// <summary>
    /// cheked for user is agent or not agent
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<bool> IsAgentAsync(long userId);

    /// <summary>
    /// send agent information by user id
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<AgentInformationDto?> GetAgentInformationAsync(long userId);

    /// <summary>
    /// update agent async
    /// </summary>
    /// <param name="agent"></param>
    /// <returns></returns>
    Task<bool> UpdateAgentAsync(AgentDto agent, long userId);

    Task<bool> HaveRequestAgentAsync(long userId);

    Task<List<AgentDto>> GetAgentsListAsync();

    /// <summary>
    /// filter agent list async
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    Task<FilterAgentDto> FilterAgentAsync(FilterAgentDto filter);


    Task<AddAgentResult> AddAgentAsync(AddAgentDto agent, long userId);
    Task<List<long>> GetAgentRoot(long agentId);
    Task<AgentDto?> GetAgentByAdminIdAsync(long? adminId);
}