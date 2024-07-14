using Newtonsoft.Json;

namespace Domain.DTOs.Marzban;

public class RenewalMarzbanUserDto
{
    public long Id { get; set; }
    [JsonProperty("username")] public string Username { get; set; }
    [JsonProperty("expire")] public string Expire { get; set; }
    [JsonProperty("data_limit")] public string Data_Limit { get; set; }

}