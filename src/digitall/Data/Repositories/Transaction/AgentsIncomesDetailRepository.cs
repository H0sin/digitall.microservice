using Data.Context;
using Data.Repositories.Base;
using Domain.Common;
using Domain.Entities.Transaction;
using Domain.IRepositories.Transaction;

namespace Data.Repositories.Transaction;

public class AgentsIncomesDetailRepository(DigitallDbContext context)
    : BaseRepository<AgentsIncomesDetail>(context),
        IAgentsIncomesDetailRepository;