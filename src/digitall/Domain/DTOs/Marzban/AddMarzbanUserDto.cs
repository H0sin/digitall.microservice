using Newtonsoft.Json;

namespace Domain.DTOs.Marzban;

public class AddMarzbanUserDto
{
    [JsonProperty("username")] public string Username { get; set; }

    [JsonProperty("proxies")] public object Proxies { get; set; } = new();

    [JsonProperty("inbounds")] public object Inbounds { get; set; } = new();

    [JsonProperty("expire")] public string Expire { get; set; }
    [JsonProperty("data_limit")] public long Data_Limit { get; set; }

    [JsonProperty("data_limit_reset_strategy")]
    public string Data_Limit_Reset_Strategy { get; set; }

    [JsonProperty("status")] public string Status { get; set; }
    [JsonProperty("note")] public string Note { get; set; }
    [JsonProperty("on_hold_timeout")] public string? On_Hold_Timeout { get; set; }

    [JsonProperty("on_hold_expire_duration")]
    public long On_Hold_Expire_Duration { get; set; }
}