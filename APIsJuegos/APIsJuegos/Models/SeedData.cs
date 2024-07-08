using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace APIsJuegos.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new JuegosContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<JuegosContext>>());
            
            if (context.Productos.Any())
            {
                return;
            }
            context.Productos.AddRange(
                new Producto
                {
                    Nombre="Gears of War",
                    Descripcion="Juego de peleas con dioses, armas y dioses con armas",
                    Imagen= "https://th.bing.com/th/id/OIP.dGip2_yNam3oGRksQ72nugHaEo?rs=1&pid=ImgDetMain",
                    Precio=200.30,
                    Categoria=2
                },
                new Producto
                {
                    Nombre = "Mario brons",
                    Descripcion = "Juego de un plomero con necesidad de comer hongos con el fin de recuperar el gobierno de su princesa",
                    Imagen = "https://th.bing.com/th/id/OIP.mFzBHHnrZhzEA1b-o64JoAHaLu?rs=1&pid=ImgDetMain",
                    Precio = 201.30,
                    Categoria = 1
                },
                new Producto
                {
                    Nombre = "Elden Ring",
                    Descripcion = "Elden Ring es el nuevo videojuego de rol, aventura y acción de FromSoftware y Bandai Namco. Ideado por Hidetaka Miyazaki y George R.R. Martin, el escritor de Canción de hielo y fuego, nos llevará a un mundo convulso, complejo y sangriento. En esta ocasión, el equipo de Dark Souls ha aumentado la escala del título, trasladando y depurando su conocida jugabilidad a una nueva dimensión.",
                    Imagen = "https://media.vandal.net/m/74234/elden-ring-202161213154579_1.jpg",
                    Precio = 201.30,
                    Categoria = 1
                },
                new Producto
                {
                    Nombre = "The Legend of Zelda: Tears of the Kingdom",
                    Descripcion = "de la saga de juegos de The Legend of Zelda, secuela directa de Breath of the Wild. Protagonizada por Link, y con una jugabilidad basada en la acción y el rol en mundo abierto, esta aventura nos devuelve a Hyrule con una búsqueda de la Princesa Zelda que cuenta con mecánicas de fusión de objetos y armas más avanzadas, nuevas zonas por explorar en los cielos y mucho más.",
                    Imagen = "https://th.bing.com/th/id/OIP.mFzBHHnrZhzEA1b-o64JoAHaLu?rs=1&pid=ImgDetMain",
                    Precio = 201.30,
                    Categoria = 1
                },
                new Producto
                {
                    Nombre = "Grand Theft Auto V",
                    Descripcion = "rand Theft Auto V para PS4 y Xbox One es una versión mejorada y ampliada del videojuego de acción en mundo abierto Grand Theft Auto V desarrollado por Rockstar lanzado en 2013. Esta versión del éxito, más ambiciosa técnicamente, presenta gráficos y nuevo contenido como armas, vehículos o misiones, además de una banda sonora ampliada y más jugadores en el modo online.",
                    Imagen = "https://th.bing.com/th/id/OIP.mFzBHHnrZhzEA1b-o64JoAHaLu?rs=1&pid=ImgDetMain",
                    Precio = 201.30,
                    Categoria = 1
                },
                new Producto
                {
                    Nombre = "Super Mario Bros. 3 CV",
                    Descripcion = "Super Mario Bros. 3 para la Consola Virtual de 3DS nos vuelve a poner en la piel del fontanero que, además, hace gala de sus diferentes poderes, como volar con Mario Mapache, nadar con el Traje Rana, lanza bolas de fuego con Mario de Fuego o convertirnos en una estatua con Mario Tanooki.",
                    Imagen = "https://th.bing.com/th/id/OIP.mFzBHHnrZhzEA1b-o64JoAHaLu?rs=1&pid=ImgDetMain",
                    Precio = 201.30,
                    Categoria = 1
                }
            );
            context.SaveChanges();

        }
    }
}