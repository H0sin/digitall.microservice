using Newtonsoft.Json;

namespace Domain.DTOs.Marzban;

public class AddMarzbanNodeDto
{
    [JsonProperty("name")] public string Name { get; set; }
    [JsonProperty("address")] public string Address { get; set; }
    [JsonProperty("port")] public int Port { get; set; }
    [JsonProperty("api_port")] public int Api_Port { get; set; }
    [JsonProperty("add_as_new_host")] public bool Add_As_New_Host { get; set; }
    [JsonProperty("usage_coefficient")] public decimal Usage_Coefficient { get; set; }
}