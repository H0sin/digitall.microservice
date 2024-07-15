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

    public List<string> Vmess { get; set; }
    public List<string> Vless { get; set; }
    public List<string> Shadowsocks { get; set; }
    public List<string> Trojan { get; set; }
    public bool Test_Active { get; set; } = false;

    public long Test_Days { get; set; } = 1;

    public long Test_TotalGb { get; set; } = 1;

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
        Test_Active = vpn.Test_Active;
        Test_Days = vpn.Test_Days;
        Test_TotalGb = vpn.Test_TotalMg;
    }
}