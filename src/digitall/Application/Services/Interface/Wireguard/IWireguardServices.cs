using Domain.DTOs.Wireguard;
using Domain.Entities.Wireguard;

namespace Application.Services.Interface.Wireguard;

/// <summary>
/// Interface for Wireguard services, providing methods to manage Wireguard VPNs and peers.
/// </summary>
public interface IWireguardServices
{
    /// <summary>
    /// Gets a list of Wireguard VPNs.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of Wireguard VPN DTOs.</returns>
    Task<List<WireguardVpnDto>> GetWireguardVpnAsync();

    /// <summary>
    /// Gets a Wireguard VPN by its ID.
    /// </summary>
    /// <param name="id">The ID of the Wireguard VPN.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the Wireguard VPN DTO if found; otherwise, null.</returns>
    Task<WireguardVpnDto?> GetWireguardVpnByIdAsync(long id);

    /// <summary>
    /// Counts the price of a Wireguard VPN template.
    /// </summary>
    /// <param name="vpnId">The ID of the VPN.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="days">The number of days for the VPN template.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a collection of Wireguard VPN template DTOs.</returns>
    Task<ICollection<WireguardVpnTemplatesDto>>
        CountingWireguardVpnTemplatePrice(long vpnId, long userId, int days = 0);

    /// <summary>
    /// Gets a Wireguard VPN by its ID and counts the price.
    /// </summary>
    /// <param name="id">The ID of the Wireguard VPN.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the Wireguard VPN template DTO if found; otherwise, null.</returns>
    Task<WireguardVpnTemplatesDto?> CountingWireguardVpnTemplatePriceByIdAsync(long id, long userId);

    /// <summary>
    /// Buys a Wireguard account.
    /// </summary>
    /// <param name="buy">The DTO containing the purchase details.</param>
    /// <param name="userId">The ID of the user (optional).</param>
    /// <param name="chatId">The ID of the chat (optional).</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response DTO for the purchase.</returns>
    Task<BuyWireguardResponseDto> BuyWireguardAccountAsync(BuyWireguardDto buy, long? userId = null,
        long? chatId = null);

    /// <summary>
    /// Gets a list of Wireguard VPNs that have a test available.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a collection of Wireguard VPN DTOs.</returns>
    Task<ICollection<WireguardVpnDto>> GetWireguardVpnsHaveTest();

    /// <summary>
    /// Buys a test Wireguard account.
    /// </summary>
    /// <param name="id">The ID of the Wireguard VPN.</param>
    /// <param name="userId">The ID of the user (optional).</param>
    /// <param name="chatId">The ID of the chat (optional).</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response DTO for the test purchase.</returns>
    Task<BuyWireguardResponseDto> BuyWireguardAccountTestAsync(long id, long? userId = null, long? chatId = null);

    /// <summary>
    /// Filters peers asynchronously.
    /// </summary>
    /// <param name="filter">The filter criteria.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the filtered peers.</returns>
    Task<FilterPeer> FilterPeerAsync(FilterPeer filter);

    /// <summary>
    /// get peers asynchronously.
    /// </summary>
    /// <param name="userId">user id</param>
    /// <returns>list peer</returns>
    Task<List<PeerDto>> GetPeersAsync(long userId);

    /// <summary>
    /// Gets peer information by its ID.
    /// </summary>
    /// <param name="id">The ID of the peer.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the peer information DTO if found; otherwise, null.</returns>
    Task<PeerInformationDto?> GetPeerInformationByIdAsync(long id);

    /// <summary>
    /// Sends connection details for a file or QR code.
    /// </summary>
    /// <param name="id">The ID of the peer.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a tuple with the connection details as strings.</returns>
    Task<(string, string)> SendConnectionDetailsAsync(long id, long userId);

    /// <summary>
    /// Renews a Wireguard account.
    /// </summary>
    /// <param name="buy">The DTO containing the renewal details.</param>
    /// <param name="chatId">The ID of the chat.</param>
    /// <param name="userId">The ID of the user</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response DTO for the renewal.</returns>
    Task<BuyWireguardResponseDto> RenewalWireguardAccount(BuyWireguardDto buy, long? chatId = null, long? userId = null);

    /// <summary>
    /// Checks if there are any deleted Wireguard services in the delete queue for a given user and peer.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating whether there are deleted Wireguard services in the delete queue.</returns>
    Task<bool> HaveDeletedWireguardServicesInDeleteQue(long userId);

    /// <summary>
    /// Requests the deletion of a Wireguard service.
    /// </summary>
    /// <param name="delete">The DTO containing the details of the Wireguard service to be deleted.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task RequestDeletedWireguardService(DeleteWireguardServiceDto delete);

    /// <summary>
    /// Main method to delete a Wireguard service.
    /// </summary>
    /// <param name="id">The ID of the Wireguard service.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task MainDeleteWireguardService(long id, long userId);

    /// <summary>
    /// Changes the deleted status of a Wireguard service.
    /// </summary>
    /// <param name="id">The ID of the Wireguard service.</param>
    /// <param name="deleted">The new deleted status.</param>
    /// <param name="userId"></param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task ChangeDeletedStatus(long id, bool deleted, long userId);
    
    /// <summary>
    /// Activates a Wireguard account.
    /// </summary>
    /// <param name="id">The ID of the Wireguard account to activate.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task ActiveWireguardAccount(long id);
    
    /// <summary>
    /// Disabled a Wireguard account.
    /// </summary>
    /// <param name="id">The ID of the Wireguard account to activate.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task DisabledWireguardAccount(long id);
}