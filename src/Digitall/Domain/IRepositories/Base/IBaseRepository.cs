using System.Linq.Expressions;
using Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Domain.IRepositories.Base;

public interface IBaseRepository<TEntity> : IAsyncDisposable where TEntity : BaseEntity
{
    DbContext context { get; set; }
    IQueryable<TEntity> GetQuery();
    Task<IReadOnlyList<TEntity>> GetAllAsync();
    Task<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);

    Task<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeString = null,
        bool disableTracking = true);

    Task<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        List<Expression<Func<TEntity, object>>> includes = null,
        bool disableTracking = true);

    Task AddEntity(TEntity entity);
    Task AddEntities(IEnumerable<TEntity> entities);
    Task<TEntity?> GetEntityById(long entityId);
    Task UpdateEntity(TEntity entity);
    void DeleteEntity(TEntity entity);
    Task DeleteEntity(long entityId);
    void DeletePermanent(TEntity entity);
    Task DeletePermanent(long entityId);
    Task SaveChanges(long id);
}