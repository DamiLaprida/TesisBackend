using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebAPIGetOut.Data;
using WebAPIGetOut.Persistence.Interfaces;

namespace WebAPIGetOut.Persistence.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            try
            {
                var getById = await _context.Set<T>().FindAsync(id);
                
                if(getById == null)
                {
                    throw new Exception("No se ha podido encontrar el registro solicitado");
                }
                
                return getById;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<List<T>> Find(Expression<Func<T,bool>> expression)
        {
            return await _context.Set<T>().Where(expression).ToListAsync();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity); 
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new Exception("No se encontró el registro a actualizar");
            }

            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            if(entity == null)
            {
                throw new Exception("No se encontró el registro a eliminar");
            }

            _context.Set<T>().Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
