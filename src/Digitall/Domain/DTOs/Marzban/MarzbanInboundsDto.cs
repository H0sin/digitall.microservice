using Domain.Enums.Marzban;
using Newtonsoft.Json;

namespace Domain.DTOs.Marzban;

public class MarzbanInboundsDto
{
    [JsonProperty("vmess")] public List<Vmess> Vmess { get; set; }

    [JsonProperty("vless")] public List<Vless> Vless { get; set; }

    [JsonProperty("trojan")] public List<Trojan> Trojan { get; set; }

    [JsonProperty("shadowsocks")] public List<Shadowsocks> Shadowsocks { get; set; }
}

public class BaseInbound
{
    [JsonProperty("tag")] public string Tag { get; set; }
    [JsonProperty("protocol")] public Protocols Protocol { get; set; }
    [JsonProperty("network")] public string Network { get; set; }
    [JsonProperty("tls")] public string Tls { get; set; }
    [JsonProperty("port")] public string Port { get; set; }
}

public class Vmess : BaseInbound
{
}

public class Vless : BaseInbound
{
}

public class Trojan : BaseInbound
{
}

public class Shadowsocks : BaseInbound
{
}