using Domain.DTOs.Sanaei.Client;
using Newtonsoft.Json;

namespace Domain.DTOs.Sanaei.Inbound;

public class GetClientInbound
{
    [JsonProperty("clients")] public List<AddClientDto> Clients { get; set; }
}