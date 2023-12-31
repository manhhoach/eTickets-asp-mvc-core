﻿using eTickets.Models.Common;
using System.Linq.Expressions;

namespace eTickets.Data
{
    public interface IEntityBaseRepository<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetById(int id);
        Task<T> GetById(int id, params Expression<Func<T, object>>[] includeProperties);
        Task Add(T t);
        Task Update(int id, T t);
        Task Delete(int id);
        Task SoftDelete(int id);
    }
}
