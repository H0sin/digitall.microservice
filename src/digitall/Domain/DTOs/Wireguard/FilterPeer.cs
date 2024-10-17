using Domain.DTOs.Paging;

namespace Domain.DTOs.Wireguard;

public class FilterPeer : BasePaging<PeerDto>
{
    public long? UserId { get; set; }
    public string? Name { get; set; }
}