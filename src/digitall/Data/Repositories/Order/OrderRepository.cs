using Data.Context;
using Data.Repositories.Base;
using Domain.IRepositories.Order;

namespace Data.Repositories.Order;

public class OrderRepository : BaseRepository<Domain.Entities.Order.Order>, IOrderRepository
{
    public OrderRepository(DigitallDbContext context) : base(context)
    {
    }
}