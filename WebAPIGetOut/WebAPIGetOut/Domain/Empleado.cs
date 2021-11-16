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

        [StringLength(20)]
        public string Nom_Ape { get; set; }

        [StringLength(20)]
        public string Cargo { get; set; }

        [StringLength(12)]
        public string Cuit { get; set; }

        [StringLength(20)]
        public string Dir { get; set; }

        [StringLength(14)]
        public string Tel { get; set; }
        
        [EmailAddress]
        [StringLength(50)]
        public string Mail { get; set; }
        public bool Estado { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha_Alta { get; set; }

        //Relaciones
    }
}
