using Newtonsoft.Json;

namespace Domain.DTOs.Sanaei.Client;

public class AddClientDto
{
    [JsonProperty("password")] public string Password { get; set; }

    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("alterId")] public long AlterId { get; set; }

    [JsonProperty("email")] public required string Email { get; set; }

    [JsonProperty("limitIp")] public long LimitIp { get; set; } = 1;

    [JsonProperty("totalGb")] public long TotalGb { get; set; }

    [JsonProperty("expiryTime")] public long ExpiryTime { get; set; }

    [JsonProperty("enable")] public bool Enable { get; set; }

    [JsonProperty("subId")] public string SubId { get; set; }

    [JsonProperty("tgId")] public string? TgId { get; set; }
}