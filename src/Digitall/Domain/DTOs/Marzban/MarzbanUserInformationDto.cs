using Newtonsoft.Json;

namespace Domain.DTOs.Marzban;

public class MarzbanUserInformationDto
{
    [JsonProperty("links")] public List<string> Links { get; set; }
}