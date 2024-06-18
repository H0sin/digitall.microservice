namespace Domain.DTOs.Vpn;

public class VpnDto
{
    public long Id { get; set; }
    public string? ProductName { get; set; }
    public string? ProductImage { get; set; }
    public string? Description { get; set; }
    public long Price { get; set; }
    public long Days { get; set; }
    public long? ServerId { get; set; }
    public long NumberUser { get; set; }
}