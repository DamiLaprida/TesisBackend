using System.Threading.Tasks;
using WebAPIGetOut.Data;
using WebAPIGetOut.Persistence.Interfaces;

namespace WebAPIGetOut.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _context;
        public IProductoRepository Producto { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Producto = new ProductoRepository(_context);
           
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
