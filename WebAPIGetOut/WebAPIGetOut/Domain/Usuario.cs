using System.ComponentModel.DataAnnotations;

namespace WebAPIGetOut.Domain
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        
        public int Id_Emp { get; set; }
        public string Nom_Usuario { get; set; }
        public string Contraseña { get; set; }

        //Propiedades de navegación
       
        public Empleado Empleado { get; set; }
    }
}
