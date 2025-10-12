

namespace Erp.Infrastructure.Services
{
    public class ServicesGeneric<T>(ApplicationDbContext context): IServices<T> where T : class
    {
        public async Task<int> CountAsync(Expression<Func<T, bool>> match)
        {
            return await context.Set<T>().AsNoTracking().CountAsync(match);
        }

        public  Task<bool> DeleteAsync(T entity)
        {
            if (entity == null) return Task.FromResult(false);
            context.Set<T>().Remove(entity);
            return Task.FromResult( true);
        }

        public  Task<bool> DeleteRangeAsync(List<T> entities)
        {
            if (entities?.Count> 0)
            {
                context.Set<T>().RemoveRange(entities);
                return Task.FromResult(true);
            }
            
                return Task.FromResult(false);
            
        }

        public async Task<bool> ExistAsync(Expression<Func<T, bool>> match)
        {
            return await context.Set<T>().AsNoTracking().AnyAsync(match);
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> match)
        {
            return await context.Set<T>().AsNoTracking().Where(match).ToListAsync();
        }

        public  IQueryable<T> GetAllQueryable(Expression<Func<T, bool>> match)
        {
            return  context.Set<T>().AsNoTracking().Where(match);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return id > 0 ? await context.Set<T>().FindAsync(id) : null;
        }

        public async Task<T?> GetItemAsync(Expression<Func<T, bool>> match)
        {
            return await context.Set<T>().AsNoTracking().FirstOrDefaultAsync(match);
        }

        public IQueryable<T> GetSelectedQuerable(Expression<Func<T, bool>> match, Expression<Func<T, T>> Selector)
        {
            return context.Set<T>().Where(match).Select(Selector);
        }

        public  Task<bool> SaveAsync(T entity)
        {
            if (entity == null) return Task.FromResult(false);
            context.Set<T>().Add(entity);
            return Task.FromResult(true);
        }

        public  Task<bool> SaveRangeAsync(List<T> entities)
        {
            if (entities?.Count > 0)
            {
                context.Set<T>().AddRange(entities);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public  async Task<decimal> SumAsync(Expression<Func<T, bool>> match, Expression<Func<T, decimal>> Selector)
        {
            return await context.Set<T>().Where(match).SumAsync(Selector);
        }

        public  Task<bool> UpdateAsync(T entity)
        {
            if (entity == null) return Task.FromResult(false);
            context.Set<T>().Update(entity);
            return Task.FromResult(true);
        }

        public  Task<bool> UpdateRangeAsync(List<T> entities)
        {
            if (entities?.Count > 0)
            {
                context.Set<T>().UpdateRange(entities);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}
