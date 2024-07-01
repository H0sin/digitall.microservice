using Data.Repositories.Account;
using Data.Repositories.Agent;
using Data.Repositories.Authorization;
using Data.Repositories.Base;
using Data.Repositories.Agent;
using Data.Repositories.Category;
using Data.Repositories.Menu;
using Data.Repositories.Server;
using Data.Repositories.Transaction;
using Domain.IRepositories.Account;
using Domain.IRepositories.Agent;
using Domain.IRepositories.Authorization;
using Domain.IRepositories.Base;
using Domain.IRepositories.Category;
using Domain.IRepositories.Menu;
using Domain.IRepositories.Server;
using Domain.IRepositories.Transaction;
using Microsoft.Extensions.DependencyInjection;
using Domain.IRepositories.Product;
using Data.Repositories.Product;
using Data.Repositories.Country;
using Data.Repositories.Marzban;
using Data.Repositories.Order;
using Data.Repositories.Sanaei;
using Domain.Entities.Marzban;
using Domain.IRepositories.Country;
using Domain.IRepositories.Marzban;
using Domain.IRepositories.Order;
using Domain.IRepositories.Sanaei;
using Domain.IRepositories.Vpn;
using Application.Services.Interface.Order;
using Application.Services.Interface.Category;
using Application.Services.Implementation.Country;
using Application.Services.Interface.Menu;
using Application.Services.Interface.Authorization;
using Application.Services.Implementation.Server;
using Application.Services.Implementation.Account;
using Application.Services.Interface.Account;
using Application.Services.Interface.Notification;
using Application.Services.Implementation.Sanaei;
using Application.Services.Implementation.Transaction;
using Application.Services.Interface.Product;
using Application.Services.Interface.Vpn;
using Application.Services.Implementation.Product;
using Application.Services.Interface.Country;
using Application.Services.Implementation.Order;
using Application.Services.Interface.Server;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Sanaei;
using Application.Services.Interface.Transaction;
using Application.Services.Implementation.Category;
using Application.Services.Interface.Marzban;
using Application.Services.Implementation.Menu;
using Application.Services.Implementation.Agent;
using Application.Senders.Sms;
using Application.Services.Implementation.Authorization;
using Application.Services.Implementation.Vpn;
using Application.Services.Implementation.Marzban;
using Application.Services.Implementation.Telegram;
using Application.Services.Interface.Telegram;
using Data.Repositories.Telegram;
using Data.Repositories.Vpn;
using Domain.IRepositories.Telegram;

namespace Ioc;

public static class DependencyContainer
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        #region repository

        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IAgentRepository, AgentRepository>();
        services.AddScoped<IMenuRepository, MenuRepository>();
        services.AddScoped<IPermissionRepository, PermissionRepository>();
        services.AddScoped<ITransactionRepository, TransactionRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IServerRepository, ServerRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IRoleMenuRepository, RoleMenuRepository>();
        services.AddScoped<IUserRoleRepository, UserRoleRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IVpnRepository, VpnRepository>();
        services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
        services.AddScoped<IRolePermissionRepository, RolePermissionRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<IVpnCountryRepository, VpnCountryRepository>();
        services.AddScoped<IInboundRepository, InboundRepository>();
        services.AddScoped<IClientRepository, ClientRepository>();
        services.AddScoped<IMarzbanServerRepository, MarzbanServerRepository>();
        services.AddScoped<IMarzbanVpnRepository, MarzbanVpnRepository>();
        services.AddScoped<IMarzbanUserRepository, MarzbanUserRepository>();
        services.AddScoped<IMarzbanVpnTemplatesRepository, MarzbanVpnTemplatesRepository>();
        services.AddScoped<ITelegramBotRepository,TelegramBotRepository>();
        #endregion

        #region services

        services.AddScoped(typeof(ISendNotificationService<>), typeof(SendSmsService<>));
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IAgentService, AgentService>();
        services.AddScoped<IMenuService, MenuService>();
        services.AddScoped<IAuthorizeService, AuthorizeService>();
        services.AddScoped<ITransactionService, TransactionService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IServerService, ServerService>();
        services.AddScoped<IAuthorizeService, AuthorizeService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<ISanaeiService, SanaeiService>();
        services.AddScoped<IVpnService, VpnService>();
        services.AddScoped<ICountryService, CountryService>();
        services.AddScoped<IMarzbanService, MarzbanServies>();
        services.AddScoped<ITelegramService, TelegramService>();
        
        #endregion

        return services;
    }
}