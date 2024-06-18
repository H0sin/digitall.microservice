using Data.Context;
using Data.Repositories.Base;
using Domain.IRepositories.Base;
using Domain.IRepositories.Product;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Product;

public class ProductRepository : BaseRepository<Domain.Entities.Product.Product>, IProductRepository
{
    public ProductRepository(DigitallDbContext context) : base(context)
    {
    }
}