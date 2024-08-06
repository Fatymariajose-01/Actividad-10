using Actividad_10;

class Programa
{
    private static List<Producto> productos = new List<Producto>();

    static void Main()
    {
        bool ejecutando = true;

        while (ejecutando)
        {
            try
            {
                Console.WriteLine("1. Registrar Nuevo Producto");
                Console.WriteLine("2. Mostrar Todos los Productos");
                Console.WriteLine("3. Buscar Producto");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        //RegistrarProducto();
                        break;
                    case 2:
                        //MostrarProductos();
                        break;
                    case 3:
                        //BuscarProducto();
                        break;
                    case 4:
                        ejecutando = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida, por favor intenta de nuevo.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de entrada inválido. Por favor, ingresa un número.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}