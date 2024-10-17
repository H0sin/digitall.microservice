using Domain.Entities.Wireguard;

namespace Domain.DTOs.Wireguard;

public class WireguardVpnTemplatesDto
{
    public string? Title { get; set; }

    public long Price { get; set; }

    public int Days { get; set; }

    public int Gb { get; set; }

    public long WireguardVpnId { get; set; }

    public long Id { get; set; }

    public WireguardVpnTemplatesDto()
    {
        
    }

    public WireguardVpnTemplatesDto(WireguardVpnTemplate templates)
    {
        Title = templates.Title;
        Price = templates.Price;
        Days = templates.Days;
        Gb = templates.Gb;
        WireguardVpnId = templates.WireguardVpnId;
        Id = templates.Id;
    }

    public WireguardVpnTemplatesDto(WireguardVpnTemplate templates,long price)
    {
        Title = templates.Title;
        Price = price;
        Days = templates.Days;
        Gb = templates.Gb;
        WireguardVpnId = templates.WireguardVpnId;
        Id = templates.Id;
    }
}