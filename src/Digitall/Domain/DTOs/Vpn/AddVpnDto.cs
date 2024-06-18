namespace Domain.DTOs.Vpn;

public class AddVpnDto
{
    public List<long> CountryIds { get; set; }
    public long NumberUser { get; set; }
    public long Days { get; set; }
    public long TotalGb { get; set; } = long.MaxValue;
}