using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIGetOut.Domain
{
    public class Empleado
    {
        [Key]
        public int Id_Empl { get; set; }
        public string Nom_Ape { get; set; }
        public string Cargo { get; set; }
        public string Cuit { get; set; }
        public string Dir { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public bool Estado { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha_Alta { get; set; }

        //Propiedades de navegación
        public virtual ICollection<ReservaEmpleado> ReservaEmpleados { get; set; }
    }
}
