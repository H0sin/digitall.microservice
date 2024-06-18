using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Order;
using Domain.IRepositories.Order;

namespace Data.Repositories.Order;

public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(DigitallDbContext context) : base(context)
    {
    }
}