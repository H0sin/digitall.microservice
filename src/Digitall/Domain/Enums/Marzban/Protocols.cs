namespace Domain.Enums.Marzban;

[Flags]
public enum Protocols : byte
{
    Vmess,
    Vless,
    Trojan,
    Shadowsocks
}