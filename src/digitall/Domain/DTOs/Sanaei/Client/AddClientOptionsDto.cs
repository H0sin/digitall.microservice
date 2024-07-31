namespace Domain.DTOs.Sanaei.Client;

public class AddClientOptionsDto
{
    public AddClientOptionsDto(long vpnId, long serverId, long userId, int count, long countryId, List<string> guids,
        long orderDetailId,
        AddClientDto client)
    {
        OrderDetailId = orderDetailId;
        Client = client;
        VpnId = vpnId;
        ServerId = serverId;
        UserId = userId;
        Count = count;
        CountryId = countryId;
        Guids = guids;
    }

    public long VpnId { get; set; }
    public long ServerId { get; set; }
    public AddClientDto Client { get; set; }
    public long UserId { get; set; }
    public int Count { get; set; }
    public long CountryId { get; set; }
    public List<string> Guids { get; set; }
    public long OrderDetailId { get; set; }
}