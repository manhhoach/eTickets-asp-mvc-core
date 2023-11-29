using eTickets.Model;
using eTickets.Model.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace eTickets.Common
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : EntityBase
    {
        private readonly ApplicationDBContext _context;
        public EntityBaseRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _context.Set<T>()
                .FirstOrDefaultAsync(e => e.Id == id);
            EntityEntry ee = _context.Entry<T>(entity);
            ee.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().Where(t => !t.IsDeleted).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().Where(t => !t.IsDeleted);
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();
        }


        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>()
                .FirstOrDefaultAsync(t => t.Id == id && !t.IsDeleted);
        }

        public async Task<T> GetById(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.FirstOrDefaultAsync(t => t.Id == id && !t.IsDeleted);
        }

        public async Task Update(int id, T entity)
        {
            EntityEntry ee = _context.Entry<T>(entity);
            ee.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task SoftDelete(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
            if (entity != null)
            {
                entity.DeletedDate = DateTime.Now;
                entity.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public ApplicationDBContext GetContext()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllNoTracking()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllNoTracking(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindByCondition(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task AddRange(IEnumerable<T> list)
        {
            throw new NotImplementedException();
        }

        public Task Destroy(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRange(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAllAsQueryable()
        {
            throw new NotImplementedException();
        }
    }
}
