using Domain.DTOs.Order;
using Domain.Enums.Order;

namespace Application.Services.Interface.Order;

public interface IOrderService
{
    Task<AddProductToOrderResult> AddProductToOrderAsync(List<AddProductToOrderDto> orders, long userId);
    Task<FilterOrderDto> FilterOrderAsync(FilterOrderDto filter);
    Task PaymentOrderAsync();
}