namespace Domain.Entities.Sanaei;

public class InboundSniffing
{
    public bool Enabled { get; set; }

    public List<string>? DestOverride { get; set; }
}