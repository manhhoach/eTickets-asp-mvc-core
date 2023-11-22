namespace eTickets.Data
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T t);
        Task Update(int id, T t);
        Task Delete(int id);
    }
}
