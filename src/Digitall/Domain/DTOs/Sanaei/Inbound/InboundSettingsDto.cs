using System.Collections;
using Domain.DTOs.Sanaei.Client;
using Newtonsoft.Json;

namespace Domain.DTOs.Sanaei.Inbound;

public class InboundSettingsDto
{
    [JsonProperty("clients")] public List<AddClientDto> Clients { get; set; }

    [JsonProperty("fallbacks")] public IList FallBacks { get; set; }
}