using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Ventas ===");

        // Variables
        string cliente = "Haniel";
        List<string> productos = new List<string>() { "Mouse", "Teclado", "Monitor" };
        List<double> precios = new List<double>() { 500.00, 1200.00, 4500.00 };

        Console.WriteLine("\nCliente: " + cliente);
        Console.WriteLine("Productos disponibles:");
        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {productos[i]} - RD${precios[i]}");
        }
    }
}
