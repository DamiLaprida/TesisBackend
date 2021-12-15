using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIGetOut.Domain
{
    public class Recibo
    {
        public Recibo()
        {
            ReciboProductos = new HashSet<ReciboProducto>();
        }

        [Key]
        public int Id_Recibo { get; set; }
        public int Id_Res { get; set; }
        public int Id_Cli { get; set; }
        public double Total { get; set; }
        public DateTime Fecha_Emi{ get; set; }

        //Propiedades de navegación
        public Reserva Reserva { get; set; }
       
        public virtual ICollection<ReciboProducto> ReciboProductos { get; set; }

    }
}
