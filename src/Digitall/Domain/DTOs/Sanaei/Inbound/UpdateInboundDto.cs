namespace Domain.DTOs.Sanaei.Inbound;

public class UpdateInboundDto
{
    public long Id { get; set; }
    public string Listen { get; set; }
    public string? Remark { get; set; }
    public bool Enable { get; set; }
    public long Port { get; set; }
    public long ExpiryTime { get; set; }
    public string? Protocol { get; set; }
}