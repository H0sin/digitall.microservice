using Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Data.SeedsData;

public static class SeedsData
{
    public static void AddData<TEntity>(this ModelBuilder model, List<TEntity> data) where TEntity : BaseEntity
    {
        model.Entity<TEntity>().HasData(data);
    }
}