using System.ComponentModel.DataAnnotations;

namespace WebAPIGetOut.Domain
{
    public class ReservaEmpleado
    {
        [Key]
        public int Id_ResEmp { get; set; }
        public int Id_Res { get; set; }
        public int Id_Emp { get; set; }

        //Relaciones
        public Reserva Reserva { get; set; }
        public Empleado Empleado { get; set; }
    }
}
