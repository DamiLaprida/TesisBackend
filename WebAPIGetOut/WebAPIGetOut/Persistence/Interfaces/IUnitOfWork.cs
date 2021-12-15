using System;
using System.Threading.Tasks;

namespace WebAPIGetOut.Persistence.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductoRepository Producto { get; }
        Task<int> Complete();
    }
}
