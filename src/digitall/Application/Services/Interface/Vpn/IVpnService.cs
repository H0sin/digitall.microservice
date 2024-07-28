using Domain.DTOs.Marzban;
using Domain.DTOs.Vpn;
using Domain.Enums.Vpn;

namespace Application.Services.Interface.Vpn;

public interface IVpnService
{
    // Task<bool> BuyMarzbanVpnAsync(BuyMarzbanVpnDto marzban,long userId);
    Task BuyVpnAsync(BuyVpnDto buyVpn, long userId);
    Task<Domain.Entities.Vpn.Vpn> GetVpnByIdAsync(long Id);
    Task<Domain.Entities.Vpn.Vpn?> AddVpnAsync(AddVpnDto vpn, long userId);
    Task<FilterVpnDto> FilterVpnAsync(FilterVpnDto filter, long userId);
}