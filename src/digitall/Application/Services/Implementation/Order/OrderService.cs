using Application.Helper;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Order;
using Application.Services.Interface.Product;
using Application.Services.Implementation.Vpn;
using Domain.DTOs.Marzban;
using Domain.DTOs.Order;
using Domain.DTOs.Product;
using Domain.DTOs.Sanaei.Client;
using Domain.Entities.Account;
using Domain.Entities.Order;
using Domain.Enums.Order;
using Domain.Exceptions;
using Domain.IRepositories.Account;
using Domain.IRepositories.Order;
using Domain.IRepositories.Sanaei;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Services.Implementation.Order;

public class OrderService(
    IOrderRepository orderRepository,
    IOrderDetailRepository orderDetailRepository,
    IProductService productService,
    IAgentService agentService,
    IClientRepository clientRepository,
    IUserRepository userRepository) : IOrderService
{
    #region add

    public async Task<long> GetAllUserOrderPriceAsync(long userId)
    { 
        var totalProductPrice = await orderRepository
            .GetQuery()
            .Where(o => o.UserId == userId)
            .SelectMany(o => o.OrderDetails)
            .SumAsync(od => od.ProductPrice);

        return totalProductPrice;
    }

    public async Task<AddProductToOrderResult> AddProductToOrderAsync(List<AddProductToOrderDto> orders, long userId)
    {
        IDbContextTransaction transaction = await orderRepository.context.Database.BeginTransactionAsync();

        List<OrderDetail> orderDetails = new();

        User? user = await userRepository.GetEntityById(userId);
        if (user == null) throw new NotFoundException("کاربری با این شناسه یافت نشد");

        foreach (AddProductToOrderDto order in orders)
        {
            ProductDto product = await productService.GetProductByIdAsync(order.ProductId);

            var agentIds = await agentService.GetAgentRoot(user.AgentId);

            // using Percent percent = new(agentService);

            OrderDetail orderDetail = new()
            {
                ProductId = product.Id,
                Count = order.Count,
                // ProductPrice = await percent.Calculate(agentIds, product.Price),
            };

            orderDetails.Add(orderDetail);
        }

        if (orderDetails.Count == 0) throw new BadRequestException("لطفا حداقل یک محصول انتخاب کنید");

        Domain.Entities.Order.Order newOrder = new()
        {
            UserId = userId,
            OrderDetails = orderDetails,
            IsPaid = false,
            TracingCode = new Random().NextInt64(1000000000000, 9999999999999),
        };

        await orderRepository.AddEntity(newOrder);
        await orderRepository.SaveChanges(userId);

        await transaction.CommitAsync();

        return AddProductToOrderResult.Success;
    }

    #endregion

    #region filter

    public async Task<FilterOrderDto> FilterOrderAsync(FilterOrderDto filter)
    {
        IQueryable<Domain.Entities.Order.Order> query = orderRepository
            .GetQuery()
            .Include(x => x.OrderDetails)
            .ThenInclude(y => y.Product)
            .Include(x => x.OrderDetails)
            .ThenInclude(y => y.MarzbanUsers);

        #region filter

        if (filter.UserId != 0)
            query = query.Where(x => x.UserId == filter.UserId);

        #endregion

        IQueryable<OrderDto> orders = query.Select(o => new OrderDto()
        {
            PaymentDate = o.PaymentDate,
            IsPaid = o.IsPaid,
            TracingCode = o.TracingCode,
            Description = o.Description,
            UserId = o.UserId,
            OrderDetail = o.OrderDetails.Select(x => new OrderDetailDto()
            {
                Count = x.Count,
                ProductPrice = x.ProductPrice,
                ProductName = x.Product.ProductName,
                OrderDeatilType = x.OrderDeatilType,
                Id = x.Id,
                MarzbanUsers = x.MarzbanUsers!.Select(x => new MarzbanUserDto(x)).ToList()
            }).ToList()
        });

        await filter.Paging(orders);

        return filter;
    }

    public async Task PaymentOrderAsync()
    {
        throw new NotImplementedException();
    }

    #endregion
}