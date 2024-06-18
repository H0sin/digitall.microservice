using Newtonsoft.Json;

namespace Domain.DTOs.Marzban;

public class ProxiesDto(
    object vmess,
    object vless,
    object trojan,
    object shadowsocks)
{
    [JsonProperty("vmess")] object Vmess { get; set; } = vmess;
    [JsonProperty("vless")] object Vless { get; set; } = vless;
    [JsonProperty("trojan")] object Trojan { get; set; } = trojan;
    [JsonProperty("shadowsocks")] object Shadowsocks { get; set; } = shadowsocks;
};