using System.Linq.Expressions;

namespace Financial.Instruments.Api.Domain.Interfaces.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Insert(T Objeto);
        Task<T> Update(T Objeto);
        Task<bool> Delete(int Id);
        Task<T> Find(int Id);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate = null);
    }

}
