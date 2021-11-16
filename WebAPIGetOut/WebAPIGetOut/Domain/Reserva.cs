using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIGetOut.Domain
{
    public class Reserva
    {
        [Key]
        public int Id_Res { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha_Act { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha_Res { get; set; }
        [Required(ErrorMessage ="Ingrese la cantidad de participantes")]
        public int Nro_Par { get; set; }
        [Required(ErrorMessage ="Ingrese pago")]
        [StringLength(20)]
        public string Pago { get; set; }
        [StringLength(20)]
        public bool Estado { get; set; }

        //Relaciones
        public Cliente Cliente { get; set; }
        
    }
}
