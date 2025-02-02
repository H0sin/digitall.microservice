using Data.Context;
using Data.Repositories.Base;
using Domain.IRepositories.Server;

namespace Data.Repositories.Server;

public class ServerRepository(DigitallDbContext context)
    : BaseRepository<Domain.Entities.Server.Server>(context), IServerRepository;