﻿using Actividad_10;

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
                Console.Clear();
                Console.WriteLine("1. Registrar Nuevo Producto");
                Console.WriteLine("2. Mostrar Todos los Productos");
                Console.WriteLine("3. Buscar Producto");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarProducto();
                        Console.ReadKey();
                        break;
                    case 2:
                        MostrarProductos();
                        Console.ReadKey();
                        break;
                    case 3:
                        BuscarProducto();
                        Console.ReadKey();
                        break;
                    case 4:
                        ejecutando = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida, por favor intenta de nuevo.");
                        Console.ReadKey();
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

public static void RegistrarProducto()
{
    Console.WriteLine("Selecciona el Tipo de Producto: ");
    Console.WriteLine("1. Teléfono");
    Console.WriteLine("2. Ordenador");
    Console.WriteLine("3. Tablet");
    int tipo = int.Parse(Console.ReadLine());

    Console.Write("Ingresa la Marca: ");
    string marca = Console.ReadLine();

    Console.Write("Ingresa el Número de Serie: ");
    string numeroDeSerie = Console.ReadLine();

    Console.Write("Ingresa el Modelo: ");
    string modelo = Console.ReadLine();

    switch (tipo)
    {
        case 1:
            Console.Write("Ingresa la Cantidad de SIMs: ");
            int cantidadDeSim = int.Parse(Console.ReadLine());
            productos.Add(new Teléfono(marca, numeroDeSerie, modelo, cantidadDeSim));
            break;
        case 2:
            Console.Write("Ingresa el Tamaño de RAM (GB): ");
            int tamanoRam = int.Parse(Console.ReadLine());
            productos.Add(new Ordenador(marca, numeroDeSerie, modelo, tamanoRam));
            break;
        case 3:
            Console.Write("¿Tiene Celular? (true/false): ");
            bool tieneCelular = bool.Parse(Console.ReadLine());
            productos.Add(new Tablet(marca, numeroDeSerie, modelo, tieneCelular));
            break;
        default:
            Console.WriteLine("Tipo de producto inválido.");
            break;
    }

    Console.WriteLine("Producto registrado con éxito.");
}
    private static void MostrarProductos()
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos registrados.");
            return;
        }

        foreach (var producto in productos)
        {
            Console.WriteLine(producto.MostrarInformacion());
        }
    }

    private static void BuscarProducto()
    {
        Console.Write("Ingresa el Número de Serie para Buscar: ");
        string numeroDeSerie = Console.ReadLine();

        var producto = productos.Find(p => p.NumeroDeSerie == numeroDeSerie);
        if (producto != null)
        {
            Console.WriteLine(producto.MostrarInformacion());
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }


}