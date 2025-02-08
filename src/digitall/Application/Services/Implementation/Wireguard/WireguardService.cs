using Application.Helper;
using Application.Http.Request;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Notification;
using Application.Services.Interface.Order;
using Application.Services.Interface.Wireguard;
using Application.Static.Template;
using Application.Utilities;
using Data.Migrations;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Wireguard;
using Domain.Entities.Account;
using Domain.Entities.Order;
using Domain.Entities.Transaction;
using Domain.Entities.Wireguard;
using Domain.Enums.Order;
using Domain.Exceptions;
using Domain.IRepositories.Account;
using Domain.IRepositories.Order;
using Domain.IRepositories.Transaction;
using Domain.IRepositories.Wireguard;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Application.Services.Implementation.Wireguard;

public class WireguardService(
    IWireguardServerRepository wireguardServerRepository,
    IWireguardVpnRepository wireguardVpnRepository,
    IWireguardVpnTemplateRepository wireguardVpnTemplateRepository,
    IPeerRepository peerRepository,
    IUserRepository userRepository,
    IOrderRepository orderRepository,
    IOrderDetailRepository orderDetailRepository,
    INotificationService notificationService,
    IAgentsIncomesDetailRepository agentsIncomesDetailRepository,
    IAgentService agentService) : IWireguardServices
{
    const long byteSize = 1073741824;

    public async Task<List<WireguardVpnDto>> GetWireguardVpnAsync()
    {
        var wireguardVpns = await wireguardVpnRepository
            .GetAsync(x => x.IsDelete == false, o =>
                o.OrderByDescending(z => z.Id), includeString: "WireguardVpnTemplates");

        return wireguardVpns.Select(x => new WireguardVpnDto(x, x.WireguardVpnTemplates)).ToList();
    }

    public async Task<WireguardVpnDto?> GetWireguardVpnByIdAsync(long id)
    {
        var wireguards = await wireguardVpnRepository
            .GetAsync(x => x.IsDelete == false & x.Id == id, o =>
                o.OrderByDescending(z => z.Id), includeString: "WireguardVpnTemplates");

        if (!wireguards.Any()) return null;

        var wireguardVpn = wireguards.First();

        return new WireguardVpnDto(wireguardVpn, wireguardVpn.WireguardVpnTemplates);
    }

    public async Task<ICollection<WireguardVpnTemplatesDto>> CountingWireguardVpnTemplatePrice(long vpnId, long userId,
        int days = 0)
    {
        CountingVpnPrice countingVpnPrice = new();
        IReadOnlyList<WireguardVpnTemplate>? templates = null;

        if (days > 0)
        {
            templates = await wireguardVpnTemplateRepository
                .GetAsync(x => x.WireguardVpnId == vpnId & x.Days == days);
        }
        else
        {
            templates = await wireguardVpnTemplateRepository
                .GetAsync(x => x.WireguardVpnId == vpnId);
        }

        var updatedTemplates = new List<WireguardVpnTemplatesDto>();

        foreach (var template in templates)
        {
            var finalPrice = await countingVpnPrice.CalculateFinalPrice(agentService, userId, template.Price);

            updatedTemplates.Add(new WireguardVpnTemplatesDto
            {
                Price = finalPrice,
                Days = template.Days,
                Title = template.Title,
                Id = template.Id,
                Gb = template.Gb,
                WireguardVpnId = template.WireguardVpnId
            });
        }

        return updatedTemplates;
    }

    public async Task<WireguardVpnTemplatesDto?> CountingWireguardVpnTemplatePriceByIdAsync(long id, long userId)
    {
        CountingVpnPrice countingVpnPrice = new();

        var template = await wireguardVpnTemplateRepository.GetEntityById(id);

        if (template is null) return null;

        var price = await countingVpnPrice.CalculateFinalPrice(agentService, userId, template.Price);

        return new(template, price);
    }

    public async Task<BuyWireguardResponseDto> BuyWireguardAccountAsync(BuyWireguardDto buy, long? userId = null,
        long? chatId = null)
    {
        await using var transaction = await peerRepository.context.Database.BeginTransactionAsync();

        try
        {
            #region variable

            WireguardVpnTemplatesDto? template = null;
            WireguardVpn? wireguardVpn = null;
            User? user = null;
            AgentDto? agent = null;
            var templatePrice = 0;

            var mainTemplate = await wireguardVpnTemplateRepository
                .GetEntityById(buy.WireguardVpnTemplateId ?? 0);

            CountingVpnPrice countingVpnPrice = new();

            #endregion

            #region set variable

            if (userId is not null) user = await userRepository.GetEntityById(userId ?? 0);

            if (chatId is not null)
                user = await userRepository.GetQuery().SingleOrDefaultAsync(x => x.ChatId == chatId);

            if (buy.WireguardVpnTemplateId != null)
                template = await CountingWireguardVpnTemplatePriceByIdAsync(buy.WireguardVpnTemplateId ?? 0, user.Id);

            wireguardVpn = await wireguardVpnRepository.GetEntityById(buy.WireguardVpnId);

            var server = await wireguardServerRepository.GetEntityById(wireguardVpn.WireguardServerId);

            #endregion

            AgentDto? isAgent = await agentService.GetAgentByAdminIdAsync(user.Id);

            if (user.Balance < template.Price)
            {
                if (isAgent == null && user?.Balance < template.Price)
                {
                    throw new BadRequestException("موجودی شما کافی نیست");
                }

                if (!(isAgent != null && isAgent.AmountWithNegative < user?.Balance - template.Price))
                {
                    throw new BadRequestException("موجودی شما کافی نیست");
                }
            }

            user!.Balance -= template.Price;

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(user.Id);


            var incomes = await countingVpnPrice.CalculateUserIncomes(agentService, user.Id, mainTemplate.Price,
                template.Gb,
                template.Days, wireguardVpn.GbPrice, wireguardVpn.DayPrice, mainTemplate.Price, 1);

            if (isAgent == null)
                agent = await agentService.GetAgentByUserIdAsync(user.Id);

            long? count = await peerRepository.GetQuery().Where(x => x.WireguardVpnId == buy.WireguardVpnId)
                .CountAsync();

            #region check name

            if (isAgent != null)
            {
                if (string.IsNullOrEmpty(isAgent.BrandName) ||
                    isAgent.BrandName.Contains("none") | isAgent.BrandName.Length < 2)
                    await notificationService.AddNotificationAsync(
                        NotificationTemplate.SetBrandName(isAgent.AgentAdminId), user.Id);
            }
            else if (string.IsNullOrEmpty(agent.BrandName) ||
                     agent.BrandName.Contains("none") | agent.BrandName.Length < 2)
                await notificationService.AddNotificationAsync(
                    NotificationTemplate.SetBrandName(agent.AgentAdminId), user.Id);


            string name = isAgent != null ? isAgent.BrandName + "_" + (count + 1) : agent.BrandName + "_" + (count + 1);

            #endregion

            var request = new WireguardApiRequest();

            var data = new RequestWireguard(WireguardApiPath.AddPeer(server, wireguardVpn.InterfaceName),
                HttpMethod.Post,
                new
                {
                    name,
                    dns = "1.1.1.1",
                    onHoldExpireDurection = template.Days * 86400000L,
                    totalVolume = template.Gb * 1024 * 1024 * 1024L,
                    mtu = 1280,
                    allowedIPs = new string[] { }
                });

            var response = await request.SendAsync(data);

            if (response.StatusCode != 0) throw new AppException("متاسفانه مشکلی در هنگام ساخت سرویس وایرگارد پیش آمد");

            int retry = 1;

            if (response.Message == "peer by name is exist")
            {
                while (retry < 20)
                {
                    var postfixNumber = new Random().Next(999, 9999);
                    
                    name = isAgent != null
                        ? isAgent.BrandName + postfixNumber
                        : agent.BrandName + postfixNumber;

                    data = new RequestWireguard(WireguardApiPath.AddPeer(server, wireguardVpn.InterfaceName),
                        HttpMethod.Post,
                        new
                        {
                            name,
                            dns = "1.1.1.1",
                            onHoldExpireDurection = template.Days * 86400000L,
                            totalVolume = template.Gb * 1024 * 1024 * 1024L,
                            mtu = 1280,
                            allowedIPs = new string[] { }
                        });

                    response = await request.SendAsync(data);

                    if (response.IsSuccess) break;

                    retry++;
                }
            }

            Domain.Entities.Order.Order order = new()
            {
                Description = "wireguard : " + name,
                UserId = user?.Id ?? 0,
                IsPaid = true,
                TracingCode = new Random().Next(10000, 99999899),
                PaymentDate = DateTime.Now,
                OrderDetails = new List<OrderDetail>()
                {
                    new()
                    {
                        Count = 1,
                        OrderDeatilType = OrderDeatilType.Wireguard,
                        ProductPrice = template.Price
                    }
                }
            };

            await orderRepository.AddEntity(order);
            await orderRepository.SaveChanges(user.Id);

            var peer = new Peer
            {
                Name = name,
                WireguardVpnId = buy.WireguardVpnId,
                UserId = user.Id,
                IsDelete = false,
                TotalVolume = template.Gb,
                TotalDay = template.Days,
                WireguardServerId = server.Id,
                OrderId = order.Id
            };

            await peerRepository.AddEntity(peer);
            await peerRepository.SaveChanges(user.Id);

            long orderDetailId = order.OrderDetails.First().Id;

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
                }, user.Id);

                i.TelegramUserName = u.TelegramUsername ?? "NOT_USERNAME";
                i.chatId = u.ChatId;

                IOrderedEnumerable<CalculatorUserIncome> newIncomes = incomes.OrderByDescending(x => x.AgentId);

                var largestAgentIncome = newIncomes.First();

                bool isLargestAgent = i == largestAgentIncome;

                await notificationService.AddNotificationAsync(
                    NotificationTemplate.IncomeFromPaymentAsync(
                        income: i,
                        userName: user.TelegramUsername ?? "NOT_USERNAME",
                        chatId: user.ChatId ?? 0,
                        price: template.Price,
                        userbalance: user.Balance,
                        createServiceTime: DateTime.Now,
                        marzbanVpnName: wireguardVpn.Name ?? "",
                        marzbanUsername: name,
                        isLargestAgent: isLargestAgent), user.Id);

                await userRepository.UpdateEntity(u);
            }


            var getRequest = new RequestWireguard(WireguardApiPath.GetPeerConfig(server, name), HttpMethod.Get);
            var peerConfig = await request.SendAsync(getRequest);

            if (!peerConfig.IsSuccess) throw new AppException("متاسفانه مشکلی در هنگام ساخت سرویس وایرگارد پیش آمد");

            await transaction.CommitAsync();

            return new BuyWireguardResponseDto(wireguardVpn.Name, name, peerConfig.Data.ToString(), template.Days,
                template.Gb);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            await transaction.RollbackAsync();
            throw new AppException(e.Message);
        }
    }

    public async Task<ICollection<WireguardVpnDto>> GetWireguardVpnsHaveTest()
    {
        var wireguard = await wireguardVpnRepository
            .GetAsync(x => x.Test_Active == true & x.IsDelete == false,
                o => o.OrderByDescending(c => c.Id), includeString: null);

        var wireguardVpns = wireguard.Select(x => new WireguardVpnDto(x));

        return wireguardVpns.ToList();
    }

    public async Task<BuyWireguardResponseDto> BuyWireguardAccountTestAsync(long id, long? userId = null,
        long? chatId = null)
    {
        await using var transaction = await peerRepository.context.Database.BeginTransactionAsync();

        try
        {
            #region variable

            WireguardVpn? wireguardVpn = null;
            User? user = null;
            AgentDto? agent = null;

            #endregion

            #region set variable

            if (userId is not null) user = await userRepository.GetEntityById(userId ?? 0);

            if (chatId is not null)
                user = await userRepository.GetQuery().SingleOrDefaultAsync(x => x.ChatId == chatId);

            wireguardVpn = await wireguardVpnRepository.GetEntityById(id);
            var server = await wireguardServerRepository.GetEntityById(wireguardVpn.WireguardServerId);

            #endregion

            AgentDto? isAgent = await agentService.GetAgentByAdminIdAsync(user.Id);

            if (user?.FinalCountTestMarzbanAccount > 2)
                throw new AppException("تعداد تست های دریافتی شما تمام شده است");

            if (isAgent == null)
                agent = await agentService.GetAgentByUserIdAsync(user.Id);

            long? count = await peerRepository.GetQuery().Where(x => x.WireguardVpnId == id)
                .CountAsync();

            #region check name

            if (isAgent != null)
            {
                if (string.IsNullOrEmpty(isAgent.BrandName) ||
                    isAgent.BrandName.Contains("none") | isAgent.BrandName.Length < 2)
                    await notificationService.AddNotificationAsync(
                        NotificationTemplate.SetBrandName(isAgent.AgentAdminId), user.Id);
            }
            else if (string.IsNullOrEmpty(agent.BrandName) ||
                     agent.BrandName.Contains("none") | agent.BrandName.Length < 2)
                await notificationService.AddNotificationAsync(
                    NotificationTemplate.SetBrandName(agent.AgentAdminId), user.Id);


            var postfixNumber = new Random().Next(999, 9999);
                    
            string name = isAgent != null
                ? isAgent.BrandName + postfixNumber
                : agent.BrandName + postfixNumber;

            #endregion

            var request = new WireguardApiRequest();

            var data = new RequestWireguard(WireguardApiPath.AddPeer(server, wireguardVpn.InterfaceName),
                HttpMethod.Post,
                new
                {
                    name,
                    dns = "1.1.1.1",
                    onHoldExpireDurection = wireguardVpn.Test_Days * 86400000L,
                    totalVolume = wireguardVpn.Test_TotalMg * 1024 * 1024L,
                    mtu = 1280,
                    allowedIPs = new string[] { }
                });

            var response = await request.SendAsync(data);

            int retry = 1;

            if (response.Message == "peer by name is exist")
            {
                while (retry < 20)
                {
                    name = isAgent != null
                        ? isAgent.BrandName + "_" + (count + retry)
                        : agent.BrandName + "_" + (count + retry);

                    data = new RequestWireguard(WireguardApiPath.AddPeer(server, wireguardVpn.InterfaceName),
                        HttpMethod.Post,
                        new
                        {
                            name,
                            dns = "1.1.1.1",
                            onHoldExpireDurection = wireguardVpn.Test_Days * 86400000L,
                            totalVolume = wireguardVpn.Test_TotalMg * 1024 * 1024L,
                            mtu = 1280,
                            allowedIPs = new string[] { }
                        });

                    response = await request.SendAsync(data);

                    if (response.IsSuccess) break;

                    retry++;
                }
            }

            if (response.StatusCode != 0) throw new AppException("متاسفانه مشکلی در هنگام ساخت سرویس وایرگارد پیش آمد");

            Domain.Entities.Order.Order order = new()
            {
                Description = "wireguard : " + name,
                UserId = user?.Id ?? 0,
                IsPaid = true,
                TracingCode = new Random().Next(10000, 99999899),
                PaymentDate = DateTime.Now,
                OrderDetails = new List<OrderDetail>()
                {
                    new()
                    {
                        Count = 1,
                        OrderDeatilType = OrderDeatilType.Wireguard,
                        ProductPrice = 0
                    }
                }
            };

            await orderRepository.AddEntity(order);
            await orderRepository.SaveChanges(userId ?? 1);

            var peer = new Peer
            {
                Name = name,
                WireguardVpnId = id,
                UserId = user?.Id ?? 0,
                IsDelete = false,
                TotalVolume = 0,
                TotalDay = 0,
                WireguardServerId = server.Id,
                OrderId = order.Id
            };

            await peerRepository.AddEntity(peer);
            await peerRepository.SaveChanges(userId ?? 1);

            var getRequest = new RequestWireguard(WireguardApiPath.GetPeerConfig(server, name), HttpMethod.Get);
            var peerConfig = await request.SendAsync(getRequest);

            if (!peerConfig.IsSuccess) throw new AppException("متاسفانه مشکلی در هنگام ساخت سرویس وایرگارد پیش آمد");

            user.FinalCountTestMarzbanAccount += 1;
            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(user.Id);

            await transaction.CommitAsync();

            return new BuyWireguardResponseDto(wireguardVpn.Name, name, peerConfig.Data.ToString(),
                wireguardVpn.Test_Days, wireguardVpn.Test_TotalMg);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            await transaction.RollbackAsync();
            throw new AppException(e.Message);
        }
    }

    public async Task<FilterPeer> FilterPeerAsync(FilterPeer filter)
    {
        IQueryable<Peer> query = peerRepository
            .GetQuery();

        if ((filter.UserId ?? 0) != 0)
            query = query.Where(i => i.UserId == filter.UserId);

        if (!string.IsNullOrEmpty(filter.Name))
            query = query.Where(x => EF.Functions.Like(x.Name, $"%{filter.Name}%"));

        IQueryable<PeerDto> users = query.Select(x => new PeerDto(x));

        await filter.Paging(users);

        return filter;
    }

    public async Task<List<PeerDto>> GetPeersAsync(long userId)
    {
        return await peerRepository.GetQuery().Where(x => x.UserId == userId).Select(x => new PeerDto(x)).ToListAsync();
    }

    public async Task<PeerInformationDto?> GetPeerInformationByIdAsync(long id)
    {
        var request = new WireguardApiRequest();

        var peer = await peerRepository.GetEntityById(id);

        if (peer is null) throw new NotFoundException("peer not found");

        var server = await wireguardServerRepository.GetEntityById(peer.WireguardServerId);

        var response =
            await request.SendAsync(new RequestWireguard(WireguardApiPath.GetPeer(server, peer.Name), HttpMethod.Get));

        if (!response.IsSuccess) throw new AppException("متاسفانه مشکلی در هنگام دریافت اطلاعات پیش آمد");

        PeerInformationDto peerInformation =
            JsonConvert.DeserializeObject<PeerInformationDto>(response.Data.ToString());

        peerInformation.VpnId = peer.WireguardVpnId;
        peerInformation.Id = peer.Id;

        return peerInformation;
    }

    public async Task<(string, string)> SendConnectionDetailsAsync(long id, long userId)
    {
        Peer? peer = await peerRepository.GetEntityById(id);

        if (peer is null) throw new NotFoundException($"peer not found by id {id}. user id {userId}");

        WireguardServer? server = await wireguardServerRepository.GetEntityById(peer.WireguardServerId);

        if (peer.UserId != userId) throw new AppException($"not found peer by id {id},user id {userId}");

        var request = new WireguardApiRequest();

        var getRequest = new RequestWireguard(WireguardApiPath.GetPeerConfig(server, peer.Name), HttpMethod.Get);

        var peerConfig = await request.SendAsync(getRequest);

        if (!peerConfig.IsSuccess) throw new AppException("متاسفانه مشکلی در هنگام ساخت سرویس وایرگارد پیش آمد");

        return (peerConfig.Data.ToString(), peer.Name);
    }

    public async Task<BuyWireguardResponseDto> RenewalWireguardAccount(BuyWireguardDto buy, long? chatId, long? userId)
    {
        await using var transaction = await peerRepository.context.Database.BeginTransactionAsync();

        try
        {
            WireguardVpnTemplatesDto? template = null;
            WireguardVpn? wireguardVpn = null;
            User? user = null;
            AgentDto? agent = null;
            var templatePrice = 0;

            CountingVpnPrice countingVpnPrice = new();
            Peer? peer = null;

            peer = await peerRepository.GetEntityById(buy.PeerId ?? 0);

            var mainTemplate = await wireguardVpnTemplateRepository.GetEntityById(buy.WireguardVpnTemplateId ?? 0);

            if (peer is null) throw new NotFoundException($"peer is not found by id {buy.PeerId}");

            if (chatId is null) user = await userRepository.GetEntityById(userId ?? 0);

            if (userId is null) user = await userRepository.GetQuery().SingleOrDefaultAsync(x => x.ChatId == chatId);

            if (buy.WireguardVpnTemplateId != null)
                template = await CountingWireguardVpnTemplatePriceByIdAsync(buy.WireguardVpnTemplateId ?? 0, user.Id);

            if (template is null) throw new NotFoundException($"template not a found by id {template.Id}");

            wireguardVpn = await wireguardVpnRepository.GetEntityById(buy.WireguardVpnId);

            var server = await wireguardServerRepository.GetEntityById(wireguardVpn.WireguardServerId);

            AgentDto? isAgent = await agentService.GetAgentByAdminIdAsync(user.Id);
            
            if (user.Balance < template.Price)
            {
                if (isAgent == null && user?.Balance < template.Price)
                {
                    throw new BadRequestException("موجودی شما کافی نیست");
                }

                if (!(isAgent != null && isAgent.AmountWithNegative < user?.Balance - template.Price))
                {
                    throw new BadRequestException("موجودی شما کافی نیست");
                }
            }

            user!.Balance -= template.Price;

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(user.Id);

            var incomes = await countingVpnPrice.CalculateUserIncomes(agentService, user.Id, mainTemplate.Price,
                template.Gb,
                template.Days, wireguardVpn.GbPrice, wireguardVpn.DayPrice, mainTemplate.Price, 1);

            Domain.Entities.Order.Order? order = await orderRepository.GetEntityById(peer.OrderId);

            var orderDetail = new OrderDetail()
            {
                Count = 1,
                ProductPrice = template.Price,
                OrderId = order.Id,
            };

            await orderDetailRepository.AddEntity(orderDetail);
            await orderDetailRepository.SaveChanges(user.Id);

            foreach (var i in incomes)
            {
                User? u = await userRepository.GetEntityById(i.UserId);

                i.BalanceBeforPayment = u.Balance;
                u.Balance += i.Balance;

                await agentService.AddAgentsIncomesDetailAsync(new AgentsIncomesDetail()
                {
                    OrderDetailId = orderDetail.Id,
                    Profit = i.Balance,
                    AgentId = i.AgentId,
                    UserId = i.UserId,
                    Percent = i.Percent,
                }, user.Id);

                i.TelegramUserName = u.TelegramUsername ?? "NOT_USERNAME";
                i.chatId = u.ChatId;

                IOrderedEnumerable<CalculatorUserIncome> newIncomes = incomes.OrderByDescending(x => x.AgentId);

                var largestAgentIncome = newIncomes.First();

                bool isLargestAgent = i == largestAgentIncome;

                await notificationService.AddNotificationAsync(
                    NotificationTemplate.IncomeFromPaymentAsync(
                        income: i,
                        userName: user.TelegramUsername ?? "NOT_USERNAME",
                        chatId: user.ChatId ?? 0,
                        price: template.Price,
                        userbalance: user.Balance,
                        createServiceTime: DateTime.Now,
                        marzbanVpnName: wireguardVpn.Name,
                        marzbanUsername: peer.Name,
                        renewal: true,
                        isLargestAgent: isLargestAgent), user.Id);

                await userRepository.UpdateEntity(u);
                await userRepository.SaveChanges(u.Id);
            }


            var api = new WireguardApiRequest();

            long currentEpochTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

            var request = new RequestWireguard(WireguardApiPath.ResetPeer(server, peer.Name), HttpMethod.Post, new
            {
                expireTime = currentEpochTime + (template.Days * 86400000L),
                totalVolume = template.Gb * 1024 * 1024 * 1024L
            });

            var response = await api.SendAsync(request);
            if (response.StatusCode != 0)
                throw new AppException("متاسفانه مشکلی در هنگام تمدید سرویس وایرگارد پیش آمد");

            var getRequest = new RequestWireguard(WireguardApiPath.GetPeerConfig(server, peer.Name), HttpMethod.Get);
            var peerConfig = await api.SendAsync(getRequest);

            if (!peerConfig.IsSuccess) throw new AppException("متاسفانه مشکلی در هنگام تمدید سرویس وایرگارد پیش آمد");

            peer.TotalDay = template.Days;
            peer.TotalVolume = template.Gb;

            await peerRepository.UpdateEntity(peer);
            await peerRepository.SaveChanges(user.Id);

            await transaction.CommitAsync();

            return new BuyWireguardResponseDto(
                wireguardVpn.Name,
                peer.Name,
                peerConfig.Data.ToString(),
                template.Days,
                template.Gb);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            await transaction.RollbackAsync();
            throw new AppException(e.Message);
        }
    }

    public async Task<bool> HaveDeletedWireguardServicesInDeleteQue(long userId)
    {
        return await peerRepository.GetQuery(true).AnyAsync(x => x.UserId == userId);
    }

    public async Task RequestDeletedWireguardService(DeleteWireguardServiceDto delete)
    {
        await using var transaction = await peerRepository.context.Database.BeginTransactionAsync();
        try
        {
            Peer? peer = await peerRepository.GetEntityById(delete.PeerId);

            if (peer is null | peer?.UserId != delete.UserId) throw new NotFoundException("peer not found");

            peer.IsDelete = true;
            peer.DeleteDescription = delete.Message;

            await peerRepository.UpdateEntity(peer);
            await peerRepository.SaveChanges(delete.UserId);

            PeerInformationDto? peerInformation = await GetPeerInformationByIdAsync(peer.Id);

            await notificationService.AddNotificationAsync(
                NotificationTemplate.SendDeleteWireguardAccountNotificationForAgent(
                    delete.AgentAdminId,
                    peerInformation.GenerateServiceDeletionRequestMessage(delete.Username, delete.ChatId,
                        delete.Message),
                    peer.Id), delete.UserId);

            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            await transaction.RollbackAsync();
            throw new AppException(e.Message);
        }
    }

    public async Task MainDeleteWireguardService(long id, long userId)
    {
        await using var transaction = await peerRepository.context.Database.BeginTransactionAsync();
        try
        {
            Peer? peer = await peerRepository.GetEntityById(id);

            if (peer is null)
                throw new NotFoundException("شما قبلا این درخواست را برسی کردید");

            var server = await wireguardServerRepository.GetEntityById(peer.WireguardServerId);

            var request = new WireguardApiRequest();

            var data = new RequestWireguard(WireguardApiPath.DeletePeer(server, peer.Name), HttpMethod.Delete);

            Domain.Entities.Order.Order? order = await orderRepository
                .GetQuery()
                .Include(x => x.OrderDetails.OrderByDescending(x => x.Id))
                .SingleOrDefaultAsync(x => x.Id == peer.OrderId);

            OrderDetail? orderDetail = order?.OrderDetails.FirstOrDefault();

            var getRequest = new RequestWireguard(WireguardApiPath.GetPeer(server, peer.Name), HttpMethod.Get);
            var getPeer = await request.SendAsync(getRequest);

            if (!getPeer.IsSuccess) throw new ApplicationException("web service occered error");

            var peerConfig = JsonConvert.DeserializeObject<GetPeerFromServerDto>(getPeer.Data.ToString());

            long remainingData = (peerConfig.TotalVolume - peerConfig.TotalReceivedVolume);
            long remainingGb = remainingData / byteSize;
            long remainingLimitGb = (peerConfig.TotalVolume) / byteSize;
            long gbPrice = orderDetail.ProductPrice != 0
                ? ((orderDetail.ProductPrice / 2) / remainingLimitGb) * remainingGb
                : 0;

            long dayPrice = orderDetail.ProductPrice / 2;

            if (peerConfig.ExpireTime != 0 & peer.TotalDay != null & peer.TotalDay != 0)
            {
                DateTime utcNow = DateTime.UtcNow;
                long? expireUnixTimestamp = peerConfig.ExpireTime;

                DateTime expireDate = DateTimeOffset
                    .FromUnixTimeMilliseconds(expireUnixTimestamp ?? new DateTimeOffset(utcNow).ToUnixTimeSeconds())
                    .UtcDateTime;

                TimeSpan remainingTimeSpan = expireDate - utcNow;
                int remainingDays = remainingTimeSpan.Days;
                DateTime createdAtDate = peer.ModifiedDate;
                dayPrice = (dayPrice / peer.TotalDay ?? 0) * remainingDays;
            }

            long price = gbPrice + dayPrice;

            if (peerConfig.Status == "limited" | peerConfig.Status == "expired")
                price = 0;

            List<AgentsIncomesDetail> agentsIncomesDetail = await agentsIncomesDetailRepository
                .GetQuery().Where(x => x.OrderDetailId == orderDetail.Id)
                .ToListAsync();

            await orderRepository.DeleteEntity(orderDetail.OrderId);
            await orderRepository.SaveChanges(userId);

            if (price != 0)
            {
                foreach (var agentIncomeDetail in agentsIncomesDetail)
                {
                    User? userBalance = await userRepository.GetEntityById(agentIncomeDetail.UserId);
                    userBalance.Balance -= agentIncomeDetail.Profit;
                    await userRepository.UpdateEntity(userBalance);
                    await userRepository.SaveChanges(userId);
                    await notificationService.AddNotificationAsync(
                        NotificationTemplate.DecreaseForDeleteService(userBalance.Id, peer.Name,
                            agentIncomeDetail.Profit), userId);
                }
            }

            User? user = await userRepository.GetEntityById(peer.UserId);
            user.Balance += price;

            await request.SendAsync(data);

            await notificationService.AddNotificationAsync(new()
            {
                Message = $"""
                           ✨ سرویس {peer.Name} با موفقیت حذف شد ✅
                           💰 مبلغ {price:N0} تومان به موجودی شما اضافه شد ✅
                           ممنون که از سرویس ما استفاده کردید! 🎉
                           """,
                UserId = peer.UserId,
            }, userId);

            peerRepository.DeletePermanent(peer);
            await peerRepository.SaveChanges(userId);

            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            Console.WriteLine(e);
            throw e;
        }
    }

    public async Task ChangeDeletedStatus(long id, bool deleted, long userId)
    {
        var peer = await peerRepository.GetEntityById(id);

        if (peer is null) throw new NotFoundException("peer not found");

        peer.IsDelete = deleted;

        await peerRepository.UpdateEntity(peer);
        await peerRepository.SaveChanges(userId);

        await notificationService.AddNotificationAsync(new()
        {
            Message = $"""
                       با حذف سرویس :{peer.Name} ❌
                        موافت نشد ❌
                       """,
            UserId = peer.UserId,
        }, userId);
    }

    public async Task ActiveWireguardAccount(long id)
    {
        try
        {
            var request = new WireguardApiRequest();

            Peer? peer = await peerRepository.GetEntityById(id);
            var server = await wireguardServerRepository.GetEntityById(peer.WireguardServerId);

            var data = new RequestWireguard(WireguardApiPath.ActivePeer(server, peer.Name), HttpMethod.Post);

            await request.SendAsync(data);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new AppException(e.Message);
        }
    }

    public async Task DisabledWireguardAccount(long id)
    {
        try
        {
            var request = new WireguardApiRequest();

            Peer? peer = await peerRepository.GetEntityById(id);
            var server = await wireguardServerRepository.GetEntityById(peer.WireguardServerId);

            var data = new RequestWireguard(WireguardApiPath.DisabledPeer(server, peer.Name), HttpMethod.Post);

            await request.SendAsync(data);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new AppException(e.Message);
        }
    }
}