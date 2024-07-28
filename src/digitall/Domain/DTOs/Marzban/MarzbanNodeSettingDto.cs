using Newtonsoft.Json;

namespace Domain.DTOs.Marzban;

public class MarzbanNodeSettingDto
{
    [JsonProperty("min_node_version")] public string Min_Node_Version { get; set; }
    [JsonProperty("certificate")] public string Certificate { get; set; }
}