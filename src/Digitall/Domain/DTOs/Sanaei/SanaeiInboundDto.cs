using Domain.DTOs.Sanaei.Client;

namespace Domain.DTOs.Sanaei;

public class SanaeiInboundDto
{
    public long Id { get; set; }
    public long Up { get; set; }
    public long Down { get; set; }
    public long Total { get; set; }
    public string Remark { get; set; }
    public bool Enable { get; set; }
    public long ExpiryTime { get; set; }
    public List<ClientDto> ClientStats { get; set; }
}