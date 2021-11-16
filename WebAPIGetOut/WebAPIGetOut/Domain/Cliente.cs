using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIGetOut.Domain
{
    public class Cliente
    {
        [Key]
        public int Id_Cli { get; set; }
        
        [StringLength(20)]
        public string Nom_Ape { get; set; }
        
        [StringLength(20)]
        public string Raz_Soc { get; set; }

        [StringLength(12)]
        public string Dni_Cuit { get; set; }

        [StringLength(20)]
        public string Dir { get; set; }

        [StringLength(14)]
        public string Tel { get; set; }

        [EmailAddress(ErrorMessage ="Ingrese un email válido")]
        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(20)]
        public bool Estado { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha_Alta { get; set; }

        //Relaciones
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
