using Data.Context;
using Data.Repositories.Base;
using Domain.IRepositories.Vpn;

namespace Data.Repositories.Vpn;

public class VpnRepository : BaseRepository<Domain.Entities.Vpn.Vpn>, IVpnRepository
{
    public VpnRepository(DigitallDbContext context) : base(context)
    {
    }
}