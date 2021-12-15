using System.ComponentModel.DataAnnotations;

namespace WebAPIGetOut.Domain
{
    public class ReciboProducto
    {
        [Key]
        public int Id_RecProd { get; set; }
        public int Id_Recibo { get; set; }
        public int Id_Producto { get; set; }

        public Recibo Recibo { get; set; }
        public Producto Producto { get; set; }
    }
}
