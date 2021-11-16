using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIGetOut.Domain
{
    public class Recibo
    {   
        [Key]
        public int Id_Recibo { get; set; }
        public double Total { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha_Emi{ get; set; }

        //Relaciones
        public Reserva Reserva { get; set; }
        public Producto Producto { get; set; }

    }
}
