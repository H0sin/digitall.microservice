using Domain.Entities.Marzban;

namespace Domain.DTOs.Marzban;

public class GetMarzbanVpnDto
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public long GbMax { get; set; }
    public long GbMin { get; set; }
    public long GbPrice { get; set; }
    public long DayMax { get; set; }
    public long DayMin { get; set; }
    public long DayPrice { get; set; }
    public long MarzbanServerId { get; set; }

    public GetMarzbanVpnDto(MarzbanVpn vpn)
    {
        GbMax = vpn.GbMax;
        GbMin = vpn.GbMin;
        GbPrice = vpn.GbPrice;
        DayMax = vpn.DayMax;
        DayMin = vpn.DayMin;
        DayPrice = vpn.DayPrice;
        MarzbanServerId = vpn.MarzbanServerId;
        Name = vpn.Name;
        Id = vpn.Id;
    }
}