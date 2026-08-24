using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        string nombre = "Haniel";
        int edad = 20;
        double precio = 120.50;
        int cantidad = 3;

        // Operaciones
        double total = precio * cantidad;

        // Condicional simple
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("Eres menor de edad.");
        }

        // Salida con formato
        Console.WriteLine("\n--- Resumen ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Precio: {0:C}", precio);
        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("Total: {0:C}", total);
    }
}
