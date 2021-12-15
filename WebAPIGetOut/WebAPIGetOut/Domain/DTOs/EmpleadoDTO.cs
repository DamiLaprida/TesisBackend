using System;

namespace WebAPIGetOut.Domain.DTOs
{
    public class EmpleadoDTO
    {
        public int Id_Empl { get; set; }
        public string Nom_Ape { get; set; }
        public string Cargo { get; set; }
        public string Cuit { get; set; }
        public string Dir { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha_Alta { get; set; }
    }
}
