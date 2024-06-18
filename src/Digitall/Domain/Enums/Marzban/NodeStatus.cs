using Newtonsoft.Json;

namespace Domain.Enums.Marzban;

public enum NodeStatus
{
    [JsonProperty("connected")] Connected = 0,
    [JsonProperty("connecting")] Connecting = 1,
    [JsonProperty("error")] Error = 2,
    [JsonProperty("disabled")] Disabled = 3
}