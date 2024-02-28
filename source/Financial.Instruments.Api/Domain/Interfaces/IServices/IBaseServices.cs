using System.Linq.Expressions;

namespace Financial.Instruments.Api.Domain.Interfaces.IServices
{
    public interface IBaseServices<T> where T : class
    {
        Task<T> Find(int Id);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate = null);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<bool> Delete(string Id);
    }
}
