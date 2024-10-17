using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Wireguard;
using Domain.IRepositories.Wireguard;

namespace Data.Repositories;

public class WireguardVpnRepository(DigitallDbContext context)
    : BaseRepository<WireguardVpn>(context), IWireguardVpnRepository;

public class WireguardServerRepository(DigitallDbContext context)
    : BaseRepository<WireguardServer>(context), IWireguardServerRepository;

public class PeerRepository(DigitallDbContext context) : BaseRepository<Peer>(context), IPeerRepository;

public class WireguardVpnTemplateRepository(DigitallDbContext context)
    : BaseRepository<WireguardVpnTemplate>(context), IWireguardVpnTemplateRepository;