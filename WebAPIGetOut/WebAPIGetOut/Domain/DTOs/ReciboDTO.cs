using System;

namespace WebAPIGetOut.Domain.DTOs
{
    public class ReciboDTO
    {
        public int Id_Recibo { get; set; }
        public int Id_Res { get; set; }
        public int Id_Cli { get; set; }
        public double Total { get; set; }
        public DateTime Fecha_Emi { get; set; }
    }
}
