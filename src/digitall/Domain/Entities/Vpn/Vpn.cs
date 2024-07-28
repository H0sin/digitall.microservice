using Domain.Common;

namespace Domain.Entities.Vpn;

public class Vpn : BaseEntity
{
    #region peroperties

    public long Days { get; set; } = 1;
    public long ServerId { get; set; }
    public long TotoalGb { get; set; } = long.MaxValue;
    public long NumberUser { get; set; } = 1;

    #endregion

    #region relation

    public Product.Product? Product { get; set; }

    public ICollection<VpnCountry>? VpnCountries { get; set; }

    #endregion
}