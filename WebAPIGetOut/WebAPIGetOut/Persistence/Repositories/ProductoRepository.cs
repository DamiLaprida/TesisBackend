using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebAPIGetOut.Data;
using WebAPIGetOut.Domain;
using WebAPIGetOut.Persistence.Interfaces;

namespace WebAPIGetOut.Persistence.Repositories
{
    public class ProductoRepository : GenericRepository<Producto> , IProductoRepository
    {
        public ProductoRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Producto> GetByName(string name)
        {
            return await _context.Set<Producto>()
                .FirstOrDefaultAsync(x => x.Nombre == name);
        }
    }
}
