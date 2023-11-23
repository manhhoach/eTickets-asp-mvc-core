using eTickets.Data;
using eTickets.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace eTickets.Generics
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase
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
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>()
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task Update(int id, T entity)
        {
            EntityEntry ee = _context.Entry<T>(entity);
            ee.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}
