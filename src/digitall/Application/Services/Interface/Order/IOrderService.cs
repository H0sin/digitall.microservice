using Domain.DTOs.Order;
using Domain.Enums.Order;

namespace Application.Services.Interface.Order;

public interface IOrderService
{
    /// <summary>
    /// get all order price by userId
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<long> GetAllUserOrderPriceAsync(long userId);
    Task<AddProductToOrderResult> AddProductToOrderAsync(List<AddProductToOrderDto> orders, long userId);
    Task<FilterOrderDto> FilterOrderAsync(FilterOrderDto filter);
    Task PaymentOrderAsync();
}