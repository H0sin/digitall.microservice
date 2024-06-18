using Newtonsoft.Json;

namespace Domain.DTOs.Sanaei.Base;

public class BaseRequestSanaei
{
    [JsonProperty("id")] public long Id { get; set; }

    [JsonProperty("settings")] public string Settings { get; set; }
}