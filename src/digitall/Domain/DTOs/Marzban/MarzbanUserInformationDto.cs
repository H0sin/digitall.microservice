using Newtonsoft.Json;

namespace Domain.DTOs.Marzban;

public class MarzbanUserInformationDto
{
    [JsonProperty("links")] public List<string> Links { get; set; }

    [JsonProperty("subscription_url")] public string? Subscription_Url { get; set; }

    [JsonProperty("username")] public string? Username { get; set; }
}