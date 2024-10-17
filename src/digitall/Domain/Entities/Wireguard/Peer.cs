using Domain.Common;

namespace Domain.Entities.Wireguard;

public class Peer : BaseEntity
{
    public WireguardVpn? WireguardVpn { get; set; }
    public long WireguardVpnId { get; set; }
    public string? Name { get; set; }
    public long UserId { get; set; }
    public long? TotalVolume { get; set; }
    public long? TotalDay { get; set; }
    public long WireguardServerId { get; set; }
    public long OrderId { get; set; }

    public string? DeleteDescription { get; set; }
}