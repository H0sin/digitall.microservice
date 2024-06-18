using Newtonsoft.Json;

namespace Domain.DTOs.Sanaei.Inbound;

public class InboundDto
{
    [JsonProperty("id")] public long Id { get; set; }
    [JsonProperty("up")] public long Up { get; set; }
    [JsonProperty("down")] public long Down { get; set; }
    [JsonProperty("total")] public long Total { get; set; }
    [JsonProperty("listen")] public string Listen { get; set; }
    [JsonProperty("remark")] public string? Remark { get; set; }
    [JsonProperty("enable")] public bool Enable { get; set; }
    [JsonProperty("port")] public long Port { get; set; }
    [JsonProperty("expiryTime")] public long ExpiryTime { get; set; }
    [JsonProperty("protocol")] public string? Protocol { get; set; }

    [JsonProperty("streamSettings")] public string? StreamSettings { get; set; }

    [JsonProperty("sniffing")] public string? Sniffing { get; set; }

    [JsonProperty("settings")] public string? Settings { get; set; }
}