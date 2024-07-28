using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Vpn;
using Domain.IRepositories.Vpn;

namespace Data.Repositories.Vpn;

public class VpnCountryRepository(DigitallDbContext context)
    : BaseRepository<VpnCountry>(context), IVpnCountryRepository;