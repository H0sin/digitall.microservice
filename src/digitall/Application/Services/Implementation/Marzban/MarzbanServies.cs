using System.Data;
using System.Net;
using System.Net.Http.Headers;
using Application.Extensions;
using Application.Helper;
using Application.Http.Request;
using Application.Services.Implementation.Notification;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Marzban;
using Application.Services.Interface.Notification;
using Application.Static.Template;
using Application.Utilities;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Marzban;
using Domain.DTOs.Notification;
using Domain.DTOs.Telegram;
using Domain.DTOs.Transaction;
using Domain.Entities.Account;
using Domain.Entities.Marzban;
using Domain.Entities.Order;
using Domain.Entities.Transaction;
using Domain.Enums;
using Domain.Enums.Marzban;
using Domain.Enums.Order;
using Domain.Exceptions;
using Domain.IRepositories.Account;
using Domain.IRepositories.Marzban;
using Domain.IRepositories.Order;
using Domain.IRepositories.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update;
using Newtonsoft.Json;
using Telegram.Bot;

namespace Application.Services.Implementation.Marzban;

public class MarzbanServies(
    IUserRepository userRepository,
    IMarzbanServerRepository marzbanServerRepository,
    IMarzbanVpnRepository marzbanVpnRepository,
    IMarzbanUserRepository marzbanUserRepository,
    IMarzbanVpnTemplatesRepository marzbanVpnTemplatesRepository,
    IOrderRepository orderRepository,
    IOrderDetailRepository orderDetailRepository,
    INotificationService notificationService,
    IAgentsIncomesDetailRepository agentsIncomesDetailRepository,
    IAgentService agentService) : IMarzbanService
{
    public async Task<List<MarzbanServer>> ListMarzbanServerAsync()
        => await marzbanServerRepository.GetQuery().ToListAsync();

    public async Task<List<GetMarzbanServerDto>> GetListMarzbanServcerAsync()
        => await marzbanServerRepository.GetQuery().Select(x => new GetMarzbanServerDto(x))
            .ToListAsync();

    public async Task AddMarzbanServerAsync(AddMarzbanServerDto marzban, long userId)
    {
        if (
            await marzbanServerRepository
                .GetQuery()
                .SingleOrDefaultAsync(x => x.ServerIp == marzban.ServerIp) is not null
        ) throw new ExistsException("سرور مرزبانی با این ip وجود دارد");


        string token = await GetMarzbanServerTokenAsync(marzban._CreateMarzban());

        if (string.IsNullOrEmpty(token)) throw new NotFoundException("سرور در دست رس نیست");

        await marzbanServerRepository.AddEntity(marzban._CreateMarzban(token));
        await marzbanServerRepository.SaveChanges(userId);
    }

    public async Task<bool> MarzbanServerIsSuccess(MarzbanServer marzbanServer)
    {
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        string token = await marzbanApiRequest.LoginAsync();

        return string.IsNullOrEmpty(token);
    }

    public async Task<string> GetMarzbanServerTokenAsync(MarzbanServer marzbanServer)
    {
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        try
        {
            string token = await marzbanApiRequest.LoginAsync();

            return token;
        }
        catch (Exception e)
        {
            return "";
        }
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

        return response.Select(x => new GetMarzbanVpnDto(x)).ToList();
    }

    public async Task<List<MarzbanUser>> BuyMarzbanVpnAsync(BuyMarzbanVpnDto vpn, long userId)
    {
        IDbContextTransaction transaction = await marzbanVpnRepository.context.Database.BeginTransactionAsync();
        try
        {
            long daysPrice = 0;
            long gbsPrice = 0;
            long templatePrice = 0;
            long totalPrice = 0;
            List<CalculatorUserIncome> incomes = new();

            MarzbanVpn? marzbanVpn = await marzbanVpnRepository.GetEntityById(vpn.MarzbanVpnId);

            if (marzbanVpn is null) throw new NotFoundException("چنین vpn در دست رس نیست");

            AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);

            if (agent is null)
                throw new NotFoundException("نمایندکی شما غیر فعال است");

            User? user = await userRepository.GetEntityById(userId);

            MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(marzbanVpn.MarzbanServerId);

            // using Percent percent = new(agentService, this);

            CountingVpnPrice countingVpnPrice = new CountingVpnPrice();

            MarzbanVpnTemplateDto? template = await
                GetMarzbanVpnTemplateByIdAsync(vpn.MarzbanVpnTemplateId ?? 0);

            if (vpn.MarzbanVpnTemplateId is null || vpn.MarzbanVpnTemplateId == 0)
            {
                daysPrice = (vpn.TotalDay *
                             await countingVpnPrice.CalculateFinalPrice(agentService, userId, marzbanVpn.DayPrice)) *
                            vpn.Count;
                gbsPrice = (vpn.TotalGb *
                            await countingVpnPrice.CalculateFinalPrice(agentService, userId, marzbanVpn.GbPrice)) *
                           vpn.Count;

                totalPrice = daysPrice + gbsPrice;

                long finalPrice = (((marzbanVpn.GbPrice) * vpn.TotalGb) +
                                   ((marzbanVpn.DayPrice) * vpn.TotalDay));

                incomes = await countingVpnPrice.CalculateUserIncomes(agentService, userId, finalPrice, vpn.TotalGb,
                    vpn.TotalDay, marzbanVpn.GbPrice, marzbanVpn.DayPrice, template?.Price ?? 0, vpn.Count);
            }
            else
            {
                templatePrice =
                    await countingVpnPrice.CalculateFinalPrice(agentService, userId, template.Price) * vpn.Count;

                totalPrice = templatePrice;
                incomes = await countingVpnPrice.CalculateUserIncomes(agentService, userId, template.Price, vpn.TotalGb,
                    vpn.TotalDay, marzbanVpn.GbPrice, marzbanVpn.DayPrice, template?.Price ?? 0, vpn.Count);
            }

            AgentDto? isAgent = await agentService.GetAgentByAdminIdAsync(userId);

            if (user.Balance < totalPrice)
            {
                if (isAgent == null && user?.Balance < totalPrice)
                {
                    throw new BadRequestException("موجودی شما کافی نیست");
                }

                if (!(isAgent != null && isAgent.AmountWithNegative < user?.Balance - totalPrice))
                {
                    throw new BadRequestException("موجودی شما کافی نیست");
                }
            }

            user!.Balance -= totalPrice;

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(userId);

            List<AddMarzbanUserDto> users = new();

            long byteSize = 1073741824;

            DateTime today = DateTime.Today;
            DateTime futureDate = today.AddDays(template?.Days ?? vpn.TotalDay);

            Dictionary<string, List<string>?> inbounds = new Dictionary<string, List<string>?>();

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
                    Username = isAgent != null
                        ? isAgent.BrandName + "_" + (marzbanServer.Users + i + 1) + "_" + new Random().Next(10, 99)
                        : agent.BrandName + "_" + (marzbanServer.Users + i + 1) + "_" + new Random().Next(10, 99),
                    // Expire = unixTimestamp.ToString(),
                    Data_Limit_Reset_Strategy = "no_reset",
                    Inbounds = inbounds,
                    Note = (user.ChatId ?? user.Id) +
                           " | " +
                           userId +
                           " | " +
                           DateTime.Now +
                           " |  " +
                           "Buy" +
                           " | " +
                           user.TelegramUsername ??
                           user.UserFullName(),
                    Proxies = proxies,
                    Status = "on_hold",
                    On_Hold_Expire_Duration =
                        template?.Days != null ? template.Days * 24 * 3600 : vpn.TotalDay * 24 * 3600,
                    On_Hold_Timeout = null,
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

            long orderDetailId = orders.First().OrderDetails.First().Id;


            foreach (var i in incomes)
            {
                User? u = await userRepository.GetEntityById(i.UserId);

                i.BalanceBeforPayment = u.Balance;
                u.Balance += i.Balance;

                await agentService.AddAgentsIncomesDetailAsync(new AgentsIncomesDetail()
                {
                    OrderDetailId = orderDetailId,
                    Profit = i.Balance,
                    AgentId = i.AgentId,
                    UserId = i.UserId,
                    Percent = i.Percent,
                }, userId);

                i.TelegramUserName = u.TelegramUsername ?? "NOUSERNAME";
                i.chatId = u.ChatId;

                IOrderedEnumerable<CalculatorUserIncome> newIncomes = incomes.OrderByDescending(x => x.AgentId);

                var largestAgentIncome = newIncomes.First();

                bool isLargestAgent = i == largestAgentIncome;

                await notificationService.AddNotificationAsync(
                    NotificationTemplate.IncomeFromPaymentAsync(
                        income: i,
                        userName: user.TelegramUsername ?? "NOUSERNAME",
                        chatId: user.ChatId ?? 0,
                        price: totalPrice,
                        userbalance: user.Balance,
                        createServiceTime: DateTime.Now,
                        marzbanVpnName: marzbanVpn.Name ?? "",
                        marzbanUsername: users.First().Username,
                        isLargestAgent: isLargestAgent), userId);

                await userRepository.UpdateEntity(u);
            }

            List<MarzbanUser> marzbanUsers = await AddMarzbanUserAsync(users, marzbanServer.Id);

            marzbanUsers.ForEach(x =>
            {
                x.ServiceTime = vpn.MarzbanVpnTemplateId is not null ? template.Days : vpn.TotalDay;
                x.Volume = vpn.MarzbanVpnTemplateId is not null ? template.Gb : vpn.TotalGb;
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
            throw new AppException(e.Message);
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

            AgentDto? isAgent = await agentService.GetAgentByAdminIdAsync(userId);

            AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);

            if (user?.FinalCountTestMarzbanAccount > 2)
                throw new AppException("تعداد تست های دریافتی شما تمام شده است");

            // get marzban server by id

            user.FinalCountTestMarzbanAccount += 1;
            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(userId);

            MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(marzbanVpn.MarzbanServerId);

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
                Username = isAgent != null
                    ? isAgent.BrandName + "_" + (marzbanServer.Users + 1) + "_" + new Random().Next(10, 99)
                    : agent?.BrandName + "_" + (marzbanServer.Users + 1) + "_" + new Random().Next(10, 99),
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

    public async Task<MarzbanVpnDto?> GetMarzbanVpnByIdAsync(long vpnId, long userId)
    {
        MarzbanVpn? vpn = await marzbanVpnRepository
            .GetEntityById(vpnId);

        CountingVpnPrice countingVpnPrice = new();


        return vpn switch
        {
            null => null,
            _ => new MarzbanVpnDto
            {
                GbMax = vpn.GbMax,
                GbMin = vpn.GbMin,
                GbPrice = await countingVpnPrice.CalculateFinalPrice(agentService, userId, vpn.GbPrice),
                DayMax = vpn.DayMax,
                DayMin = vpn.DayMin,
                DayPrice = await countingVpnPrice.CalculateFinalPrice(agentService, userId, vpn.DayPrice),
                MarzbanServerId = vpn.MarzbanServerId,
                Name = vpn.Name,
                Id = vpn.Id,
                Test_Active = vpn.Test_Active,
                Test_Days = vpn.Test_Days,
                Test_TotalGb = vpn.Test_TotalMg
            },
        };
    }

    public async Task<MarzbanVpnDto?> GetMarzbanVpnByIdAsync(long vpnId)
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
        CountingVpnPrice countingVpnPrice = new();

        List<MarzbanVpnTemplateDto>? templates = await marzbanVpnTemplatesRepository
            .GetQuery()
            .Where(x => x.MarzbanVpnId == vpnId)
            .Select(x => new MarzbanVpnTemplateDto()
            {
                Days = x.Days,
                Title = x.Title,
                Gb = x.Gb,
                Price = x.Price,
                Id = x.Id,
                MarzbanVpnId = vpnId,
            }).ToListAsync();

        foreach (var template in templates)
        {
            template.Price = await countingVpnPrice
                .CalculateFinalPrice(agentService, userId, template.Price);
        }

        return templates;
    }

    public async Task<FilterMarzbanUser> FilterMarzbanUsersAsync(FilterMarzbanUser filter)
    {
        IQueryable<MarzbanUser> query = marzbanUserRepository
            .GetQuery();

        if ((filter.UserId ?? 0) != 0)
            query = query.Where(i => i.UserId == filter.UserId);

        if (!string.IsNullOrEmpty(filter.Username))
            query = query.Where(x => EF.Functions.Like(x.Username, $"%{filter.Username}%"));

        IQueryable<MarzbanUserDto> users = query.Select(x => new MarzbanUserDto(x));

        await filter.Paging(users);

        return filter;
    }

    public async Task<List<MarzbanUserDto>> GetMarzbanUsersAsync(long userId, bool? delete = false)
    {
        return await marzbanUserRepository
            .GetQuery(delete)
            .Where(x => x.UserId == userId)
            .Select(x => new MarzbanUserDto(x))
            .ToListAsync();
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
        response.UserId = marzbanUser.UserId;

        return marzbanUser switch
        {
            null => null,
            _ => await UpdateMarzbanUserAsync(response, userId),
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
        mu.OnHoldExpireDuration = user.On_Hold_Expire_Duration;
        mu.Sub_Last_User_Agent = user.Sub_Last_User_Agent;
        mu.Data_Limit = user.Data_Limit;
        mu.Sub_Updated_At = user.Sub_Updated_At;
        mu.AddedHolderInbound = user.AddedHolderInbound;
        mu.Volume = user.Volume;
        mu.ServiceTime = user.ServiceTime;

        await marzbanUserRepository.UpdateEntity(mu);
        await marzbanUserRepository.SaveChanges(userId);

        return user;
    }

    public async Task UpdateMarzbanUserHolderInboundAsync(MarzbanUser? marzbanUser, MarzbanServer? marzbanServer)
    {
        if (marzbanServer != null)
        {
            MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
            try
            {
                if (marzbanServer.TypeHolderInbound != null && marzbanServer.HolderInbound != null)
                {
                    Dictionary<string, List<string>?> inbounds = new Dictionary<string, List<string>?>();
                    Dictionary<string, object> proxies = new Dictionary<string, object>();

                    AddMarzbanUserDto newMarzbanUser = new()
                    {
                        Inbounds = inbounds,
                        Proxies = proxies,
                    };

                    inbounds.Add(marzbanServer.TypeHolderInbound.ToLower(), marzbanServer.HolderInbound);

                    if (marzbanServer.HolderInbound.Count > 0)
                        proxies.Add(marzbanServer.TypeHolderInbound.ToLower(), new { });

                    await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(
                        MarzbanPaths.UserUpdate + "/" + marzbanUser.Username,
                        HttpMethod.Put, newMarzbanUser);
                    marzbanUser.AddedHolderInbound = true;

                    await marzbanUserRepository.UpdateEntity(marzbanUser);
                    await marzbanUserRepository.SaveChanges(marzbanUser.UserId);
                }
            }
            catch (Exception e)
            {
                await Task.CompletedTask;
            }
        }
    }

    public async Task<MarzbanUserDto> RenewalMarzbanVpnAsync(BuyMarzbanVpnDto vpn, long userId)
    {
        IDbContextTransaction transaction = await marzbanVpnRepository.context.Database.BeginTransactionAsync();
        try
        {
            long daysPrice = 0;
            long gbsPrice = 0;
            long templatePrice = 0;
            long totalPrice = 0;
            List<CalculatorUserIncome> incomes = new();
            CountingVpnPrice countingVpnPrice = new();

            MarzbanVpn? marzbanVpn = await marzbanVpnRepository.GetEntityById(vpn.MarzbanVpnId);

            if (marzbanVpn is null) throw new NotFoundException("چنین vpn در دست رس نیست");

            AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);

            if (agent is null)
                throw new NotFoundException("نمایندکی شما غیر فعال است");

            User? user = await userRepository.GetEntityById(userId);

            MarzbanVpnTemplateDto? template = await
                GetMarzbanVpnTemplateByIdAsync(vpn.MarzbanVpnTemplateId ?? 0);


            if (vpn.MarzbanVpnTemplateId is null || vpn.MarzbanVpnTemplateId == 0)
            {
                daysPrice = (vpn.TotalDay *
                             await countingVpnPrice.CalculateFinalPrice(agentService, userId, marzbanVpn.DayPrice)) *
                            vpn.Count;
                gbsPrice = (vpn.TotalGb *
                            await countingVpnPrice.CalculateFinalPrice(agentService, userId, marzbanVpn.GbPrice)) *
                           vpn.Count;

                totalPrice = daysPrice + gbsPrice;

                long finalPrice = (((marzbanVpn.GbPrice) * vpn.TotalGb) +
                                   ((marzbanVpn.DayPrice) * vpn.TotalDay));

                incomes = await countingVpnPrice.CalculateUserIncomes(agentService, userId, finalPrice, vpn.TotalGb,
                    vpn.TotalDay, marzbanVpn.GbPrice, marzbanVpn.DayPrice, template?.Price ?? 0, vpn.Count);
            }
            else
            {
                templatePrice =
                    await countingVpnPrice.CalculateFinalPrice(agentService, userId, template.Price) * vpn.Count;

                totalPrice = templatePrice;
                incomes = await countingVpnPrice.CalculateUserIncomes(agentService, userId, template.Price, vpn.TotalGb,
                    vpn.TotalDay, marzbanVpn.GbPrice, marzbanVpn.DayPrice, template?.Price ?? 0, vpn.Count);
            }

            AgentDto? isAgent = await agentService.GetAgentByAdminIdAsync(userId);

            if (user.Balance < totalPrice)
            {
                if (isAgent == null && user?.Balance < totalPrice)
                {
                    throw new BadRequestException("موجودی شما کافی نیست");
                }

                if (!(isAgent != null && isAgent.AmountWithNegative < user?.Balance - totalPrice))
                {
                    throw new BadRequestException("موجودی شما کافی نیست");
                }
            }

            user!.Balance -= totalPrice;

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(userId);

            MarzbanUserDto? marzbanUser = await GetMarzbanUserByUserIdAsync(vpn.MarzbanUserId ?? 0, userId);

            long byteSize = 1073741824;

            DateTime dt = DateTimeOffset.FromUnixTimeSeconds(marzbanUser?.Expire ?? 0).DateTime;

            if (dt < DateTime.Now)
            {
                dt = DateTime.Now;
            }

            DateTime futureDate = dt.AddDays(template?.Days ?? vpn.TotalDay);
            long unixTimestamp = ((DateTimeOffset)futureDate).ToUnixTimeSeconds();

            DateTimeOffset currentTime = DateTimeOffset.UtcNow;
            long? totalDays = (marzbanUser.On_Hold_Expire_Duration / 86400);
            DateTimeOffset newTieme = currentTime.AddDays((template?.Days ?? vpn.TotalDay) + (totalDays ?? 0));
            long unixTimeSeconds = newTieme.ToUnixTimeSeconds();

            List<Domain.Entities.Order.Order> orders = new()
            {
                new Domain.Entities.Order.Order()
                {
                    Description = "تمدید Vpn" + vpn.Title,
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

            long orderDetailId = orders.First().OrderDetails.First().Id;


            foreach (var i in incomes)
            {
                User? u = await userRepository.GetEntityById(i.UserId);

                i.BalanceBeforPayment = u.Balance;
                u.Balance += i.Balance;

                await agentService.AddAgentsIncomesDetailAsync(new AgentsIncomesDetail()
                {
                    OrderDetailId = orderDetailId,
                    Profit = i.Balance,
                    AgentId = i.AgentId,
                    UserId = i.UserId,
                    Percent = i.Percent,
                }, userId);

                i.TelegramUserName = u.TelegramUsername ?? "NOUSERNAME";
                i.chatId = u.ChatId;

                IOrderedEnumerable<CalculatorUserIncome> newIncomes = incomes.OrderByDescending(x => x.AgentId);

                var largestAgentIncome = newIncomes.First();

                bool isLargestAgent = i == largestAgentIncome;

                await notificationService.AddNotificationAsync(
                    NotificationTemplate.IncomeFromPaymentAsync(
                        income: i,
                        userName: user.TelegramUsername ?? "NOUSERNAME",
                        chatId: user.ChatId ?? 0,
                        price: totalPrice,
                        userbalance: user.Balance,
                        createServiceTime: DateTime.Now,
                        marzbanVpnName: marzbanVpn.Name ?? "",
                        marzbanUsername: marzbanUser.Username,
                        renewal: true,
                        isLargestAgent: isLargestAgent), userId);

                await userRepository.UpdateEntity(u);
            }

            Dictionary<string, List<string>?> inbounds = new Dictionary<string, List<string>?>();

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

            MarzbanUserDto newMarzbanUser = new()
            {
                Expire = marzbanUser.Expire != null ? unixTimestamp : unixTimeSeconds,
                Data_Limit_Reset_Strategy = "no_reset",
                Note = (user.ChatId ?? user.Id) +
                       " | " +
                       userId +
                       " | " +
                       DateTime.Now +
                       " |  " +
                       "Renewal" +
                       " | " +
                       user.TelegramUsername ??
                       user.UserFullName(),
                Status = "active",
                Data_Limit = (byteSize * (template?.Gb ?? vpn.TotalGb)), // marzbanUser?.Data_Limit ?? 0,
                Inbounds = inbounds,
                Proxies = proxies,
            };

            MarzbanServer? marzbanServer = await GetMarzbanServerByIdAsync(marzbanVpn.MarzbanServerId);

            await ResetMarzbanUserDataUsedAsync(marzbanUser.Username, marzbanServer);

            MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

            string token = await marzbanApiRequest.LoginAsync();

            if (string.IsNullOrEmpty(token))
                throw new MarzbanException(HttpStatusCode.NotFound, "سرور مرزبان در دست رس نیست");

            MarzbanUserDto? response = await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(
                MarzbanPaths.UserUpdate + "/" + marzbanUser?.Username,
                HttpMethod.Put, newMarzbanUser);

            marzbanUser.AddedHolderInbound = false;
            marzbanUser.Volume = template?.Gb ?? vpn.TotalGb;

            DateTimeOffset dateTime =
                DateTimeOffset.FromUnixTimeSeconds(marzbanUser.Expire != null ? unixTimestamp : unixTimeSeconds);
            DateTimeOffset currentDate = DateTimeOffset.UtcNow;
            TimeSpan difference = currentDate - dateTime;
            marzbanUser.ServiceTime = (int)difference.TotalDays;
            await UpdateMarzbanUserAsync(marzbanUser, userId);
            await transaction.CommitAsync();
            return response;
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            throw new AppException(e.Message);
        }
    }

    public async Task<bool> ChangeMarzbanUserStatusAsync(MarzbanUserStatus status, long marzbanUserId, long userId)
    {
        MarzbanUserDto? marzbanUser = await GetMarzbanUserByUserIdAsync(marzbanUserId, userId);
        MarzbanServer? marzbanServer = await GetMarzbanServerByIdAsync(marzbanUser.MarzbanServerId);

        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        marzbanUser.Status = status.ToString();

        MarzbanUserDto? response = await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(
            MarzbanPaths.UserUpdate + "/" + marzbanUser.Username,
            HttpMethod.Put, marzbanUser);

        await UpdateMarzbanUserAsync(marzbanUser, userId);
        return true;
    }

    public async Task DeleteMarzbanUserAsync(DeleteMarzbanUserDto delete)
    {
        using IDbContextTransaction transaction = await marzbanUserRepository.context.Database.BeginTransactionAsync();
        try
        {
            MarzbanUser? marzbanUser = await marzbanUserRepository.GetQuery()
                .SingleOrDefaultAsync(x => x.Id == delete.MarzbanUserId && x.UserId == delete.UserId);

            MarzbanServer? marzbanServer = await GetMarzbanServerByIdAsync(marzbanUser.MarzbanServerId);

            MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

            string token = await marzbanApiRequest.LoginAsync();

            if (string.IsNullOrEmpty(token))
                throw new MarzbanException(HttpStatusCode.NotFound, "سرور مرزبان در دست رس نیست");

            MarzbanUserDto? serverUser =
                await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(MarzbanPaths.UserGet + "/" + marzbanUser.Username,
                    HttpMethod.Get);

            if (serverUser is null)
                throw new AppException("سرویس یافت نشد");

            marzbanUser.IsDelete = true;
            await marzbanUserRepository.UpdateEntity(marzbanUser);
            await marzbanUserRepository.SaveChanges(delete.UserId);

            SubescribeStatus.ServiceStatus subescribeStatus = new SubescribeStatus.ServiceStatus(marzbanUser);

            await notificationService
                .AddNotificationAsync(
                    NotificationTemplate
                        .SendDeleteMarzbanUserNotificationForAgent(delete.AgentAdminId,
                            subescribeStatus
                                .GenerateServiceDeletionRequestMessage
                                (delete.Username, delete.ChatId,
                                    delete.Message), marzbanUser.Id), delete.UserId);

            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task MainDeleteMarzbanUserAsync(long marzbanUserId, long userId)
    {
        using IDbContextTransaction transaction = await marzbanUserRepository.context.Database.BeginTransactionAsync();
        try
        {
            MarzbanUser? marzbanUser = await marzbanUserRepository.GetEntityById(marzbanUserId);

            MarzbanUserDto marzbanUserFromServer = await GetMarzbanUserByUserIdAsync(marzbanUserId, marzbanUser.UserId);

            if (marzbanUser is null & marzbanUserFromServer.IsDelete)
                throw new AppException("شما قبلا این درخواست را برسی کردید");

            MarzbanServer? marzbanServer = await GetMarzbanServerByIdAsync(marzbanUser.MarzbanServerId);

            MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

            string token = await marzbanApiRequest.LoginAsync();

            if (string.IsNullOrEmpty(token))
                throw new MarzbanException(HttpStatusCode.NotFound, "سرور مرزبان در دست رس نیست");


            OrderDetail? orderDetail = await orderDetailRepository.GetEntityById(marzbanUser.OrderDetailId);

            long byteSize = 1073741824;
            long remaining_data = (marzbanUserFromServer.Data_Limit ?? 0) - (marzbanUserFromServer.Used_Traffic ?? 0);
            long remainingGb = remaining_data / byteSize;
            long remainingLimitGb = (marzbanUserFromServer.Data_Limit ?? 0) / byteSize;
            long gbPrice = orderDetail.ProductPrice != 0 ? ((orderDetail.ProductPrice / 2) / remainingLimitGb) * remainingGb : 0;
            long dayPrice = orderDetail.ProductPrice / 2;

            if (marzbanUserFromServer.Expire != null & marzbanUser.ServiceTime != null & marzbanUser.ServiceTime != 0)
            {
                DateTime utcNow = DateTime.UtcNow;
                long? expireUnixTimestamp = marzbanUserFromServer.Expire;

                DateTime expireDate = DateTimeOffset
                    .FromUnixTimeSeconds(expireUnixTimestamp ?? new DateTimeOffset(utcNow).ToUnixTimeSeconds())
                    .UtcDateTime;

                TimeSpan remainingTimeSpan = expireDate - utcNow;
                int remainingDays = remainingTimeSpan.Days;
                DateTime createdAtDate = marzbanUser.ModifiedDate;
                TimeSpan totalDuration = expireDate - createdAtDate;
                dayPrice = ((orderDetail.ProductPrice / 2) / marzbanUser.ServiceTime ?? 0) * remainingDays;
            }

            List<AgentsIncomesDetail> agentsIncomesDetail = await agentsIncomesDetailRepository
                .GetQuery().Where(x => x.OrderDetailId == orderDetail.Id)
                .ToListAsync();

            await orderRepository.DeleteEntity(orderDetail.OrderId);
            await orderRepository.SaveChanges(userId);

            long price = gbPrice + dayPrice;

            if (marzbanUserFromServer.Status == "limited" | marzbanUserFromServer.Status == "expired")
                price = 0;

            if (price != 0)
            {
                foreach (var agentIncomeDetail in agentsIncomesDetail)
                {
                    User? userBalance = await userRepository.GetEntityById(agentIncomeDetail.UserId);
                    userBalance.Balance -= agentIncomeDetail.Profit;
                    await userRepository.UpdateEntity(userBalance);
                    await userRepository.SaveChanges(userId);
                    await notificationService.AddNotificationAsync(
                        NotificationTemplate.DecreaseForDeleteService(userBalance.Id, marzbanUser.Username,
                            agentIncomeDetail.Profit), userId);
                }
            }


            User? user = await userRepository.GetEntityById(marzbanUser.UserId);
            user.Balance += price;

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(userId);

            MarzbanUserDto userDelete =
                await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(
                    MarzbanPaths.UserDelete + "/" + marzbanUser.Username,
                    HttpMethod.Delete);

            await notificationService.AddNotificationAsync(new()
            {
                Message = $"""
                           ✨ سرویس {marzbanUser.Username} با موفقیت حذف شد ✅
                           💰 مبلغ {price:N0} تومان به موجودی شما اضافه شد ✅
                           ممنون که از سرویس ما استفاده کردید! 🎉
                           """,
                UserId = marzbanUser.UserId,
            }, userId);

            marzbanUserRepository.DeletePermanent(marzbanUser);
            await marzbanUserRepository.SaveChanges(userId);

            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<string> RevokeMarzbanUserAsync(long marzbanUserId, long userId)
    {
        using IDbContextTransaction transaction = await marzbanUserRepository.context.Database.BeginTransactionAsync();
        try
        {
            MarzbanUser? marzbanUser = await marzbanUserRepository.GetEntityById(marzbanUserId);
            MarzbanServer? marzbanServer = await GetMarzbanServerByIdAsync(marzbanUser.MarzbanServerId);

            MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

            string token = await marzbanApiRequest.LoginAsync();

            if (string.IsNullOrEmpty(token))
                throw new MarzbanException(HttpStatusCode.NotFound, "سرور مرزبان در دست رس نیست");

            MarzbanUserDto serverUser =
                await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(
                    MarzbanPaths.UserUpdate + "/" + marzbanUser.Username + "/revoke_sub",
                    HttpMethod.Post);

            marzbanUser.Subscription_Url = serverUser.Subscription_Url;
            await marzbanUserRepository.UpdateEntity(marzbanUser);
            await marzbanUserRepository.SaveChanges(userId);
            return marzbanUser.Subscription_Url ?? "";
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<List<MarzbanUser?>> GetListExpireUserAsync(long marzbanServerId)
    {
        MarzbanServer? marzbanServer = await marzbanServerRepository.GetEntityById(marzbanServerId);

        MarzbanApiRequest marzbanApiRequest = new(marzbanServer ?? throw new AppException("سرور در دست رس نیست"));

        string token = await marzbanApiRequest.LoginAsync();

        if (string.IsNullOrEmpty(token))
            throw new MarzbanException(HttpStatusCode.NotFound, "سرور مرزبان در دست رس نیست");

        List<string> serverUser =
            await marzbanApiRequest.CallApiAsync<List<string>>(
                MarzbanPaths.UsersExpire,
                HttpMethod.Get);

        List<MarzbanUser?> marzbanUsers = (await marzbanUserRepository
            .GetQuery()
            .Where(x => serverUser.Any(u => u == x.Username.Trim()) & x.AddedHolderInbound == false)
            .ToListAsync())!;

        return marzbanUsers;
    }

    public async Task<List<string>> GetListExpireUsernameAsync(long marzbanServerId)
    {
        MarzbanServer? marzbanServer = await marzbanServerRepository.GetEntityById(marzbanServerId);

        MarzbanApiRequest marzbanApiRequest = new(marzbanServer ?? throw new AppException("سرور در دست رس نیست"));

        return
            await marzbanApiRequest.CallApiAsync<List<string>>(
                MarzbanPaths.UsersExpire,
                HttpMethod.Get);
    }

    public async Task<MarzbanUserDto?> GetMarzbanUserByUsernameAsync(string username, long userId)
    {
        MarzbanUser? marzbanUser = await marzbanUserRepository.GetQuery()
            .SingleOrDefaultAsync(x => EF.Functions.Like(x.Username, $"%{username}%") & x.UserId == userId);

        MarzbanServer marzbanServer = await GetMarzbanServerByIdAsync(marzbanUser.MarzbanServerId);
        MarzbanApiRequest marzbanApiRequest = new(marzbanServer);

        MarzbanUserDto response =
            await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(MarzbanPaths.UserGet + "/" + marzbanUser.Username,
                HttpMethod.Get);

        if (marzbanUser.UserId != userId) marzbanUser = null;

        response.MarzbanServerId = marzbanUser.MarzbanServerId;
        response.MarzbanVpnId = marzbanUser.MarzbanVpnId;
        response.Id = marzbanUser.Id;
        response.UserId = marzbanUser.UserId;
        response.ServiceTime = marzbanUser.ServiceTime;
        response.Volume = marzbanUser.Volume;

        return marzbanUser switch
        {
            null => null,
            _ => await UpdateMarzbanUserAsync(response, userId),
        };
    }

    public async Task NotDeleteMarzbanUserAsync(long id, long userId)
    {
        using IDbContextTransaction transaction = await marzbanUserRepository.context.Database.BeginTransactionAsync();
        try
        {
            MarzbanUser? marzbanUser = await marzbanUserRepository.GetEntityById(id);

            if (marzbanUser is not null & marzbanUser.IsDelete == false)
                throw new AppException("شما قبلا این درخواست را برسی کردید");


            AgentDto? parent = await agentService.GetAgentByAdminIdAsync(userId);
            List<UserDto> users = await agentService.GetAgentUserAsync(parent.Id);

            if (!users.Any(x => x.Id == marzbanUser.UserId))
                throw new AppException("شما مجاز به عدم حدف نیستید");

            marzbanUser.IsDelete = false;

            await notificationService.AddNotificationAsync(new()
            {
                Message = $"""
                           با حذف سرویس :{marzbanUser.Username} ❌
                            موافت نشد ❌
                           """,
                UserId = marzbanUser.UserId,
            }, userId);

            await marzbanUserRepository.UpdateEntity(marzbanUser);
            await marzbanUserRepository.SaveChanges(userId);

            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task ResetMarzbanUserDataUsedAsync(string username, MarzbanServer marzbanServer)
    {
        try
        {
            MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
            await marzbanApiRequest.LoginAsync();
            MarzbanUserDto? response = await marzbanApiRequest.CallApiAsync<MarzbanUserDto>(
                MarzbanPaths.UsersReset(username ?? throw new ApplicationException("خطا در برقراری ارتباط")),
                HttpMethod.Post, hasToken: true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new MarzbanException(HttpStatusCode.BadRequest, e.Message);
        }
    }


    public async Task DeleteMarzbanUserExpire(MarzbanServer? marzbanServer, long? beforeday, long? afterday)
    {
        try
        {
            MarzbanApiRequest marzbanApiRequest = new(marzbanServer);
            await marzbanApiRequest.LoginAsync();

            List<string> usernames = await marzbanApiRequest.CallApiAsync<List<string>>(
                MarzbanPaths.UserDeleteExpire(DateTime.UtcNow.AddDays(-(beforeday ?? 0))
                    .ToString("yyyy-MM-ddTHH:mm:ssZ")),
                HttpMethod.Delete);

            List<MarzbanUser?> marzbanUsers = (await marzbanUserRepository
                .GetQuery()
                .Where(x => usernames.Any(u => u == x.Username.Trim()) & x.AddedHolderInbound == false)
                .ToListAsync())!;

            await marzbanUserRepository.Deletes(marzbanUsers);
            await marzbanUserRepository.SaveChanges(1);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<List<MarzbanUserDto>> ListMarzbanUsersDeletedInQue(long agentId)
    {
        List<User> users = await userRepository
            .GetQuery()
            .Where(x => x.AgentId == agentId)
            .ToListAsync();

        var marzbanUsers = await marzbanUserRepository
            .GetQuery(true)
            .Where(x => x.IsDelete == true)
            .ToListAsync();

        var result = from marzbanUser in marzbanUsers
                     join user in users on marzbanUser.UserId equals user.Id into userGroup
                     from user in userGroup.DefaultIfEmpty()
                     select new MarzbanUserDto(marzbanUser, user);

        return result.ToList();
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
        mu.OnHoldExpireDuration = response.On_Hold_Expire_Duration;
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