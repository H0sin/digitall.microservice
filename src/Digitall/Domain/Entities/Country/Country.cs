using System.ComponentModel.DataAnnotations;
using Domain.Common;
using Domain.Entities.Vpn;

namespace Domain.Entities.Country;

public class Country : BaseEntity
{
    #region properties

    [Display(Name = "نام کشور")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(20, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Name { get; set; }

    #endregion

    #region relations

    public ICollection<Server.Server> Servers { get; set; }
    public ICollection<VpnCountry> VpnCountries { get; set; }

    #endregion
}