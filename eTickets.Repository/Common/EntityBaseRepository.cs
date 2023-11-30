using eTickets.Model;
using eTickets.Model.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace eTickets.Repository.Common
{
    public abstract class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : EntityBase
    {
        protected ApplicationDBContext _context;
        protected readonly DbSet<T> _dbSet;
        public EntityBaseRepository(ApplicationDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.Where(t => !t.IsDeleted).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet.Where(t => !t.IsDeleted);
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(t => t.Id == id && !t.IsDeleted);
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
            var entity = await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
            if (entity != null)
            {
                entity.DeletedDate = DateTime.Now;
                entity.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAllNoTracking()
        {
            return await _dbSet.Where(t => !t.IsDeleted).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllNoTracking(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet.Where(t => !t.IsDeleted).AsNoTracking();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();
        }

        public async Task<T> FindByCondition(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FindAsync(predicate);
        }

        public async Task AddRange(IEnumerable<T> list)
        {
            await _dbSet.AddRangeAsync(list);
            await _context.SaveChangesAsync();
        }

        public async Task Destroy(int id)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
            EntityEntry ee = _context.Entry<T>(entity);
            ee.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRange(List<int> ids)
        {
            var entities = await _dbSet.Where(e => ids.Contains(e.Id)).ToListAsync();
            _dbSet.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public IQueryable<T> GetAllAsQueryable()
        {
            return _dbSet.AsQueryable();
        }
    }
}
