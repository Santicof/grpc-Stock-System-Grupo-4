namespace Servidor.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Talle { get; set; }
        public string Foto { get; set; }
        public string Color { get; set; }
        public int Stock { get; set; }
        public List<Tienda> Tiendas { get; set; }
    }
}
