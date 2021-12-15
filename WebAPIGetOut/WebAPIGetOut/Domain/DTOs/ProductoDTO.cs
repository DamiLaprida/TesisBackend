namespace WebAPIGetOut.Domain.DTOs
{
    public class ProductoDTO
    {
        public int Id_Prod { get; set; }
        public string Nombre { get; set; }
        public long Lote { get; set; }
        public int Cantidad { get; set; }
        public double Pre_Uni { get; set; }
        public double Total { get; set; }
    }
}
