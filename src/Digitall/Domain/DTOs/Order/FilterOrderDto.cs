using Domain.DTOs.Paging;
using Domain.Enums.Order;

namespace Domain.DTOs.Order;

public class FilterOrderDto : BasePaging<OrderDto>
{
    public PaidStatus IsPaid { get; set; }
    public long UserId { get; set; }
}