using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Agent;
using Domain.IRepositories.Agent;

namespace Data.Repositories.Agent;

public class AgentOptionRepository(DigitallDbContext context)
    : BaseRepository<AgentOptions>(context), IAgentOptionRepository;