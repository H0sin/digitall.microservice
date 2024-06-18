using Data.Context;
using Data.Repositories.Base;
using Domain.IRepositories.Server;

namespace Data.Repositories.Server;

public class ServerRepository : BaseRepository<Domain.Entities.Server.Server>, IServerRepository
{
    public ServerRepository(DigitallDbContext context) : base(context)
    {
    }
}