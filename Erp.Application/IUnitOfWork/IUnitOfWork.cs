

namespace Erp.Application.IUnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        public IServices<T> Repository <T>() where T : class;
        Task<int> CompleteAsync();
    }
}
