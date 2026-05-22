using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica_LINQ_CI
{
    // Clase Producto proporcionada
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaCreacion { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear la colección de 50 productos
            List<Producto> productos = GenerarProductos();

            Console.WriteLine("=== EJERCICIOS LINQ - PRÁCTICA 4 ===\n");

            // Ejecutar y mostrar cada ejercicio
            Ejercicio1(productos);
            Ejercicio2(productos);
            Ejercicio3(productos);
            Ejercicio4(productos);
            Ejercicio5(productos);
            Ejercicio6(productos);
            Ejercicio7(productos);
            Ejercicio8(productos);
            Ejercicio9(productos);
            Ejercicio10(productos);
            Ejercicio11(productos);
            Ejercicio12(productos);
            Ejercicio13(productos);
            Ejercicio14(productos);
            Ejercicio15(productos);
            Ejercicio16(productos);
            Ejercicio17(productos);
            Ejercicio18(productos);
            Ejercicio19(productos);
            Ejercicio20(productos);
            Ejercicio21(productos);
            Ejercicio22(productos);
            Ejercicio23(productos);
            Ejercicio24(productos);
            Ejercicio25(productos);
            Ejercicio26(productos);
            Ejercicio27(productos);
            Ejercicio28(productos);
            Ejercicio29(productos);
            Ejercicio30(productos);
            Ejercicio31(productos);
            Ejercicio32(productos);
            Ejercicio33(productos);
            Ejercicio34(productos);
            Ejercicio35(productos);
            Ejercicio36(productos);
            Ejercicio37(productos);
            Ejercicio38(productos);
            Ejercicio39(productos);
            Ejercicio40(productos);

            Console.WriteLine("\n=== FIN DE LOS EJERCICIOS ===");
            Console.ReadKey();
        }

        // Método para generar 50 productos de ejemplo
        static List<Producto> GenerarProductos()
        {
            var productos = new List<Producto>();
            var random = new Random();
            string[] categorias = { "Electrónica", "Audio", "Almacenamiento", "General", "Computadoras", "Telefonía" };
            string[] nombres = { "Laptop", "Mouse", "Teclado", "Monitor", "Audífonos", "Procesador", "Memoria RAM", "Disco Duro", "SSD", "Tablet", "Smartphone", "Cargador", "Cable HDMI", "Webcam", "Impresora", "Router", "Parlante", "Micrófono", "Batería", "Pantalla" };
            string[] descripciones = { "Producto de alta calidad", "Ideal para oficina", "Con pantalla táctil", "Resistente al agua", "Diseño ergonómico", "Con garantía extendida", "Edición limitada", "Para juegos", "Uso profesional", "Ecológico", "Con Bluetooth", "Alta velocidad", "Larga duración", "Compacto", "Portátil", "Inalámbrico", "Con retroiluminación", "Silencioso", "Alto rendimiento", "Básico", "Pro", "Avanzado" };

            for (int i = 1; i <= 50; i++)
            {
                productos.Add(new Producto
                {
                    Id = i,
                    Nombre = nombres[random.Next(nombres.Length)] + " " + (random.Next(100, 999)).ToString(),
                    Descripcion = descripciones[random.Next(descripciones.Length)],
                    Precio = (decimal)Math.Round(random.NextDouble() * 1500 + 10, 2),
                    Stock = random.Next(0, 100),
                    Categoria = categorias[random.Next(categorias.Length)],
                    FechaCreacion = new DateTime(2022, 12, 20).AddDays(random.Next(-365, 0))
                });
            }

            // Aseguramos algunos productos con condiciones específicas para que todos los ejercicios tengan resultados
            productos[0].Precio = 600;  // Para ejercicio 3
            productos[1].Stock = 3;     // Para ejercicio 4
            productos[2].Categoria = "Electrónica"; // Para ejercicio 5
            productos[3].Nombre = "Laptop Gamer"; // Para ejercicio 6
            productos[4].Precio = 250;  // Para ejercicio 7
            productos[5].Precio = 1200; // Para ejercicio 19
            productos[6].Stock = 8;     // Para ejercicio 20 (false)
            productos[7].Categoria = "Audio"; // Para ejercicio 21
            productos[8].Descripcion = "pantalla táctil HD"; // Para ejercicio 27
            productos[9].Categoria = "Almacenamiento"; // Para ejercicio 28
            productos[10].FechaCreacion = new DateTime(2022, 12, 20); // Para ejercicio 29
            productos[11].Precio = 150.50m; // Para ejercicio 32
            productos[12].Nombre = "Procesador Intel"; // Para ejercicio 35
            productos[13].Stock = 7; // Para ejercicio 34 (primo)
            productos[14].Descripcion = "Un producto con una descripción bastante larga"; // Para ejercicio 37
            productos[15].Precio = 300.00m; // Para ejercicio 38
            productos[16].Nombre = "Mouse Pad"; // Para ejercicio 39 (dos palabras)
            productos[17].Categoria = "Telefonía"; // No es "General" (para ejercicio 40)

            return productos;
        }

        // Método helper para mostrar una línea de separación y título
        static void MostrarTitulo(string titulo)
        {
            Console.WriteLine($"\n--- {titulo} ---");
        }

        // 1. Obtener todos los productos de la lista.
        static void Ejercicio1(List<Producto> productos)
        {
            MostrarTitulo("1. Todos los productos");
            var resultado = productos;
            foreach (var p in resultado)
                Console.WriteLine($"ID: {p.Id}, Nombre: {p.Nombre}, Precio: {p.Precio:C}, Stock: {p.Stock}, Categoría: {p.Categoria}");
        }

        // 2. Obtener los nombres de todos los productos.
        static void Ejercicio2(List<Producto> productos)
        {
            MostrarTitulo("2. Nombres de todos los productos");
            var resultado = productos.Select(p => p.Nombre);
            foreach (var nombre in resultado)
                Console.WriteLine(nombre);
        }

        // 3. Obtener los productos cuyo precio sea mayor a 500.
        static void Ejercicio3(List<Producto> productos)
        {
            MostrarTitulo("3. Productos con precio > 500");
            var resultado = productos.Where(p => p.Precio > 500);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Precio: {p.Precio:C}");
        }

        // 4. Obtener los productos con stock menor a 10.
        static void Ejercicio4(List<Producto> productos)
        {
            MostrarTitulo("4. Productos con stock < 10");
            var resultado = productos.Where(p => p.Stock < 10);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Stock: {p.Stock}");
        }

        // 5. Obtener los productos de la categoría "Electrónica".
        static void Ejercicio5(List<Producto> productos)
        {
            MostrarTitulo("5. Productos de Electrónica");
            var resultado = productos.Where(p => p.Categoria == "Electrónica");
            foreach (var p in resultado)
                Console.WriteLine(p.Nombre);
        }

        // 6. Obtener los productos cuyo nombre comience con la letra 'L'.
        static void Ejercicio6(List<Producto> productos)
        {
            MostrarTitulo("6. Productos que comienzan con 'L'");
            var resultado = productos.Where(p => p.Nombre.StartsWith("L"));
            foreach (var p in resultado)
                Console.WriteLine(p.Nombre);
        }

        // 7. Obtener los productos cuyo precio esté entre 100 y 500.
        static void Ejercicio7(List<Producto> productos)
        {
            MostrarTitulo("7. Productos con precio entre 100 y 500");
            var resultado = productos.Where(p => p.Precio >= 100 && p.Precio <= 500);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Precio: {p.Precio:C}");
        }

        // 8. Obtener los productos ordenados por precio ascendente.
        static void Ejercicio8(List<Producto> productos)
        {
            MostrarTitulo("8. Productos ordenados por precio ascendente");
            var resultado = productos.OrderBy(p => p.Precio);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Precio: {p.Precio:C}");
        }

        // 9. Obtener los productos ordenados por precio descendente.
        static void Ejercicio9(List<Producto> productos)
        {
            MostrarTitulo("9. Productos ordenados por precio descendente");
            var resultado = productos.OrderByDescending(p => p.Precio);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Precio: {p.Precio:C}");
        }

        // 10. Obtener los productos ordenados por nombre en orden alfabético.
        static void Ejercicio10(List<Producto> productos)
        {
            MostrarTitulo("10. Productos ordenados alfabéticamente");
            var resultado = productos.OrderBy(p => p.Nombre);
            foreach (var p in resultado)
                Console.WriteLine(p.Nombre);
        }

        // 11. Obtener los productos ordenados por stock de mayor a menor.
        static void Ejercicio11(List<Producto> productos)
        {
            MostrarTitulo("11. Productos ordenados por stock descendente");
            var resultado = productos.OrderByDescending(p => p.Stock);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Stock: {p.Stock}");
        }

        // 12. Obtener los primeros 5 productos más caros.
        static void Ejercicio12(List<Producto> productos)
        {
            MostrarTitulo("12. Los 5 productos más caros");
            var resultado = productos.OrderByDescending(p => p.Precio).Take(5);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Precio: {p.Precio:C}");
        }

        // 13. Obtener los 10 productos con menor stock.
        static void Ejercicio13(List<Producto> productos)
        {
            MostrarTitulo("13. Los 10 productos con menor stock");
            var resultado = productos.OrderBy(p => p.Stock).Take(10);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Stock: {p.Stock}");
        }

        // 14. Obtener la cantidad total de productos en la lista.
        static void Ejercicio14(List<Producto> productos)
        {
            MostrarTitulo("14. Cantidad total de productos");
            int total = productos.Count();
            Console.WriteLine($"Total: {total}");
        }

        // 15. Obtener la suma de todos los precios de los productos.
        static void Ejercicio15(List<Producto> productos)
        {
            MostrarTitulo("15. Suma de todos los precios");
            decimal suma = productos.Sum(p => p.Precio);
            Console.WriteLine($"Suma total: {suma:C}");
        }

        // 16. Obtener el precio promedio de los productos.
        static void Ejercicio16(List<Producto> productos)
        {
            MostrarTitulo("16. Precio promedio");
            decimal promedio = productos.Average(p => p.Precio);
            Console.WriteLine($"Promedio: {promedio:C}");
        }

        // 17. Obtener el producto más caro.
        static void Ejercicio17(List<Producto> productos)
        {
            MostrarTitulo("17. Producto más caro");
            var masCaro = productos.OrderByDescending(p => p.Precio).First();
            Console.WriteLine($"{masCaro.Nombre} - Precio: {masCaro.Precio:C}");
        }

        // 18. Obtener el producto más barato.
        static void Ejercicio18(List<Producto> productos)
        {
            MostrarTitulo("18. Producto más barato");
            var masBarato = productos.OrderBy(p => p.Precio).First();
            Console.WriteLine($"{masBarato.Nombre} - Precio: {masBarato.Precio:C}");
        }

        // 19. Verificar si hay algún producto con precio mayor a 1000.
        static void Ejercicio19(List<Producto> productos)
        {
            MostrarTitulo("19. ¿Existe algún producto con precio > 1000?");
            bool existe = productos.Any(p => p.Precio > 1000);
            Console.WriteLine(existe ? "Sí" : "No");
        }

        // 20. Verificar si todos los productos tienen stock mayor a 5.
        static void Ejercicio20(List<Producto> productos)
        {
            MostrarTitulo("20. ¿Todos los productos tienen stock > 5?");
            bool todos = productos.All(p => p.Stock > 5);
            Console.WriteLine(todos ? "Sí" : "No");
        }

        // 21. Contar cuántos productos hay en la categoría "Audio".
        static void Ejercicio21(List<Producto> productos)
        {
            MostrarTitulo("21. Cantidad en Audio");
            int cantidad = productos.Count(p => p.Categoria == "Audio");
            Console.WriteLine($"Cantidad: {cantidad}");
        }

        // 22. Agrupar los productos por categoría.
        static void Ejercicio22(List<Producto> productos)
        {
            MostrarTitulo("22. Agrupados por categoría");
            var grupos = productos.GroupBy(p => p.Categoria);
            foreach (var grupo in grupos)
            {
                Console.WriteLine($"Categoría: {grupo.Key} ({grupo.Count()} productos)");
                foreach (var p in grupo)
                    Console.WriteLine($"  - {p.Nombre}");
            }
        }

        // 23. Obtener la categoría con más productos.
        static void Ejercicio23(List<Producto> productos)
        {
            MostrarTitulo("23. Categoría con más productos");
            var categoria = productos.GroupBy(p => p.Categoria)
                                     .OrderByDescending(g => g.Count())
                                     .First();
            Console.WriteLine($"{categoria.Key} con {categoria.Count()} productos");
        }

        // 24. Obtener el stock total de todos los productos.
        static void Ejercicio24(List<Producto> productos)
        {
            MostrarTitulo("24. Stock total");
            int totalStock = productos.Sum(p => p.Stock);
            Console.WriteLine($"Stock total: {totalStock}");
        }

        // 25. Obtener el producto con el nombre más largo.
        static void Ejercicio25(List<Producto> productos)
        {
            MostrarTitulo("25. Producto con nombre más largo");
            var producto = productos.OrderByDescending(p => p.Nombre.Length).First();
            Console.WriteLine($"{producto.Nombre} (longitud: {producto.Nombre.Length})");
        }

        // 26. Obtener el producto con la descripción más corta.
        static void Ejercicio26(List<Producto> productos)
        {
            MostrarTitulo("26. Producto con descripción más corta");
            var producto = productos.OrderBy(p => p.Descripcion.Length).First();
            Console.WriteLine($"{producto.Nombre} - Descripción: \"{producto.Descripcion}\" (longitud: {producto.Descripcion.Length})");
        }

        // 27. Filtrar los productos cuya descripción contenga la palabra "pantalla".
        static void Ejercicio27(List<Producto> productos)
        {
            MostrarTitulo("27. Productos con 'pantalla' en la descripción");
            var resultado = productos.Where(p => p.Descripcion.Contains("pantalla"));
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - {p.Descripcion}");
        }

        // 28. Obtener el promedio de stock de los productos de la categoría "Almacenamiento".
        static void Ejercicio28(List<Producto> productos)
        {
            MostrarTitulo("28. Promedio de stock en Almacenamiento");
            var promedio = productos.Where(p => p.Categoria == "Almacenamiento")
                                    .Average(p => p.Stock);
            Console.WriteLine($"Promedio: {promedio:F2}");
        }

        // 29. Obtener los productos creados en una fecha específica (20/12/2022).
        static void Ejercicio29(List<Producto> productos)
        {
            MostrarTitulo("29. Productos creados el 20/12/2022");
            var fecha = new DateTime(2022, 12, 20);
            var resultado = productos.Where(p => p.FechaCreacion.Date == fecha);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Fecha: {p.FechaCreacion:dd/MM/yyyy}");
        }

        // 30. Obtener los productos cuya ID sea par.
        static void Ejercicio30(List<Producto> productos)
        {
            MostrarTitulo("30. Productos con ID par");
            var resultado = productos.Where(p => p.Id % 2 == 0);
            foreach (var p in resultado)
                Console.WriteLine($"ID: {p.Id}, {p.Nombre}");
        }

        // 31. Obtener los productos cuya ID sea impar.
        static void Ejercicio31(List<Producto> productos)
        {
            MostrarTitulo("31. Productos con ID impar");
            var resultado = productos.Where(p => p.Id % 2 != 0);
            foreach (var p in resultado)
                Console.WriteLine($"ID: {p.Id}, {p.Nombre}");
        }

        // 32. Obtener los productos cuyo precio tenga un decimal mayor a .50.
        static void Ejercicio32(List<Producto> productos)
        {
            MostrarTitulo("32. Productos con precio decimal > .50");
            var resultado = productos.Where(p => (p.Precio % 1) > 0.50m);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Precio: {p.Precio:C}");
        }

        // 33. Obtener los productos cuyo nombre tenga más de 10 caracteres.
        static void Ejercicio33(List<Producto> productos)
        {
            MostrarTitulo("33. Productos con nombre > 10 caracteres");
            var resultado = productos.Where(p => p.Nombre.Length > 10);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} ({p.Nombre.Length} caracteres)");
        }

        // 34. Obtener los productos cuyo stock sea un número primo.
        static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
                if (numero % i == 0) return false;
            return true;
        }
        static void Ejercicio34(List<Producto> productos)
        {
            MostrarTitulo("34. Productos con stock primo");
            var resultado = productos.Where(p => EsPrimo(p.Stock));
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Stock: {p.Stock}");
        }

        // 35. Obtener los productos cuyo nombre contenga la palabra "Pro".
        static void Ejercicio35(List<Producto> productos)
        {
            MostrarTitulo("35. Productos con 'Pro' en el nombre");
            var resultado = productos.Where(p => p.Nombre.Contains("Pro"));
            foreach (var p in resultado)
                Console.WriteLine(p.Nombre);
        }

        // 36. Obtener los productos cuyo stock sea un múltiplo de 5.
        static void Ejercicio36(List<Producto> productos)
        {
            MostrarTitulo("36. Productos con stock múltiplo de 5");
            var resultado = productos.Where(p => p.Stock % 5 == 0);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Stock: {p.Stock}");
        }

        // 37. Obtener los productos que tengan una descripción con más de 20 caracteres.
        static void Ejercicio37(List<Producto> productos)
        {
            MostrarTitulo("37. Productos con descripción > 20 caracteres");
            var resultado = productos.Where(p => p.Descripcion.Length > 20);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - {p.Descripcion} ({p.Descripcion.Length})");
        }

        // 38. Obtener los productos cuyo precio sea un número redondo (sin decimales).
        static void Ejercicio38(List<Producto> productos)
        {
            MostrarTitulo("38. Productos con precio entero");
            var resultado = productos.Where(p => p.Precio % 1 == 0);
            foreach (var p in resultado)
                Console.WriteLine($"{p.Nombre} - Precio: {p.Precio:C}");
        }

        // 39. Obtener los productos que tengan exactamente dos palabras en su nombre.
        static void Ejercicio39(List<Producto> productos)
        {
            MostrarTitulo("39. Productos con dos palabras en el nombre");
            var resultado = productos.Where(p => p.Nombre.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length == 2);
            foreach (var p in resultado)
                Console.WriteLine(p.Nombre);
        }

        // 40. Obtener la cantidad de productos que no pertenecen a la categoría "General".
        static void Ejercicio40(List<Producto> productos)
        {
            MostrarTitulo("40. Cantidad de productos no en 'General'");
            int cantidad = productos.Count(p => p.Categoria != "General");
            Console.WriteLine($"Cantidad: {cantidad}");
        }
    }
}