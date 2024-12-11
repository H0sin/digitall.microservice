using Domain.DTOs.Vpn;
using Domain.IRepositories.Vpn;
using Domain.Entities.Account;
using Domain.IRepositories.Account;
using Microsoft.EntityFrameworkCore;
using Domain.DTOs.Account;
using Domain.DTOs.Country;
using Domain.DTOs.Marzban;
using Domain.DTOs.Order;
using Domain.DTOs.Sanaei.Client;

using Domain.Entities.Order;
using Domain.Entities.Sanaei;
using Domain.Entities.Vpn;
using Domain.Enums.Order;
using Domain.IRepositories.Country;
using Domain.IRepositories.Order;
using Domain.IRepositories.Product;
using Domain.IRepositories.Sanaei;
using Microsoft.EntityFrameworkCore.Storage;
using Application.Helper;
using Application.Utilities;
using Application.Services.Interface.Vpn;
using Application.Services.Interface.Country;
using Application.Services.Interface.Server;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Sanaei;
using Application.Services.Interface.Marzban;
using Domain.Exceptions;


namespace Application.Services.Implementation.Vpn;

public class VpnService(
    IVpnRepository vpnRepository,
    IServerService serverService,
    IAgentService agentService,
    IProductRepository productRepository,
    ICountryService countryService,
    IOrderRepository orderRepository,
    IVpnCountryRepository vpnCountryRepository,
    IClientRepository clientRepository,
    ISanaeiService sanaeiService,
    IMarzbanService marzbanService,
    IUserRepository userRepository)
    : IVpnService
{
    #region get


    public async Task<Domain.Entities.Vpn.Vpn> GetVpnByIdAsync(long Id)
    {
        Domain.Entities.Vpn.Vpn? vpn = await vpnRepository.GetEntityById(Id);

        if (vpn is null) throw new NotFoundException("وی پی انی با این شناسه یافت نشد");

        return vpn;
    }

    #endregion

    #region add

    public async Task<Domain.Entities.Vpn.Vpn?> AddVpnAsync(AddVpnDto vpn, long userId)
    {
        List<VpnCountry> vpnCountries = new();

        Domain.Entities.Vpn.Vpn newVpn = new()
        {
            Days = vpn.Days,
            NumberUser = vpn.NumberUser,
            TotoalGb = vpn.TotalGb
        };

        await vpnRepository.AddEntity(newVpn);
        await vpnRepository.SaveChanges(userId);

        foreach (long Id in vpn.CountryIds)
        {
            CountryDto? vpnCountry = await countryService.GetCountryByIdAsync(Id);
            if (vpnCountry is null) throw new NotFoundException("چنین کشوری وجود ندارد");

            vpnCountries.Add(new()
            {
                CountryId = Id,
                VpnId = newVpn.Id
            });
        }

        await vpnCountryRepository.AddEntities(vpnCountries);
        await vpnCountryRepository.SaveChanges(userId);

        return newVpn;
    }

    #endregion

    #region buy

    // public async Task<bool> BuyMarzbanVpnAsync(BuyMarzbanVpnDto vpn, long userId)
    // {
    //     IDbContextTransaction transaction = await vpnRepository.context.Database.BeginTransactionAsync();
    //
    //     // get user
    //     User? user = await userRepository.GetEntityById(userId);
    //
    //     //get agent ids
    //     var agentIds = await agentService.GetAgentRoot(user.AgentId);
    //
    //     // get marzban server by id
    //     MarzbanServer marzbanServer = await marzbanService.GetMarzbanServerByIdAsync(vpn.);
    //
    //
    //     // counting price
    //     // for percent
    //     using AgentPercent percent = new(agentService);
    //     long price = marzban.CountingPrice(marzbanServer);
    //     long productPrice = await percent.Calculate(agentIds, price);
    //     long totalPrice = price * marzban.Count;
    //     List<CalculatorUserIncome> incomes = await percent.CalculateBalanse(agentIds, price);
    //
    //     if (user.Balance < totalPrice) throw new BadRequestException("موجودی شما کافی نیست");
    //
    //     long finallIncome = (productPrice - incomes.Select(x => x.Balance).Sum()) * marzban.Count;
    //     incomes.Add(new(1, finallIncome));
    //
    //     foreach (var income in incomes)
    //     {
    //         User? us = await userRepository.GetEntityById(income.UserId);
    //         us.Balance += (us.Balance + (income.Balance * marzban.Count));
    //         userRepository.UpdateEntity(us);
    //     }
    //
    //     user.Balance -= totalPrice;
    //
    //     List<AddMarzbanUserDto> users = new();
    //
    //     long byteSize = 1073741824;
    //
    //     DateTime today = DateTime.Today;
    //     DateTime futureDate = today.AddDays(marzban.TotalDay);
    //     // Convert the future date to Unix timestamp (seconds since January 1, 1970)
    //     long unixTimestamp = ((DateTimeOffset)futureDate).ToUnixTimeSeconds();
    //     
    //     for (int i = 0; i < marzban.Count; i++)
    //     {
    //         users.Add(new()
    //         {
    //             Username = marzban.Title + "" + marzbanServer.Users + i,
    //             Expire = unixTimestamp.ToString(),
    //             Data_Limit_Reset_Strategy = "no_reset",
    //             Inbounds = { },
    //             Note = "",
    //             Proxies = new ProxiesDto(new { }, new { }, new { }, new { }),
    //             Status = "active",
    //             Data_Limit = (byteSize * marzban.TotalGb).ToString(),
    //         });
    //     }
    //
    //     await marzbanService.AddMarzbanUserAsync(users, marzbanServer.Id);
    //     
    //     List<Domain.Entities.Order.Order> orders = new()
    //     {
    //         new Domain.Entities.Order.Order()
    //         {
    //             Description = "خرید Vpn",
    //             UserId = userId,
    //             IsPaid = true,
    //             OrderDetails = new List<OrderDetail>()
    //             {
    //                 new()
    //                 {
    //                     Count = marzban.Count,
    //                     OrderDeatilType = OrderDeatilType.Vpn,
    //                 }
    //             }
    //         }
    //     };
    //     
    //     return true;
    // }

    public async Task BuyVpnAsync(BuyVpnDto buyVpn, long userId)
    {
        throw new NotImplementedException();
        // IDbContextTransaction transaction = await vpnRepository.context.Database.BeginTransactionAsync();
        //
        // try
        // {
        //     Domain.Entities.Product.Product? product = await productRepository
        //         .GetQuery()
        //         .Include(x => x.Vpn)
        //         .SingleOrDefaultAsync(x => x.Id == buyVpn.ProductId);
        //
        //     if (product == null) throw new NotFoundException("چنین محصولی وجود ندارد");
        //
        //     User? user = await userRepository.GetEntityById(userId);
        //     var agentIds = await agentService.GetAgentRoot(user.AgentId);
        //
        //     // using AgentPercent percent = new(agentService);
        //
        //     long productPrice = await percent.Calculate(agentIds, product!.Price);
        //     long totalPrice = productPrice * buyVpn.Count;
        //
        //     List<CalculatorUserIncome> incomes = await percent.CalculateBalanse(agentIds, product!.Price);
        //
        //     if (user.Balance < totalPrice) throw new BadRequestException("موجودی شما کافی نیست");
        //
        //     long finallIncome = (productPrice - incomes.Select(x => x.Balance).Sum()) * buyVpn.Count;
        //
        //     // incomes.Add(new(1, finallIncome));
        //
        //     foreach (var income in incomes)
        //     {
        //         User? us = await userRepository.GetEntityById(income.UserId);
        //         us.Balance += us.Balance + income.Balance * buyVpn.Count;
        //         userRepository.UpdateEntity(us);
        //     }
        //
        //     // income.Add(new (1,productPrice - ));
        //     user.Balance -= totalPrice;
        //
        //     List<AddProductToOrderDto> orders = new()
        //     {
        //         new AddProductToOrderDto()
        //         {
        //             ProductId = buyVpn.ProductId,
        //             Count = buyVpn.Count,
        //         }
        //     };
        //
        //     OrderDetail orderDetail = new()
        //     {
        //         ProductId = product.Id,
        //         Count = buyVpn.Count,
        //         ProductPrice = await percent.Calculate(agentIds, product.Price),
        //         OrderDeatilType = OrderDeatilType.Vpn
        //     };
        //
        //     if (orderDetail.Count == 0) throw new BadRequestException("لطفا حداقل یک محصول انتخاب کنید");
        //
        //     Domain.Entities.Order.Order newOrder = new()
        //     {
        //         UserId = userId,
        //         OrderDetails = new List<OrderDetail>()
        //         {
        //             orderDetail
        //         },
        //         IsPaid = true,
        //         TracingCode = new Random().NextInt64(1000000000000, 9999999999999),
        //     };
        //
        //     await orderRepository.AddEntity(newOrder);
        //     await orderRepository.SaveChanges(userId);
        //
        //     List<Domain.Entities.Country.Country> countries = await vpnCountryRepository
        //         .GetQuery()
        //         .Include(x => x.Country)
        //         .ThenInclude(y => y.Servers)
        //         .Where(x => x.VpnId == product.Vpn.Id && !x.Country.IsDelete &&
        //                     x.Country.Servers.Any(x => x.IsDelete == false))
        //         .Select(x => new Domain.Entities.Country.Country()
        //         {
        //             Id = x.Country.Id,
        //             Servers = x.Country.Servers,
        //             Name = x.Country.Name
        //         })
        //         .ToListAsync();
        //
        //     List<Domain.Entities.Server.Server> servers = new();
        //
        //     List<string> Guids = new();
        //
        //     for (int i = 0; i < buyVpn.Count; i++)
        //     {
        //         string _guid = Guid.NewGuid().ToString("N");
        //         Guids.Add(_guid);
        //     }
        //
        //     foreach (Domain.Entities.Country.Country country in countries)
        //     {
        //         servers.AddRange(country.Servers);
        //
        //         List<Client> clientsList = await clientRepository
        //             .GetQuery()
        //             .Where(x => x.CountryId == country.Id)
        //             .ToListAsync();
        //
        //         List<IGrouping<long, Client>> clientServer = clientsList
        //             .Join(servers,
        //                 c => c.ServerId,
        //                 cm => cm.Id,
        //                 (c, cm) => new
        //                 {
        //                     Client = c
        //                 })
        //             .Select(x => x.Client)
        //             .GroupBy(x => x.ServerId)
        //             .OrderBy(x => x.Count())
        //             .ToList();
        //
        //
        //         bool addClientResponse = false;
        //
        //         int i = 0;
        //
        //         while (!addClientResponse)
        //         {
        //             bool client = clientServer.Any();
        //
        //             if (!client)
        //                 throw new LogicException("امکان ارتباط با سرور خارجی نیست با پشتیبانی تماس بگیرید");
        //
        //             addClientResponse = await sanaeiService
        //                 .AddClientAsync(
        //                     new AddClientOptionsDto(
        //                         product.Vpn.Id,
        //                         clientServer[i].FirstOrDefault()!.ServerId,
        //                         userId,
        //                         buyVpn.Count,
        //                         clientServer[i].FirstOrDefault()!.CountryId,
        //                         Guids,
        //                         newOrder.OrderDetails.FirstOrDefault()!.Id,
        //                         new AddClientDto()
        //                         {
        //                             Email = buyVpn.Title,
        //                         }));
        //
        //             await Task.Delay(1000);
        //             i++;
        //         }
        //     }
        //
        //     await userRepository.UpdateEntity(user);
        //     await userRepository.SaveChanges(userId);
        //
        //     await transaction.CommitAsync();
        // catch (Exception e)
        // {
        //     await transaction.RollbackAsync();
        //     throw e;
        // }

    }
        

    #endregion

    #region filter

    public async Task<FilterVpnDto> FilterVpnAsync(FilterVpnDto filter, long userId)
    {
        throw new NotImplementedException();
        // IQueryable<Domain.Entities.Vpn.Vpn> query = vpnRepository.GetQuery().Include(x => x.Product);
        //
        // IQueryable<VpnDto> vpns = query.Select(x => new VpnDto
        // {
        //     ProductName = x.Product!.ProductName ?? "",
        //     ProductImage = PathExtension.ProductAvatarThumb + x.Product.ProductImage,
        //     Description = x.Product.Description ?? "",
        //     Price = x.Product.Price,
        //     Days = x.Days,
        //     ServerId = x.ServerId,
        //     NumberUser = x.NumberUser,
        //     Id = x.Product.Id
        // });
        //
        // await filter.Paging(vpns);
        //
        // User? user = await userRepository.GetEntityById(userId);
        //
        // if (user == null) throw new NotFoundException("کاربری با این شناسه یافت نشد");
        //
        // var agentIds = await agentService.GetAgentRoot(user.AgentId);
        //
        // using AgentPercent percent = new(agentService);
        //
        // foreach (VpnDto? entity in filter.Entities)
        // {
        //     entity.Price = await percent.Calculate(agentIds, entity.Price);
        // }
        //
        // return filter;
    }

    #endregion
}