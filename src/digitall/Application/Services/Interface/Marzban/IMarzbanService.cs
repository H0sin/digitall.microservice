using Domain.DTOs.Marzban;
using Domain.Entities.Marzban;
using Domain.Enums.Marzban;

namespace Application.Services.Interface.Marzban;

public interface IMarzbanService
{
    /// <summary>
    /// for add marzban server
    /// </summary>
    /// <param name="marzban"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task AddMarzbanServerAsync(AddMarzbanServerDto marzban, long userId);

    /// <summary>
    /// get marzban server by id 
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    Task<MarzbanServer> GetMarzbanServerByIdAsync(long Id);

    /// <summary>
    /// for test marzban server befor added
    /// to database by login to server
    /// </summary>
    /// <param name="marzbanServer"></param>
    /// <returns></returns>
    Task<bool> MarzbanServerIsSuccess(MarzbanServer marzbanServer);

    // Task AddNodeAsync();
    /// <summary>
    /// reaset core
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    Task ReasetMarzbanServerCore(long serverId);

    /// <summary>
    /// get marzban server configs
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns>configs</returns>
    Task<string> GetMarzbanServerCoreConfigAsync(long serverId);

    /// <summary>
    /// get marzban server list inbouds for added vpn
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    Task<MarzbanInboundsDto> GetMarzbanInboudsAsync(long serverId);

    /// <summary>
    /// update marzban server core config
    /// </summary>
    /// <param name="serverId"></param>
    /// <param name="core"></param>
    /// <returns></returns>
    Task<string> UpdateMarzbanServerCoreConfigAsync(long serverId, object core);

    /// <summary>
    /// get marzban node settings for add node
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    Task<MarzbanNodeSettingDto> GetMarzbanServerNodeSettingsAsync(long serverId);

    /// <summary>
    /// add marzban node by certificate
    /// </summary>
    /// <param name="serverId"></param>
    /// <param name="node"></param>
    /// <returns></returns>
    Task<MarzbanNodeDto> AddMarzbanNodeAsync(long serverId, AddMarzbanNodeDto node);


    /// <summary>
    /// get marzban node by id
    /// </summary>
    /// <param name="serverId"></param>
    /// <param name="nodeId"></param>
    /// <returns></returns>
    Task<MarzbanNodeDto> GetMarzbanNodeByIdAsync(long serverId, long nodeId);

    /// <summary>
    /// update marzban node by id async
    /// </summary>
    /// <param name="serverId"></param>
    /// <param name="nodeId"></param>
    /// <param name="node"></param>
    /// <returns></returns>
    Task<MarzbanNodeDto> UpdateMarzbanServerNodeAsync(long serverId, long nodeId, AddMarzbanNodeDto node);

    /// <summary>
    /// delete marzban node by id async
    /// </summary>
    /// <param name="serverId"></param>
    /// <param name="nodeId"></param>
    /// <returns></returns>
    Task DeleteNodeByIdAsync(long serverId, long nodeId);

    /// <summary>
    /// get all nodes from marzban server
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    Task<List<MarzbanNodeDto>> GetMarzbanNodeAsync(long serverId);

    /// <summary>
    /// for buy vpn
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    Task<List<MarzbanUser>> AddMarzbanUserAsync(List<AddMarzbanUserDto> users, long serverId);

    /// <summary>
    /// for performance
    /// </summary>
    /// <param name="user"></param>
    /// <param name="server"></param>
    /// <returns></returns>
    Task AddMarzbanUserAsync(List<AddMarzbanUserDto> users, MarzbanServer server);

    /// <summary>
    /// get marzban server by id for counting client
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns></returns>
    Task<GetMarzbanServerOptionDto> GetMarzbanServerAsync(long serverId);

    /// <summary>
    /// get all marzban server for drop down list in client
    /// </summary>
    /// <returns></returns>
    Task<List<GetMarzbanServerOptionDto>> GetMarzbanServersAsync();

    /// <summary>
    /// add vpn for marzban
    /// <remarks>for server or append server</remarks>
    /// </summary>
    /// <param name="vpn"></param>
    /// <returns></returns>
    Task AddMarzbanVpnAsync(AddMarzbanVpnDto vpn, long userId);

    /// <summary>
    /// get list marzban vpn for buy vpn from vpn service
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyList<GetMarzbanVpnDto>> GetMarzbanVpnAsync(long userId, int numberOfAgents = 2);

    /// <summary>
    /// buy marzban vpn
    /// </summary>
    /// <param name="vpn"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<List<MarzbanUser>> BuyMarzbanVpnAsync(BuyMarzbanVpnDto vpn, long userId);

    /// <summary>
    /// get marzban user information
    /// befor get info checked access config or not
    /// but have 2 action for admin
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<MarzbanUserInformationDto> GetMarzbanUserInformationAsync(string userName, long? userId = null);

    /// <summary>
    /// get list subscibe
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<List<string>> GetMarzbanUsersByUserId(long userId);

    /// <summary>
    /// total price 0
    /// test account in marzban
    /// </summary>
    /// <returns></returns>
    Task<MarzbanUser?> BuyMarzbanTestVpnAsync(long vpnId, long userId);

    /// <summary>
    /// get list marzban vpns
    /// </summary>
    /// <returns></returns>
    Task<List<MarzbanVpnBotDto>> GetListMarzbanVpns();

    /// <summary>
    /// get list marzban vpn are test
    /// </summary>
    /// <returns></returns>
    Task<List<MarzbanVpnTestDto>> GetListMarzbanVpnsTest();

    /// <summary>
    /// get marzban vpn by id async
    /// </summary>
    /// <param name="vpnId"></param>
    /// <returns></returns>
    Task<GetMarzbanVpnDto?> GetMarzbanVpnByIdAsync(long vpnId, long userId);

    /// <summary>
    /// get marzban vpn by id async
    /// </summary>
    /// <param name="vpnId"></param>
    /// <returns></returns>
    Task<GetMarzbanVpnDto?> GetMarzbanVpnByIdAsync(long vpnId);

    /// <summary>
    /// add marzban vpn template
    /// </summary>
    /// <param name="template"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task AddMarzbanVpnTemplateAsync(AddMarzbanVpnTemplatesDto template, long userId);

    /// <summary>
    /// get marzban vpn template by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<MarzbanVpnTemplateDto?> GetMarzbanVpnTemplateByIdAsync(long id);

    /// <summary>
    /// get marzban vpns template by vpn id
    /// </summary>
    /// <param name="vpnId"></param>
    /// <returns></returns>
    Task<List<MarzbanVpnTemplateDto>> GetMarzbanVpnTemplateByVpnIdAsync(long vpnId, long userId);

    /// <summary>
    /// filter list marzban users
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    Task<FilterMarzbanUser> FilterMarzbanUsersAsync(FilterMarzbanUser filter);

    /// <summary>
    /// get marzban user information
    /// </summary>
    /// <param name="id"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<MarzbanUserDto?> GetMarzbanUserByUserIdAsync(long id, long userId);

    /// <summary>
    /// update marzban vpn async
    /// </summary>
    /// <param name="vpnDto"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<UpdateMarzbanVpnDto> UpdateMarzbanVpnAsync(UpdateMarzbanVpnDto vpnDto, long userId);

    /// <summary>
    /// update marzban user just my database
    /// </summary>
    /// <param name="user"></param>
    /// <param name="serverId"></param>
    /// <returns></returns>
    Task<MarzbanUserDto?> UpdateMarzbanUserAsync(MarzbanUserDto user,long userId);

    /// <summary>
    /// reveval marzban user
    /// </summary>
    /// <param name="buy"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<MarzbanUserDto> RenewalMarzbanVpnAsync(BuyMarzbanVpnDto vpn, long userId);

    /// <summary>
    /// when disiable user status
    /// </summary>
    /// <param name="status"></param>
    /// <param name="marzbanUserId"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<bool> ChangeMarzbanUserStatus(MarzbanUserStatus status, long marzbanUserId, long userId);
}