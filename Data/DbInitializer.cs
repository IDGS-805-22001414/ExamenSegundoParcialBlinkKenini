using BlackpinkKeniaStoreAPI.Models;

namespace BlackpinkKeniaStoreAPI.Data
{
    public static class DbInitializer
    {
        public static void Inicializar(AppDbContext context)
        {
            if (context.Categorias.Any()) return;

            var categorias = new Categoria[]
            {
                new Categoria { Nombre = "BLACKPINK" },
                new Categoria { Nombre = "KENIA OS" },
                new Categoria { Nombre = "ALBUMS SOLISTAS" }
            };

            context.Categorias.AddRange(categorias);
            context.SaveChanges();

            var productos = new Producto[]
            {
                new Producto { Nombre = "The Album", Descripcion = "El album más reconocido de Blackpink", Precio = 500, ImagenUrl = "https://popseoulmedia.com/cdn/shop/products/CapturadePantalla2021-02-22ala_s_11.11.53.png?v=1701291812", CategoriaId = 1 },
                new Producto { Nombre = "Born Pink", Descripcion = "Su último album antes de irse durante tres años", Precio = 700, ImagenUrl = "https://acdn-us.mitiendanube.com/stores/004/726/339/products/294eb581-2a16-4573-b328-a2a046e63608-600x679-937e5e0573189f9beb17254195326089-640-0.jpeg", CategoriaId = 1 },
                new Producto { Nombre = "Kill This Love", Descripcion = "Mezclas únicas de canciones inolvidables", Precio = 550, ImagenUrl = "https://images.tokopedia.net/img/cache/250-square/VqbcmM/2022/9/6/a8a050bf-a312-4cf2-8236-22483e770b52.jpg", CategoriaId = 1 },
                new Producto { Nombre = "Square One", Descripcion = "Revive los primeros éxitos de Blackpink", Precio = 446, ImagenUrl = "https://m.media-amazon.com/images/I/61Hkf5Z2sjL._UF1000,1000_QL80_.jpg", CategoriaId = 1 },
                new Producto { Nombre = "Square Up", Descripcion = "El inicio de su carrera exitosa con Dux4", Precio = 500, ImagenUrl = "https://m.media-amazon.com/images/I/512oxaG29KL._UF1000,1000_QL80_.jpg", CategoriaId = 1 },

                new Producto { Nombre = "Me - Jisoo", Descripcion = "Debut de la visual de Blackpink", Precio = 500, ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTOL3dzts4ntqdSuz9F4H72jMmZf9zTJisfiQ&s", CategoriaId = 3 },
                new Producto { Nombre = "Amortage - Jisoo", Descripcion = "Nueva era musical de Jisoo", Precio = 800, ImagenUrl = "https://down-br.img.susercontent.com/file/sg-11134207-7rcci-m6c15jw3bj62bb", CategoriaId = 3 },

                new Producto { Nombre = "Lalisa - Lisa", Descripcion = "Debut estrella de Lisa", Precio = 600, ImagenUrl = "https://m.media-amazon.com/images/I/61s2xrZtt9L._UF1000,1000_QL80_.jpg", CategoriaId = 3 },
                new Producto { Nombre = "AlterEgo - Lisa", Descripcion = "Nueva música, nueva Lisa", Precio = 700, ImagenUrl = "https://lightupk.com/cdn/shop/files/1_cd143d58-e7c0-499e-afc1-27b4e4f77189.png?v=1734929404", CategoriaId = 3 },

                new Producto { Nombre = "Solo - Jennie", Descripcion = "Primera solista del grupo", Precio = 500, ImagenUrl = "https://m.media-amazon.com/images/I/61mzOTNH3tL.jpg", CategoriaId = 3 },
                new Producto { Nombre = "Ruby - Jennie", Descripcion = "Álbum más completo del año", Precio = 900, ImagenUrl = "https://acdn-us.mitiendanube.com/stores/004/726/339/products/img_2059-23fefe21df6d981dca17376615971412-480-0.jpg", CategoriaId = 3 },

                new Producto { Nombre = "-R- - Rosé", Descripcion = "Debut emocional de nuestra vocalista", Precio = 300, ImagenUrl = "https://popseoulmedia.com/cdn/shop/files/00_01_137a169e-ef37-4827-a7a8-0d828a445bb9.jpg?v=1726247021", CategoriaId = 3 },
                new Producto { Nombre = "Rosie - Rosé", Descripcion = "Un álbum lleno de hermosos sentimientos", Precio = 450, ImagenUrl = "https://m.media-amazon.com/images/I/41c+8sza5wL._UF894,1000_QL80_.jpg", CategoriaId = 3 },

                new Producto { Nombre = "Cambios de Luna", Descripcion = "Canciones de amor y desamor", Precio = 800, ImagenUrl = "https://www.karzov.com.mx/cdn/shop/files/Imagen7_a6ee7a54-60ce-4c26-946c-a9fbe6ec322e.png?v=1743803128&width=1946", CategoriaId = 2 },
                new Producto { Nombre = "K23", Descripcion = "Te pondrá a bailar", Precio = 757, ImagenUrl = "https://ishopmx.vtexassets.com/arquivos/ids/223392/196587713829.jpg?v=638042198815000000", CategoriaId = 2 },
                new Producto { Nombre = "Pink Aura", Descripcion = "Música nueva y con ritmo", Precio = 725, ImagenUrl = "https://i.ebayimg.com/images/g/VdoAAOSwB~xmc8o3/s-l1200.jpg", CategoriaId = 2 },
            };

            context.Productos.AddRange(productos);
            context.SaveChanges();
        }
    }
}
