using System.Threading.Tasks;
using WebAPIGetOut.Domain;
using WebAPIGetOut.Domain.DTOs;

namespace WebAPIGetOut.Persistence.Interfaces
{
    public interface IProductoRepository : IRepository<Producto>
    {
        Task<Producto> GetByName(string name);
        
    }
}
