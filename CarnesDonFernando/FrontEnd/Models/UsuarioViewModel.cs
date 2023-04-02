namespace FrontEnd.Models
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = null!;
        public string Contrasenia { get; set; } = null!;


        public string Username { get; set; }
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
