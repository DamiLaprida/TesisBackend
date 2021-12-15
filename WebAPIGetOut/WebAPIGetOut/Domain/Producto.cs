using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIGetOut.Domain
{
    public class Producto
    {
        [Key]
        public int Id_Prod { get; set; }
        public string Nombre { get; set; }
        public long Lote { get; set; }
        public int Cantidad { get; set; }
        public double Pre_Uni { get; set; }
        public double Total { get; set; }

        //Propiedades de navegación
        public virtual ICollection<ReciboProducto> ReciboProductos { get; set; }

    }
}
