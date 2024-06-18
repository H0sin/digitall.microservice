using System.Linq.Expressions;
using Data.Context;
using Domain.Common;
using Domain.IRepositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Base;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly DigitallDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public BaseRepository(DigitallDbContext context)
    {
        _context = context;
        this.context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public DbContext context { get; set; }

    public IQueryable<TEntity> GetQuery()
    {
        return _dbSet.AsQueryable()
            .Where(x => x.IsDelete == false)
            .OrderByDescending(x => x.Id);
    }

    public async Task<IReadOnlyList<TEntity>> GetAllAsync()
    {
        return await _dbSet
            .Where(x => x.IsDelete == false)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }

    public async Task<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeString = null,
        bool disableTracking = true)
    {
        var query = _dbSet.AsQueryable();
        if (disableTracking) query = query.AsNoTracking();

        if (!string.IsNullOrWhiteSpace(includeString)) query.Include(includeString);

        if (predicate != null) query = query.Where(predicate);

        if (orderBy != null)
            return await orderBy(query).ToListAsync();

        return await query.ToListAsync();
    }

    public async Task<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        List<Expression<Func<TEntity, object>>> includes = null, bool disableTracking = true)
    {
        var query = _dbSet.AsQueryable();

        if (disableTracking) query = query.AsNoTracking();

        if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

        if (predicate != null) query = query.Where(predicate);

        if (orderBy != null)
            return await orderBy(query).ToListAsync();

        return await query.ToListAsync();
    }

    public async Task AddEntity(TEntity entity)
    {
        entity.CreateDate = DateTime.Now;
        entity.ModifiedDate = entity.CreateDate;
        await _dbSet.AddAsync(entity);
    }

    public async Task<TEntity?> GetEntityById(long entityId)
    {
        return await _dbSet.SingleOrDefaultAsync(s => s.Id == entityId);
    }

    public async Task UpdateEntity(TEntity entity)
    {
        entity.ModifiedDate = DateTime.Now;
        _context.Entry(entity).State = EntityState.Modified;
    }

    public void DeleteEntity(TEntity entity)
    {
        entity.IsDelete = true;
        UpdateEntity(entity);
    }

    public async Task DeleteEntity(long entityId)
    {
        TEntity entity = await GetEntityById(entityId);
        if (entity != null) DeleteEntity(entity);
    }

    public void DeletePermanent(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task DeletePermanent(long entityId)
    {
        TEntity entity = await GetEntityById(entityId);
        if (entity != null) DeletePermanent(entity);
    }

    public async Task SaveChanges(long id)
    {
        _context.UserId = id;
        await _context.SaveChangesAsync();
    }

    public async ValueTask DisposeAsync()
    {
        if (_context != null)
        {
            await _context.DisposeAsync();
        }
    }

    public async Task AddEntities(IEnumerable<TEntity> entities)
    {
        await _context.AddRangeAsync(entities);
    }
}