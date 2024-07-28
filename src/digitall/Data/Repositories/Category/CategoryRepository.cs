using Data.Context;
using Data.Repositories.Base;
using Domain.IRepositories.Category;

namespace Data.Repositories.Category;

public class CategoryRepository : BaseRepository<Domain.Entities.Category.Category>, ICategoryRepository
{
    public CategoryRepository(DigitallDbContext context) : base(context)
    {
    }
}