namespace Servidor.Domain.Entities
{
    public class Tienda
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public bool Deshabilitado { get; set; }

    }
}
