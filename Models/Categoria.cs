namespace BlackpinkKeniaStoreAPI.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Relación: Una categoría tiene muchos productos
        public ICollection<Producto> Productos { get; set; }
    }
}
