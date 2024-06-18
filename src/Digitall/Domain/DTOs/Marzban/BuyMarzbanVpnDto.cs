using System.ComponentModel.DataAnnotations;
using Domain.Entities.Marzban;

namespace Domain.DTOs.Marzban;

public class BuyMarzbanVpnDto
{
    [Display(Name = "تعداد")]
    [Range(0, 20, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public int Count { get; set; }

    [MaxLength(50)][Required] public string? Title { get; set; }
    public long MarzbanVpnId { get; set; }
    public long TotalGb { get; set; } = 1;
    public long TotalDay { get; set; } = 1;
    public long TotalUser { get; set; } = 1;

    public long CountingPrice(MarzbanVpn vpn)
    {
        if (TotalDay > vpn.DayMax || TotalDay < vpn.DayMin)
            throw new ApplicationException("نمیتواند اینقدر روز برای vpn باشد");

        if (TotalGb > vpn.GbMax || TotalGb < vpn.GbMin)
            throw new ApplicationException("نمیتواند اینقدر گیگ برای vpn باشد");

        long price = TotalGb * vpn.GbPrice + TotalDay * vpn.DayPrice;

        return price;
    }
}