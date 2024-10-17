namespace Domain.DTOs.Wireguard;

public class GetPeerFromServerDto
{
    public string? Name { get; set; }
    public string? PublicKey { get; set; }
    public string? PrivateKey { get; set; }
    public string? PresharedKey { get; set; }
    public string? AllowedIPs { get; set; }
    public string? EndPoint { get; set; }
    public string? EndpointAllowedIPs { get; set; }
    public string? Dns { get; set; }
    public int? Mtu { get; set; } = 1420;
    public int? PersistentKeepalive { get; set; }
    public long TotalReceivedVolume { get; set; }
    public long DownloadVolume { get; set; }
    public long UploadVolume { get; set; }
    public long StartTime { get; set; }
    public long ExpireTime { get; set; }
    public long TotalVolume { get; set; }
    public string Status { get; set; }
    public long OnHoldExpireDurection { get; set; } = 0;
    public long LastTotalReceivedVolume { get; set; } = 0;
    public long LastDownloadVolume { get; set; } = 0;
    public long LastUploadVolume { get; set; } = 0;
}