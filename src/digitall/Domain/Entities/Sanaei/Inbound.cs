using Domain.Common;

namespace Domain.Entities.Sanaei;

public class Inbound : BaseEntity
{
    public long SanaeiInboundId { get; set; }
    public long Up { get; set; }
    public long Down { get; set; }
    public long Total { get; set; }
    public string Listen { get; set; }
    public string? Remark { get; set; }
    public bool Enable { get; set; }
    public long Port { get; set; }
    public long ExpiryTime { get; set; }
    public long ServerId { get; set; }
    public string? Protocol { get; set; }

    public string? Sniffing { get; set; }
    public string? StreamSettings { get; set; }

    public ICollection<Client>? Clients { get; set; }

    public Server.Server? Server { get; set; }
}