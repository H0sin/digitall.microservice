using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities.Wireguard;

public class WireguardVpnTemplate : BaseEntity
{ 
    [Display(Name = "نام نمایشی")] public string? Title { get; set; }

    [Display(Name = "مبلغ")] public long Price { get; set; }

    [Display(Name = "تعداد روز")] public int Days { get; set; }

    [Display(Name = "گیگابایت")] public int Gb { get; set; }

    [ForeignKey(nameof(WireguardVpn))] public long WireguardVpnId { get; set; }
    public WireguardVpn WireguardVpn { get; set; }
}