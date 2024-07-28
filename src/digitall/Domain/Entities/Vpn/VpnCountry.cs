using Domain.Common;

namespace Domain.Entities.Vpn;

public class VpnCountry : BaseEntity
{
    public long VpnId { get; set; }
    public long CountryId { get; set; }

    public Vpn Vpn { get; set; }
    public Country.Country Country { get; set; }
}