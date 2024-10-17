using Domain.Common;

namespace Domain.Entities.Wireguard;

public class WireguardServer : BaseEntity
{
    public string? Ip { get; set; }
    public bool Ssl { get; set; }
    public int Port { get; set; }
    public List<WireguardVpn>? WireguardVpn { get; set; }
}