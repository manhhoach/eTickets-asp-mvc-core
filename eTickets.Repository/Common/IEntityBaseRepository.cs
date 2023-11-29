using eTickets.Model;
using eTickets.Model.Common;
using System.Linq.Expressions;

namespace eTickets.Common
{
    public interface IEntityBaseRepository<T> where T : EntityBase
    {
        ApplicationDBContext GetContext();

        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includeProperties);

        Task<IEnumerable<T>> GetAllNoTracking();
        Task<IEnumerable<T>> GetAllNoTracking(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> GetAllAsQueryable();

        Task<T> GetById(int id);
        Task<T> GetById(int id, params Expression<Func<T, object>>[] includeProperties);

        Task<T> FindByCondition(Expression<Func<T, bool>> predicate);

        Task Add(T t);
        Task AddRange(IEnumerable<T> list);

        Task Update(int id, T t);

        Task Destroy(int id);


        Task SoftDelete(int id);
        Task DeleteRange(List<int> ids);
    }
}
