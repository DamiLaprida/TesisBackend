using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIGetOut.Domain;

namespace WebAPIGetOut.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {    
        }

        
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Recibo> Recibos { get; set; }
        public DbSet<ReciboProducto> ReciboProductos { get; set; }
        public DbSet<ReservaEmpleado> ReservaEmpleados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
