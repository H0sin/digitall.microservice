using Data.Context;
using Data.Repositories.Base;
using Domain.IRepositories.Agent;
using Domain.IRepositories.Base;

namespace Data.Repositories.Agent;

public class AgentRepository : BaseRepository<Domain.Entities.Agent.Agent>, IAgentRepository
{
    public AgentRepository(DigitallDbContext context) : base(context)
    {
    }
}