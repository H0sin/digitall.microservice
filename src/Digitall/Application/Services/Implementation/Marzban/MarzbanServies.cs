using System.Data;
using System.Net;
using System.Net.Http.Headers;
using Application.Extensions;
using Application.Helper;
using Application.Http.Request;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Marzban;
using Application.Utilities;
using Application.Exceptions;
using Domain.DTOs.Account;
using Domain.DTOs.Marzban;
using Domain.Entities.Account;
using Domain.Entities.Marzban;

using Domain.Entities.Order;
using Domain.Enums;
using Domain.Enums.Order;
using Domain.IRepositories.Account;
using Domain.IRepositories.Marzban;
using Domain.IRepositories.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update;
using Newtonsoft.Json;

namespace Application.Services.Implementation.Marzban;

public class MarzbanServies(
    IMarzbanServerRepository marzbanServerRepository,
    IMarzbanVpnRepository marzbanVpnRepository,
    IMarzbanUserRepository marzbanUserRepository,
    IUserRepository userRepository,
    IOrderRepository orderRepository,
    IAgentService agentService) : IMarzbanService
{
    public async Task AddMarzbanServerAsync(AddMarzbanServerDto marzban, long userId)
    {
        if (
            await marzbanServerRepository
                .GetQuery()
                .SingleOrDefaultAsync(x => x.ServerIp == marzban.ServerIp) is not null
        ) throw new ExistsException("سرور مرزبانی با این ip وجود دارد");

        if (await MarzbanServerIsSuccess(marzban._CreateMarzban())) throw new NotFoundException("سرور در دست رس نیست");

        await marzbanServerRepository.AddEntity(marzban._CreateMarzban());
        await marzbanServerRepository.SaveChanges(userId);
    }

    public async Task<bool> MarzbanServerIsSuccess(MarzbanServer marzbanServer)
    {
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        string token = await marzbanApiRequest.LoginAsync();

        return string.IsNullOrEmpty(token);
    }

    public async Task ReasetMarzbanServerCore(long serverId)
    {
        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(serverId);

        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
        string response = await marzbanApiRequest.CallApiAsync(MarzbanPaths.CoreRestart, HttpMethod.Post);
    }

    public async Task<string> GetMarzbanServerCoreConfigAsync(long serverId)
    {
        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(serverId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
        string response = await marzbanApiRequest.CallApiAsync(MarzbanPaths.CoreConfig, HttpMethod.Get);
        return response;
    }

    public async Task<MarzbanInboundsDto> GetMarzbanInboudsAsync(long serverId)
    {
        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(serverId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        MarzbanInboundsDto response =
            await marzbanApiRequest.CallApiAsync<MarzbanInboundsDto>(MarzbanPaths.InboundGet, HttpMethod.Get);

        return response;
    }

    public async Task<string> UpdateMarzbanServerCoreConfigAsync(long serverId, object core)
    {
        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(serverId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
        string response = await marzbanApiRequest.CallApiAsync(MarzbanPaths.CoreConfig, HttpMethod.Put, core);
        return response;
    }

    public async Task<MarzbanNodeSettingDto> GetMarzbanServerNodeSettingsAsync(long serverId)
    {
        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(serverId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
        MarzbanNodeSettingDto response =
            await marzbanApiRequest.CallApiAsync<MarzbanNodeSettingDto>(MarzbanPaths.NodeSettings, HttpMethod.Get);

        return response;
    }

    public async Task<MarzbanNodeDto> AddMarzbanNodeAsync(long serverId, AddMarzbanNodeDto node)
    {
        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(serverId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
        MarzbanNodeDto response =
            await marzbanApiRequest.CallApiAsync<MarzbanNodeDto>(MarzbanPaths.NodeCreate, HttpMethod.Post, node);

        return response;
    }

    public async Task<MarzbanNodeDto> GetMarzbanNodeByIdAsync(long serverId, long nodeId)
    {
        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(serverId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
        MarzbanNodeDto response =
            await marzbanApiRequest.CallApiAsync<MarzbanNodeDto>(MarzbanPaths.NodeGet + "/" + nodeId,
                HttpMethod.Get);

        return response;
    }

    public async Task<MarzbanNodeDto> UpdateMarzbanServerNodeAsync(long serverId, long nodeId, AddMarzbanNodeDto node)
    {
        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(serverId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
        MarzbanNodeDto response =
            await marzbanApiRequest.CallApiAsync<MarzbanNodeDto>(MarzbanPaths.NodeUpdate + "/" + nodeId,
                HttpMethod.Put, node);

        return response;
    }

    public async Task DeleteNodeByIdAsync(long serverId, long nodeId)
    {
        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(serverId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
        string response =
            await marzbanApiRequest.CallApiAsync(MarzbanPaths.NodeDelete + "/" + nodeId,
                HttpMethod.Delete);
    }

    public async Task<List<MarzbanNodeDto>> GetMarzbanNodeAsync(long serverId)
    {
        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(serverId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
        throw new NotImplementedException("");
    }

    public async Task<List<MarzbanUser>> AddMarzbanUserAsync(List<AddMarzbanUserDto> users, long serverId)
    {
        MarzbanServer? marzbanServer = await GetMarzbanServerByIdAsync(serverId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        string token = await marzbanApiRequest.LoginAsync();

        if (string.IsNullOrEmpty(token))
            throw new MarzbanException(HttpStatusCode.NotFound, "سرور مرزبان در دست رس نیست");

        List<MarzbanUser>? responses = new();

        foreach (AddMarzbanUserDto user in users)
        {
            MarzbanUser response =
                await marzbanApiRequest.CallApiAsync<MarzbanUser>(MarzbanPaths.UserCreate, HttpMethod.Post, user,
                    hasToken: true);
            responses.Add(response);
            Thread.Sleep(TimeSpan.FromSeconds(.3));
        }

        marzbanServer.Users += users.Count;
        await marzbanServerRepository.UpdateEntity(marzbanServer);
        await marzbanServerRepository.SaveChanges(1);

        return responses;
    }

    public async Task AddMarzbanUserAsync(List<AddMarzbanUserDto> users, MarzbanServer server)
    {
        try
        {
            using HttpClient httpClient = new();

            var loginData = new Dictionary<string, string>()
            {
                { "username", server!.UserName },
                { "password", server!.Password }
            };

            var content = new FormUrlEncodedContent(loginData);
            var response = await httpClient.PostAsync(server.GetFullIpAddress() + MarzbanPaths.Login, content);

            if (response.StatusCode == HttpStatusCode.NotFound) throw new LogicException("سرور در دست رس نیست");

            string responseData = await response.Content.ReadAsStringAsync();
            var tokenResponse = JsonConvert.DeserializeObject<MarzbanApiRequest.TokenResponse>(responseData);

            foreach (AddMarzbanUserDto user in users)
            {
                var request =
                    new HttpRequestMessage(HttpMethod.Post, server.GetFullIpAddress() + MarzbanPaths.UserCreate);

                if (!string.IsNullOrEmpty(tokenResponse.access_token))
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokenResponse.access_token);

                request.Content = new StringContent(JsonConvert.SerializeObject(user));
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage add_response = await httpClient.SendAsync(request);
                Thread.Sleep(TimeSpan.FromSeconds(.3));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<GetMarzbanServerOptionDto> GetMarzbanServerAsync(long serverId) =>
        new GetMarzbanServerOptionDto(await marzbanServerRepository.GetEntityById(serverId));


    public async Task<List<GetMarzbanServerOptionDto>> GetMarzbanServersAsync()
    {
        List<MarzbanServer> marzbans = await marzbanServerRepository.GetQuery().ToListAsync();
        return marzbans.Select(x => new GetMarzbanServerOptionDto(x)).ToList();
    }

    public async Task AddMarzbanVpnAsync(AddMarzbanVpnDto vpn, long userId)
    {
        MarzbanServer? marzbanServer = await GetMarzbanServerByIdAsync(vpn.MarzbanServerId);

        MarzbanVpn marzbanVpn = new()
        {
            Name = vpn.Name,
            Shadowsocks = vpn.Shadowsocks,
            Trojan = vpn.Trojan,
            Vless = vpn.Vless,
            GbMin = vpn.GbMin,
            DayMin = vpn.DayMin,
            Vmess = vpn.Vmess,
            DayMax = vpn.DayMax,
            GbMax = vpn.GbMax,
            GbPrice = vpn.GbPrice,
            DayPrice = vpn.DayPrice,
            MarzbanServerId = vpn.MarzbanServerId
        };

        await marzbanVpnRepository.AddEntity(marzbanVpn);
        await marzbanVpnRepository.SaveChanges(userId);
    }

    public async Task<IReadOnlyList<GetMarzbanVpnDto>> GetMarzbanVpnAsync()
    {
        var response = await marzbanVpnRepository.GetAllAsync();
        return response.Select(x => new GetMarzbanVpnDto(x)).ToList();
    }

    public async Task BuyMarzbanVpnAsync(BuyMarzbanVpnDto vpn, long userId)
    {
        IDbContextTransaction transaction = await marzbanVpnRepository.context.Database.BeginTransactionAsync();
        try
        {
            //get vpn
            MarzbanVpn? marzbanVpn = await marzbanVpnRepository.GetEntityById(vpn.MarzbanVpnId);
            if (marzbanVpn is null) throw new NotFoundException("چنین vpn در دست رس نیست");

            // get user
            User? user = await userRepository.GetEntityById(userId);
            user.FirstName = "123";
            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(userId);
            //get agent ids
            var agentIds = await agentService.GetAgentRoot(user.AgentId);

            // get marzban server by id
            MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(marzbanVpn.MarzbanServerId);

            // counting price
            // for percent
            using Percent percent = new(agentService);
            long price = vpn.CountingPrice(marzbanVpn);
            long productPrice = await percent.Calculate(agentIds, price);
            long totalPrice = price * vpn.Count;
            List<CalculatorUserIncome> incomes = await percent.CalculateBalanse(agentIds, price);

            if (user.Balance < totalPrice) throw new BadRequestException("موجودی شما کافی نیست");

            long finallIncome = (productPrice - incomes.Select(x => x.Balance).Sum()) * vpn.Count;
            incomes.Add(new(1, finallIncome));

            foreach (var income in incomes)
            {
                User? us = await userRepository.GetEntityById(income.UserId);
                us.Balance += us.Balance + income.Balance * vpn.Count;
                await userRepository.UpdateEntity(us);
            }

            user.Balance -= totalPrice;

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(userId);

            List<AddMarzbanUserDto> users = new();

            long byteSize = 1073741824;

            DateTime today = DateTime.Today;
            DateTime futureDate = today.AddDays(vpn.TotalDay);
            // Convert the future date to Unix timestamp (seconds since January 1, 1970)
            long unixTimestamp = ((DateTimeOffset)futureDate).ToUnixTimeSeconds();

            object inbounds = new
            {
                vmess = marzbanVpn.Vmess,
                vless = marzbanVpn.Vless,
                trojan = marzbanVpn.Trojan,
                shadowsocks = marzbanVpn.Shadowsocks
            };

            Dictionary<string, object> proxies = new Dictionary<string, object>();

            if (marzbanVpn.Vmess.Count > 0)
                proxies.Add("vmess", new { });
            if (marzbanVpn.Trojan.Count > 0)
                proxies.Add("trojan", new { });
            if (marzbanVpn.Vless.Count > 0)
                proxies.Add("vless", new { });
            if (marzbanVpn.Shadowsocks.Count > 0)
                proxies.Add("shadowsocks", new { });

            for (int i = 0; i < vpn.Count; i++)
            {
                users.Add(new()
                {
                    Username = vpn.Title + "" + marzbanServer.Users + i,
                    Expire = unixTimestamp.ToString(),
                    Data_Limit_Reset_Strategy = "no_reset",
                    Inbounds = inbounds,
                    Note = "",
                    Proxies = proxies,
                    Status = "active",
                    Data_Limit = (byteSize * vpn.TotalGb).ToString(),
                });
            }

            List<Domain.Entities.Order.Order> orders = new()
            {
                new Domain.Entities.Order.Order()
                {
                    Description = "خرید Vpn" + vpn.Title,
                    UserId = userId,
                    IsPaid = true,
                    TracingCode = 1,
                    PaymentDate = DateTime.Now,
                    OrderDetails = new List<OrderDetail>()
                    {
                        new()
                        {
                            Count = vpn.Count,
                            OrderDeatilType = OrderDeatilType.Vpn,
                            ProductPrice = totalPrice
                        }
                    }
                }
            };

            await orderRepository.AddEntities(orders);
            await orderRepository.SaveChanges(userId);

            List<MarzbanUser> marzbanUsers = await AddMarzbanUserAsync(users, marzbanServer.Id);

            marzbanUsers.ForEach(x =>
            {
                x.OrderDetailId = orders.First().OrderDetails.First().Id;
                x.UserId = userId;
                x.MarzbanServerId = marzbanServer.Id;
                x.MarzbanVpnId = marzbanVpn.Id;
            });

            await marzbanUserRepository.AddEntities(marzbanUsers);
            await marzbanUserRepository.SaveChanges(userId);

            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            throw e;
        }
    }

    public async Task<MarzbanUserInformationDto> GetMarzbanUserInformationAsync(string userName, long? userId = null)
    {
        MarzbanUser? marzbanUser =
            await marzbanUserRepository.GetQuery().SingleOrDefaultAsync(x => x.Username == userName);

        if (marzbanUser is null) throw new NotFoundException("لینک نا معتبر");

        if (userId is not null and not 0)
            if (marzbanUser?.UserId != userId)
                throw new NotFoundException("لینک نا معتبر");

        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(marzbanUser.MarzbanServerId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        MarzbanUserInformationDto response =
            await marzbanApiRequest.CallApiAsync<MarzbanUserInformationDto>(MarzbanPaths.UserGet + "/" + userName,
                HttpMethod.Get);

        return response;
    }

    private async Task UpdateMarzbanServerCount(long serverId, long count)
    {
        MarzbanServer server = await GetMarzbanServerByIdAsync(serverId);
        server.Users = count;
        await marzbanServerRepository.UpdateEntity(server);
        await marzbanServerRepository.SaveChanges(1);
    }

    public async Task<MarzbanServer> GetMarzbanServerByIdAsync(long Id)
    {
        MarzbanServer? marzbanServer = await marzbanServerRepository.GetEntityById(Id);

        if (marzbanServer is null) throw new NotFoundException("سرور در دست رس نیست");

        return marzbanServer;
    }
}