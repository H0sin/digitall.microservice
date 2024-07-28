namespace Domain.DTOs.Sanaei.Client;

public class ClientDto
{
    public long Id { get; set; }
    public long InboundId { get; set; }
    public bool Enable { get; set; }
    public string? Email { get; set; }
    public long Up { get; set; }
    public long Down { get; set; }
    public long ExpiryTime { get; set; }
    public long Total { get; set; }
    public long Reset { get; set; }
}