using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Ventas ===");

        string cliente = "Haniel";
        List<string> productos = new List<string>() { "Mouse", "Teclado", "Monitor" };
        List<double> precios = new List<double>() { 500.00, 1200.00, 4500.00 };

        Console.WriteLine("\nCliente: " + cliente);
        Console.WriteLine("Productos disponibles:");
        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {productos[i]} - RD${precios[i]}");
        }

        Console.Write("\nElige un producto (1-3): ");
        int opcion = int.Parse(Console.ReadLine());
        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        double total = CalcularTotal(precios[opcion - 1], cantidad);

        Console.WriteLine($"\nHas comprado {cantidad} {productos[opcion - 1]} por un total de RD${total}");
        Console.WriteLine("\nGracias por tu compra, " + cliente + "!");
    }

    static double CalcularTotal(double precio, int cantidad)
    {
        return precio * cantidad;
    }
}
