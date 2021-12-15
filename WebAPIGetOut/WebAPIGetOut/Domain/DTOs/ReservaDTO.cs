using System;

namespace WebAPIGetOut.Domain.DTOs
{
    public class ReservaDTO
    {
        public int Id_Res { get; set; }
        public int Id_Cli { get; set; }
        public DateTime Fecha_Act { get; set; }
        public DateTime Fecha_Res { get; set; }
        public int Nro_Par { get; set; }
        public string Pago { get; set; }
        public bool Estado { get; set; }
    }
}
