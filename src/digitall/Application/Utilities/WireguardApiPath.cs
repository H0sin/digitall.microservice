using Application.Services.Implementation.Wireguard;
using Domain.Entities.Wireguard;

namespace Application.Utilities;

public static class WireguardApiPath
{
    public static string AddPeer(WireguardServer server, string interfaceName) => string.Format(
        "{0}://{1}:{2}/Peer/{3}",
        server.Ssl ? "https" : "http", server.Ip, server.Port, interfaceName);

    public static string GetPeerConfig(WireguardServer server, string name)
        => string.Format("{0}://{1}:{2}/Peer/GetPeerConfig/{3}", server.Ssl ? "https" : "http", server.Ip, server.Port,
            name);

    public static string GetPeer(WireguardServer server, string name)
        => string.Format("{0}://{1}:{2}/Peer/{3}", server.Ssl ? "https" : "http", server.Ip, server.Port,
            name);

    public static string ResetPeer(WireguardServer? server, string? peerName)
        => string.Format("{0}://{1}:{2}/Peer/Reset/{3}", server?.Ssl ?? false ? "https" : "http", server?.Ip,
            server?.Port, peerName);

    public static string DeletePeer(WireguardServer? server, string? peerName)
        => string.Format("{0}://{1}:{2}/Peer/{3}", server?.Ssl ?? false ? "https" : "http", server?.Ip,
            server?.Port, peerName);

    public static string ActivePeer(WireguardServer? server, string? peerName)
        => string.Format("{0}://{1}:{2}/Peer/Active/{3}", server?.Ssl ?? false ? "https" : "http", server?.Ip,
            server?.Port, peerName);

    public static string DisabledPeer(WireguardServer? server, string? peerName)
        => string.Format("{0}://{1}:{2}/Peer/Disabled/{3}", server?.Ssl ?? false ? "https" : "http", server?.Ip,
            server?.Port, peerName);
}