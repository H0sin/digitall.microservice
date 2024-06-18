using Domain.Enums.Marzban;
using Newtonsoft.Json;

namespace Domain.DTOs.Marzban;

public class MarzbanNodeDto
{
    [JsonProperty("name")] public string Name { get; set; }
    [JsonProperty("address")] public string Address { get; set; }
    [JsonProperty("port")] public int Port { get; set; }
    [JsonProperty("api_port")] public int Api_Port { get; set; }
    [JsonProperty("usage_coefficient")] public decimal Usage_Coefficient { get; set; }
    [JsonProperty("id")] public long Id { get; set; }
    [JsonProperty("xray_version")] public string Xray_Version { get; set; }
    [JsonProperty("status")] public NodeStatus Status { get; set; }
    [JsonProperty("message")] public string Message { get; set; }
}