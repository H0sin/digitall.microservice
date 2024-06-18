using Domain.DTOs.Sanaei;
using Domain.DTOs.Sanaei.Client;
using Domain.DTOs.Sanaei.Inbound;

namespace Application.Services.Interface.Sanaei;

public interface ISanaeiService
{
    Task<List<SanaeiInboundDto>> GetInboundsListAsync(long serverId);
    Task<InboundDto> GetInboundByIdAsync(long serverId, long inboundId);
    Task AddInboundAsync(AddInboundDto addInbound, long userId);
    Task UpdateInboundAsync(UpdateInboundDto updateInbound, long userId);
    Task<bool> AddClientAsync(AddClientOptionsDto addClient);
    Task<InboundDto> GetInboundByServerInboundId(long serverId, long sanaeiInboundId);
    Task<bool> DeleteInboundAsync(long inboundId);
    Task<string> GetSanaeiConfigAsync(long clientId, long serverId);
    Task<string> GetClientConfigAsync(GetClientDto client);
}