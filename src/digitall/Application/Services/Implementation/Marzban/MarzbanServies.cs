using System.Data;
using System.Net;
using System.Net.Http.Headers;
using Application.Extensions;
using Application.Helper;
using Application.Http.Request;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Marzban;
using Application.Utilities;
using Data.Repositories.Marzban;
// using Data.Migrations;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Marzban;
using Domain.Entities.Account;
using Domain.Entities.Marzban;
using Domain.Entities.Order;
using Domain.Enums;
using Domain.Enums.Marzban;
using Domain.Enums.Order;
using Domain.Exceptions;
using Domain.IRepositories.Account;
using Domain.IRepositories.Marzban;
using Domain.IRepositories.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update;
using Newtonsoft.Json;

namespace Application.Services.Implementation.Marzban;

public class MarzbanServies(
    IUserRepository userRepository,
    IMarzbanServerRepository marzbanServerRepository,
    IMarzbanVpnRepository marzbanVpnRepository,
    IMarzbanUserRepository marzbanUserRepository,
    IMarzbanVpnTemplatesRepository marzbanVpnTemplatesRepository,
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
                { "username", server!.UserName! },
                { "password", server!.Password! }
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
            MarzbanServerId = vpn.MarzbanServerId,
            Test_Active = vpn.Test_Active,
            Test_Days = vpn.Test_Days,
            Test_TotalMg = vpn.Test_Days
        };

        await marzbanVpnRepository.AddEntity(marzbanVpn);
        await marzbanVpnRepository.SaveChanges(userId);
    }

    public async Task<IReadOnlyList<GetMarzbanVpnDto>> GetMarzbanVpnAsync(long userId, int numberOfAgents = 2)
    {
        List<MarzbanVpn> response = await marzbanVpnRepository
            .GetQuery()
            .ToListAsync();
        Percent percent = new Percent(agentService);
        List<MarzbanVpn> result = await percent.CalcuteVpnPrice(response, userId, numberOfAgents);
        return result.Select(x => new GetMarzbanVpnDto(x)).ToList();
    }

    public async Task<List<MarzbanUser>> BuyMarzbanVpnAsync(BuyMarzbanVpnDto vpn, long userId)
    {
        IDbContextTransaction transaction = await marzbanVpnRepository.context.Database.BeginTransactionAsync();
        try
        {
            MarzbanVpn? marzbanVpn = await marzbanVpnRepository.GetEntityById(vpn.MarzbanVpnId);
            if (marzbanVpn is null) throw new NotFoundException("چنین vpn در دست رس نیست");

            AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);

            if (agent is null)
                throw new NotFoundException("نمایندکی شما غیر فعال است");


            User? user = await userRepository.GetEntityById(userId);

            MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(marzbanVpn.MarzbanServerId);

            MarzbanVpnTemplateDto? template = await
                GetMarzbanVpnTemplateByIdAsync(vpn.MarzbanVpnTemplateId ?? 0);

            using Percent percent = new(agentService, this);

            GetMarzbanVpnDto? mv = await percent.CalcuteVpnPrice(marzbanVpn.Id, userId);

            long price = template is not null
                ? await percent.CalculatorVpnPrice(template.Price, userId)
                : (vpn.CountingPrice(mv));

            long totalPrice = price * vpn.Count;

            AgentDto? isAgent = await agentService.GetAgentByAdminId(userId);

            if (user?.Balance < totalPrice & isAgent is null) throw new BadRequestException("موجودی شما کافی نیست");

            List<User> updatedUsers = await percent.CalculateAgentIncome(userId, price, vpn.Count);
            foreach (var u in updatedUsers)
            {
                await userRepository.UpdateEntity(u);
            }

            user!.Balance -= totalPrice;

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(userId);

            List<AddMarzbanUserDto> users = new();

            long byteSize = 1073741824;

            DateTime today = DateTime.Today;
            DateTime futureDate = today.AddDays(template?.Days ?? vpn.TotalDay);

            long unixTimestamp = ((DateTimeOffset)futureDate).ToUnixTimeSeconds();

            Dictionary<string, List<string>?> inbounds = new Dictionary<string, List<string>?>() { };

            if (marzbanVpn.Vmess?.Count() >= 1) inbounds.Add("vmess", marzbanVpn.Vmess);
            if (marzbanVpn.Vless?.Count() >= 1) inbounds.Add("vless", marzbanVpn.Vless);
            if (marzbanVpn.Trojan?.Count() >= 1) inbounds.Add("trojan", marzbanVpn.Trojan);
            if (marzbanVpn.Shadowsocks?.Count() >= 0)
                inbounds.Add("shadowsocks", marzbanVpn.Shadowsocks);

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
                    Username = agent.BrandName + "_" + (marzbanServer.Users + i + 1) + "_" + new Random().Next(10, 99),
                    Expire = unixTimestamp.ToString(),
                    Data_Limit_Reset_Strategy = "no_reset",
                    Inbounds = inbounds,
                    Note = "",
                    Proxies = proxies,
                    Status = "active",
                    Data_Limit = (byteSize * (template?.Gb ?? vpn.TotalGb)).ToString(),
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

            return marzbanUsers;
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

    public async Task<List<string>> GetMarzbanUsersByUserId(long userId)
        => await marzbanUserRepository
            .GetQuery()
            .Where(x => x.UserId == userId)
            .Select(x => new string(x.Username))
            .ToListAsync();


    public async Task<MarzbanUser?> BuyMarzbanTestVpnAsync(long vpnId, long userId)
    {
        IDbContextTransaction transaction = await marzbanVpnRepository.context.Database.BeginTransactionAsync();
        try
        {
            //get vpn
            MarzbanVpn? marzbanVpn = await marzbanVpnRepository.GetEntityById(vpnId);
            if (marzbanVpn is null) throw new NotFoundException("چنین vpn در دست رس نیست");

            // get user
            User? user = await userRepository.GetEntityById(userId);

            // get marzban server by id
            MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(marzbanVpn.MarzbanServerId);

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(userId);

            List<AddMarzbanUserDto> users = new();

            long byteSize = 1048576;

            DateTime today = DateTime.Today;
            DateTime futureDate = today.AddDays(marzbanVpn.Test_Days);
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

            users.Add(new()
            {
                Username = new Random().Next(1, 123456789).ToString() + marzbanServer.Users + "Test",
                Expire = unixTimestamp.ToString(),
                Data_Limit_Reset_Strategy = "no_reset",
                Inbounds = inbounds,
                Note = "",
                Proxies = proxies,
                Status = "active",
                Data_Limit = (byteSize * marzbanVpn.Test_TotalMg).ToString(),
            });

            List<Domain.Entities.Order.Order> orders = new()
            {
                new Domain.Entities.Order.Order()
                {
                    Description = "خرید Vpn Test" + users[0].Username,
                    UserId = userId,
                    IsPaid = true,
                    TracingCode = 1,
                    PaymentDate = DateTime.Now,
                    OrderDetails = new List<OrderDetail>()
                    {
                        new()
                        {
                            Count = 1,
                            OrderDeatilType = OrderDeatilType.Vpn,
                            ProductPrice = 0
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

            return marzbanUsers?.FirstOrDefault() ?? null;
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            throw e;
        }
    }

    public async Task<List<MarzbanVpnBotDto>> GetListMarzbanVpns()
    {
        return await marzbanVpnRepository
            .GetQuery()
            .Select(x => new MarzbanVpnBotDto()
            {
                Id = x.Id,
                Title = x.Name
            }).ToListAsync();
    }

    public async Task<List<MarzbanVpnTestDto>> GetListMarzbanVpnsTest()
    {
        return await marzbanVpnRepository
            .GetQuery()
            .Where(x => x.Test_Active == true)
            .Select(x => new MarzbanVpnTestDto()
            {
                Id = x.Id,
                Title = x.Name
            }).ToListAsync();
    }

    public async Task<GetMarzbanVpnDto?> GetMarzbanVpnByIdAsync(long vpnId, long userId)
    {
        MarzbanVpn? vpn = await marzbanVpnRepository
            .GetEntityById(vpnId);

        using Percent percent = new(agentService, this);

        return vpn switch
        {
            null => null,
            _ => await percent.CalcuteVpnPrice(vpn.Id, userId)
        };
    }

    public async Task<GetMarzbanVpnDto?> GetMarzbanVpnByIdAsync(long vpnId)
    {
        MarzbanVpn? vpn = await marzbanVpnRepository
            .GetEntityById(vpnId);

        return vpn switch
        {
            null => null,
            _ => new(vpn)
        };
    }

    public async Task AddMarzbanVpnTemplateAsync(AddMarzbanVpnTemplatesDto template, long userId)
    {
        MarzbanVpnTemplate vpnTemplate = new()
        {
            Days = template.Days,
            Title = template.Title,
            Gb = template.Gb,
            Price = template.Price,
            MarzbanVpnId = template.MarzbanVpnId
        };

        await marzbanVpnTemplatesRepository.AddEntity(vpnTemplate);
        await marzbanVpnTemplatesRepository.SaveChanges(userId);
    }

    public async Task<MarzbanVpnTemplateDto?> GetMarzbanVpnTemplateByIdAsync(long id)
    {
        MarzbanVpnTemplate? marzbanVpnTemplate = await marzbanVpnTemplatesRepository.GetEntityById(id);

        return marzbanVpnTemplate switch
        {
            null => null,
            _ => new MarzbanVpnTemplateDto()
            {
                Days = marzbanVpnTemplate.Days,
                Title = marzbanVpnTemplate.Title,
                Gb = marzbanVpnTemplate.Gb,
                Price = marzbanVpnTemplate.Price,
                Id = marzbanVpnTemplate.Id
            }
        };
    }

    public async Task<List<MarzbanVpnTemplateDto>> GetMarzbanVpnTemplateByVpnIdAsync(long vpnId, long userId)
    {
        User? user = await userRepository.GetEntityById(userId);

        if (user == null) throw new NotFoundException("کاربری با این شناسه یافت نشد");

        List<MarzbanVpnTemplateDto> templates = await marzbanVpnTemplatesRepository
            .GetQuery()
            .Where(x => x.MarzbanVpnId == vpnId)
            .Select(x => new MarzbanVpnTemplateDto()
            {
                Days = x.Days,
                Title = x.Title,
                Gb = x.Gb,
                Price = x.Price,
                Id = x.Id
            }).ToListAsync();

        Percent percent = new Percent(agentService);

        return await percent.CalcuteVpnTemplatePrice(templates, userId);
    }

    public async Task<FilterMarzbanUser> FilterMarzbanUsersAsync(FilterMarzbanUser filter)
    {
        IQueryable<MarzbanUser> query = marzbanUserRepository.GetQuery();

        if ((filter.UserId ?? 0) != 0)
            query = query.Where(i => i.UserId == filter.UserId);

        IQueryable<MarzbanUserDto> users = query.Select(x => new MarzbanUserDto(x));

        await filter.Paging(users);

        return filter;
    }

    public async Task<MarzbanUserDto?> GetMarzbanUserByUserIdAsync(long id, long userId)
    {
        MarzbanUser? marzbanUser = await marzbanUserRepository.GetEntityById(id);

        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(marzbanUser.MarzbanServerId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        MarzbanUserDto response =
            await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(MarzbanPaths.UserGet + "/" + marzbanUser.Username,
                HttpMethod.Get);

        if (marzbanUser.UserId != userId) marzbanUser = null;

        response.MarzbanServerId = marzbanUser.MarzbanServerId;
        response.MarzbanVpnId = marzbanUser.MarzbanVpnId;
        response.Id = marzbanUser.Id;

        return marzbanUser switch
        {
            null => null,
            _ => response
        };
    }

    public async Task<UpdateMarzbanVpnDto> UpdateMarzbanVpnAsync(UpdateMarzbanVpnDto vpnDto, long userId)
    {
        MarzbanVpn? marzbanVpn = await marzbanVpnRepository.GetEntityById(vpnDto.Id);

        if (marzbanVpn is null) throw new NotFoundException("وی پی ان پیدا نشد");

        marzbanVpn.Name = vpnDto.Name;
        marzbanVpn.GbMax = vpnDto.GbMax;
        marzbanVpn.GbMin = vpnDto.GbMin;
        marzbanVpn.GbPrice = vpnDto.GbPrice;
        marzbanVpn.DayMax = vpnDto.DayMax;
        marzbanVpn.DayMin = vpnDto.DayMin;
        marzbanVpn.DayPrice = vpnDto.DayPrice;
        marzbanVpn.Test_Active = vpnDto.Test_Active;
        marzbanVpn.Test_Days = vpnDto.Test_Days;
        marzbanVpn.Test_TotalMg = vpnDto.Test_TotalMg;
        // marzbanVpn.Vmess = vpnDto.Vmess;
        // marzbanVpn.Vless = vpnDto.Vless;
        // marzbanVpn.Shadowsocks = vpnDto.Shadowsocks;
        // marzbanVpn.Trojan = vpnDto.Trojan;

        // Save changes
        await marzbanVpnRepository.UpdateEntity(marzbanVpn);
        await marzbanServerRepository.SaveChanges(userId);
        return vpnDto;
    }

    public async Task<MarzbanUserDto?> UpdateMarzbanUserAsync(MarzbanUserDto user, long userId)
    {
        MarzbanUser? mu = await marzbanUserRepository.GetEntityById(user.Id);

        mu.Expire = user.Expire;
        mu.Links = user.Links;
        mu.Username = user.Username;
        mu.Subscription_Url = user.Subscription_Url;
        mu.Status = user.Status;
        mu.Online_At = user.Online_At;
        mu.Used_Traffic = user.Used_Traffic;
        mu.OnHoldExpireDuration = user.OnHoldExpireDuration;
        mu.Sub_Last_User_Agent = user.Sub_Last_User_Agent;
        mu.Data_Limit = user.Data_Limit;
        mu.Sub_Updated_At = user.Sub_Updated_At;

        await marzbanUserRepository.UpdateEntity(mu);
        await marzbanUserRepository.SaveChanges(userId);

        return user;
    }

    public async Task<MarzbanUserDto> RenewalMarzbanVpnAsync(BuyMarzbanVpnDto vpn, long userId)
    {
        IDbContextTransaction transaction = await marzbanVpnRepository.context.Database.BeginTransactionAsync();
        try
        {
            MarzbanVpn? marzbanVpn = await marzbanVpnRepository.GetEntityById(vpn.MarzbanVpnId);
            if (marzbanVpn is null) throw new NotFoundException("چنین vpn در دست رس نیست");

            AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);

            if (agent is null)
                throw new NotFoundException("نمایندکی شما غیر فعال است");

            User? user = await userRepository.GetEntityById(userId);

            MarzbanVpnTemplateDto? template = await
                GetMarzbanVpnTemplateByIdAsync(vpn.MarzbanVpnTemplateId ?? 0);

            using Percent percent = new(agentService);

            MarzbanVpn? mv = await percent.CalcuteVpnPrice(marzbanVpn, userId);

            long price = template is not null
                ? await percent.CalculatorVpnPrice(template.Price, userId)
                : (vpn.CountingPrice(mv));

            long totalPrice = price * vpn.Count;
            if (user?.Balance < totalPrice) throw new BadRequestException("موجودی شما کافی نیست");

            List<User> updatedUsers = await percent.CalculateAgentIncome(userId, price, vpn.Count);

            foreach (var u in updatedUsers)
            {
                await userRepository.UpdateEntity(u);
            }

            user!.Balance -= totalPrice;

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(userId);

            MarzbanUserDto? marzbanUser = await GetMarzbanUserByUserIdAsync(vpn.MarzbanUserId ?? 0, userId);

            long byteSize = 1073741824;
            DateTime dt = DateTimeOffset.FromUnixTimeSeconds(marzbanUser?.Expire ?? 0).DateTime;
            DateTime futureDate = dt.AddDays(template?.Days ?? vpn.TotalDay);
            long unixTimestamp = ((DateTimeOffset)futureDate).ToUnixTimeSeconds();

            MarzbanUserDto newMarzbanUser = new()
            {
                Expire = unixTimestamp,
                Data_Limit_Reset_Strategy = "no_reset",
                Note = "",
                Status = "active",
                Data_Limit = (byteSize * (template?.Gb ?? vpn.TotalGb)) + marzbanUser?.Data_Limit ?? 0,
            };

            MarzbanServer? marzbanServer = await GetMarzbanServerByIdAsync(marzbanVpn.MarzbanServerId);
            MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

            string token = await marzbanApiRequest.LoginAsync();

            if (string.IsNullOrEmpty(token))
                throw new MarzbanException(HttpStatusCode.NotFound, "سرور مرزبان در دست رس نیست");

            MarzbanUserDto? response = await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(
                MarzbanPaths.UserUpdate + "/" + marzbanUser?.Username,
                HttpMethod.Put, newMarzbanUser);

            // await UpdateMarzbanUserAsync(marzbanUser, userId);

            return response;
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            throw e;
        }
    }

    public async Task<bool> ChangeMarzbanUserStatusAsync(MarzbanUserStatus status, long marzbanUserId, long userId)
    {
        MarzbanUserDto? marzbanUser = await GetMarzbanUserByUserIdAsync(marzbanUserId, userId);
        MarzbanServer? marzbanServer = await GetMarzbanServerByIdAsync(marzbanUser.MarzbanServerId ?? 0);

        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        marzbanUser.Status = status.ToString();

        MarzbanUserDto? response = await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(
            MarzbanPaths.UserUpdate + "/" + marzbanUser.Username,
            HttpMethod.Put, marzbanUser);

        await UpdateMarzbanUserAsync(marzbanUser, userId);
        return true;
    }

    public async Task DeleteMarzbanUserAsync(long marzbanUserId, long userId)
    {
        MarzbanUser? marzbanUser = await marzbanUserRepository.GetEntityById(marzbanUserId);
        GetMarzbanVpnDto? marzbanVpn = await GetMarzbanVpnByIdAsync(marzbanUser.MarzbanVpnId, userId);
        MarzbanServer? marzbanServer = await GetMarzbanServerByIdAsync(marzbanUser.MarzbanServerId);

        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        string token = await marzbanApiRequest.LoginAsync();

        if (string.IsNullOrEmpty(token))
            throw new MarzbanException(HttpStatusCode.NotFound, "سرور مرزبان در دست رس نیست");

        MarzbanUserDto serverUser =
            await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(MarzbanPaths.UserGet + "/" + marzbanUser.Username,
                HttpMethod.Get);

        long byteSize = 1073741824;
        long remaining_data = (marzbanUser.Data_Limit ?? 0) - (serverUser.Used_Traffic ?? 0);
        double mg = (remaining_data / byteSize);
        long gb = (long)Math.Ceiling(mg);

        if (marzbanUser.Expire == null)
            throw new BadRequestException();

        DateTime expire = DateTimeOffset.FromUnixTimeSeconds(marzbanUser.Expire ?? 0).DateTime;

        TimeSpan difference = expire - DateTime.Now;

        long days = (long)Math.Ceiling(difference.TotalDays);

        long price = (marzbanVpn.DayPrice * days) + (marzbanVpn.GbPrice * gb);

        MarzbanUserDto userDelete =
            await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(MarzbanPaths.UserDelete + "/" + marzbanUser.Username,
                HttpMethod.Delete);

        User? user = await userRepository.GetEntityById(marzbanUser.UserId);
        user.Balance += price;
        await userRepository.UpdateEntity(user);
        await userRepository.SaveChanges(userId);
        
        await marzbanUserRepository.DeleteEntity(marzbanUserId);
        await marzbanUserRepository.SaveChanges(userId);
    }

    public async Task<MarzbanUserDto?> UpdateMarzbanUserAsync(RenewalMarzbanUserDto user, long serverId, long userId)
    {
        MarzbanServer? marzbanServer = await GetMarzbanServerByIdAsync(serverId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        string token = await marzbanApiRequest.LoginAsync();

        if (string.IsNullOrEmpty(token))
            throw new MarzbanException(HttpStatusCode.NotFound, "سرور مرزبان در دست رس نیست");

        MarzbanUserDto? response = await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(
            MarzbanPaths.UserUpdate + "/" + user.Username,
            HttpMethod.Put, user);

        await marzbanServerRepository.UpdateEntity(marzbanServer);
        await marzbanServerRepository.SaveChanges(1);

        MarzbanUser? mu = await marzbanUserRepository.GetEntityById(user.Id);

        mu.Expire = response.Expire;
        mu.Links = response.Links;
        mu.Username = response.Username;
        mu.Subscription_Url = response.Subscription_Url;
        mu.Status = response.Status;
        mu.Online_At = response.Online_At;
        mu.Used_Traffic = response.Used_Traffic;
        mu.OnHoldExpireDuration = response.OnHoldExpireDuration;
        mu.Sub_Last_User_Agent = response.Sub_Last_User_Agent;
        mu.Data_Limit = response.Data_Limit;
        mu.Sub_Updated_At = response.Sub_Updated_At;

        await marzbanUserRepository.UpdateEntity(mu);
        await marzbanUserRepository.SaveChanges(userId);

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