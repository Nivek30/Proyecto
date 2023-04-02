namespace BackEnd.Models
{
    public class UsuarioModel
    {

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = null!;
        public string Contrasenia { get; set; } = null!;
    }
}
