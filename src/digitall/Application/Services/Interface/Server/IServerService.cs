using Domain.DTOs.Server;
using Domain.Enums.Server;

namespace Application.Services.Interface.Server;

public interface IServerService
{
    /// <summary>
    /// for set user id when save information
    /// </summary>
    public long UserId { get; set; }

    Task<AddServerResult> AddServerAsync(AddServerDto server);
    Task<List<ServerDto>> GetServersAsync();
    Task<ServerDto?> GetServerByIdAsync(long serverId);
    Task<FilterServerDto> FilterServerAsync(FilterServerDto filter);
    Task<bool> TestServerAsync(long serverId);
}