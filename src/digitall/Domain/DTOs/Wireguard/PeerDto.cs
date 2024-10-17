using Domain.Entities.Wireguard;

namespace Domain.DTOs.Wireguard;

public class PeerDto
{
    public string Name { get; set; }
    public long Id { get; set; }
    public PeerDto(Peer peer)
    {
        Name = peer.Name;
        Id = peer.Id;
    }
}