using System.ComponentModel.DataAnnotations;

namespace Domain.Enums.Order;

public enum OrderDeatilType
{
    [Display(Name = "خرید وی پی ان")] Vpn = 1,
    [Display(Name = "وایرگارد")] Wireguard = 2
}