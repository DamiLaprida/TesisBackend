using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIGetOut.Domain
{
    public class Reserva
    {
        public Reserva()
        {
            ReservaEmpleados = new HashSet<ReservaEmpleado>();
        }

        [Key]
        public int Id_Res { get; set; }
        public DateTime Fecha_Act { get; set; }
        public DateTime Fecha_Res { get; set; }
        public int Nro_Par { get; set; }
        public string Pago { get; set; }
        public bool Estado { get; set; }

        //Relaciones
       
        public virtual ICollection<ReservaEmpleado> ReservaEmpleados { get; set; }

    }
}
