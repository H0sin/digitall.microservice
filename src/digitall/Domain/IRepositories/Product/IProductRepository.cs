using Domain.IRepositories.Base;

namespace Domain.IRepositories.Product;

public interface IProductRepository : IBaseRepository<Entities.Product.Product>
{
}