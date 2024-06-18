using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Sanaei;
using Domain.IRepositories.Base;

namespace Data.Repositories.Sanaei;

public class InboundRepository(DigitallDbContext context)
    : BaseRepository<Inbound>(context), Domain.IRepositories.Sanaei.IInboundRepository;