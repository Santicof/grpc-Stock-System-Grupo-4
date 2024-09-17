using Servidor.Infrastructure.Entities;

namespace Servidor.Infrastructure.Dtos
{
    public class UsuarioDto
    {
        public string NombreDeUsuario { get; set; }
        public string Password { get; set; }
        public Tienda Tienda { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Deshabilitado { get; set; }
    }
}
