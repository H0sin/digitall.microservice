using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Marzban;
using Domain.IRepositories.Marzban;

namespace Data.Repositories.Marzban;

public class MarzbanServerRepository(DigitallDbContext context)
    : BaseRepository<MarzbanServer>(context), IMarzbanServerRepository;