using Data.Context;
using Data.Repositories.Base;
using Domain.Common;
using Domain.Entities.Agent;
using Domain.IRepositories.Agent;

namespace Data.Repositories.Agent;

public class AgentRequestRepository(DigitallDbContext context)
    : BaseRepository<AgentRequest>(context), IAgentRequestRepository;