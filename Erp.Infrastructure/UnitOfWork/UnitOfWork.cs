

namespace Erp.Infrastructure.UnitOfWork
{
    public class UnitOfWork(ApplicationDbContext _context) : IUnitOfWork
    {
        public Dictionary<string, object> Repositories= new();
        public IServices<T> Repository<T>() where T : class
        {
            var type= typeof(T).Name;
            if (!Repositories.ContainsKey(type))
            {
                var repoinstance =new ServicesGeneric<T>(_context);
                Repositories.Add(type, repoinstance);
            }
            return (IServices < T >) Repositories[type];
        }
        public async Task<int> CompleteAsync()
        {
           return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}
