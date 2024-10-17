using Domain.Entities.Wireguard;
using Domain.IRepositories.Base;

namespace Domain.IRepositories.Wireguard;

public interface IWireguardVpnRepository : IBaseRepository<WireguardVpn>;

public interface IWireguardServerRepository : IBaseRepository<WireguardServer>;

public interface IPeerRepository : IBaseRepository<Peer>;

public interface IWireguardVpnTemplateRepository : IBaseRepository<WireguardVpnTemplate>;