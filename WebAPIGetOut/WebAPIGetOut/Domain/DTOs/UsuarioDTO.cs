namespace WebAPIGetOut.Domain.DTOs
{
    public class UsuarioDTO
    {
        public int Id_Usuario { get; set; }
        public int Id_Cli { get; set; }
        public int Id_Emp { get; set; }
        public string Nom_Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
