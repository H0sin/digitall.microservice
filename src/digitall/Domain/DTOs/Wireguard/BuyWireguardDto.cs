namespace Domain.DTOs.Wireguard;

public class BuyWireguardDto
{
    public long? WireguardVpnTemplateId { get; set; }
    public long WireguardVpnId { get; set; }

    public long? PeerId { get; set; }
}