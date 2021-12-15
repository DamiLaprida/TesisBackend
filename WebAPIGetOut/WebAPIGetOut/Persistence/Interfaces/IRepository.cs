using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebAPIGetOut.Persistence.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<List<T>> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity); 
        void Delete(T entity);
        void SaveChanges();
    }
}
