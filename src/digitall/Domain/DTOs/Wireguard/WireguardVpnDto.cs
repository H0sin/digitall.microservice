using Domain.Entities.Wireguard;

namespace Domain.DTOs.Wireguard;

public class WireguardVpnDto
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public int GbMax { get; set; }
    public int GbMin { get; set; }
    public long GbPrice { get; set; }
    public int DayMax { get; set; }
    public int DayMin { get; set; }
    public long DayPrice { get; set; }
    public bool Desired { get; set; }
    public bool Test_Active { get; set; } = false;
    public int Test_Days { get; set; } = 1;
    public int Test_TotalMg { get; set; } = 1;
    public ICollection<WireguardVpnTemplatesDto>? WireguardVpnTemplates { get; set; }

    public WireguardVpnDto(WireguardVpn wireguardVpn, ICollection<WireguardVpnTemplate>? wireguardVpnTemplates)
    {
        Id = wireguardVpn.Id;
        Name = wireguardVpn.Name;
        GbMax = wireguardVpn.GbMax;
        GbMin = wireguardVpn.GbMin;
        GbPrice = wireguardVpn.GbPrice;
        DayMax = wireguardVpn.DayMax;
        DayMin = wireguardVpn.DayMin;
        DayPrice = wireguardVpn.DayPrice;
        Desired = wireguardVpn.Desired;
        Test_Active = wireguardVpn.Test_Active;
        Test_Days = wireguardVpn.Test_Days;
        Test_TotalMg = wireguardVpn.Test_TotalMg;
        WireguardVpnTemplates = wireguardVpnTemplates?.Select(x => new WireguardVpnTemplatesDto(x)).ToList() ?? null;
    }

    public WireguardVpnDto(WireguardVpn wireguardVpn)
    {
        Id = wireguardVpn.Id;
        Name = wireguardVpn.Name;
        GbMax = wireguardVpn.GbMax;
        GbMin = wireguardVpn.GbMin;
        GbPrice = wireguardVpn.GbPrice;
        DayMax = wireguardVpn.DayMax;
        DayMin = wireguardVpn.DayMin;
        DayPrice = wireguardVpn.DayPrice;
        Desired = wireguardVpn.Desired;
        Test_Active = wireguardVpn.Test_Active;
        Test_Days = wireguardVpn.Test_Days;
        Test_TotalMg = wireguardVpn.Test_TotalMg;
    }
    
    public WireguardVpnDto()
    {
    }
}