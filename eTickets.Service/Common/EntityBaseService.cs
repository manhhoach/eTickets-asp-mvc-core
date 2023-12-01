using eTickets.Model.Common;
using eTickets.Repository.Common;
using System.Linq.Expressions;

namespace eTickets.Service.Common
{
    public class EntityBaseService<T> : IEntityBaseService<T> where T : EntityBase
    {
        private readonly IEntityBaseRepository<T> _repository;
        public EntityBaseService(IEntityBaseRepository<T> repository)
        {
            _repository = repository;
        }
        public Task Add(T t)
        {
            if (t == null)
            {
                throw new ArgumentNullException();
            }
            return _repository.Add(t);
        }

        public Task AddRange(IEnumerable<T> list)
        {
            return _repository.AddRange(list);
        }

        public Task DeleteRange(List<int> ids)
        {
            return _repository.DeleteRange(ids);
        }

        public Task Destroy(int id)
        {
            return _repository.Destroy(id);
        }

        public Task<T> FindByCondition(Expression<Func<T, bool>> predicate)
        {
            return _repository.FindByCondition(predicate);
        }

        public Task<IEnumerable<T>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            return _repository.GetAll(includeProperties);
        }

        public IQueryable<T> GetAllAsQueryable()
        {
            return _repository.GetAllAsQueryable();
        }

        public Task<IEnumerable<T>> GetAllNoTracking()
        {
            return _repository.GetAllNoTracking();
        }

        public Task<IEnumerable<T>> GetAllNoTracking(params Expression<Func<T, object>>[] includeProperties)
        {
            return _repository.GetAllNoTracking(includeProperties);
        }

        public Task<T> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Task<T> GetById(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            return _repository.GetById(id, includeProperties);
        }

        public Task SoftDelete(int id)
        {
            return _repository.SoftDelete(id);
        }

        public Task Update(int id, T t)
        {
            return _repository.Update(id, t);
        }
    }
}
