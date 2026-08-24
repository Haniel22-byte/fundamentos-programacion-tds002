using System;

class Program
{
    static void Main(string[] args)
    {
        double precio = 120.50;
        double cantidad = 3;
        double total = precio * cantidad;

        Console.WriteLine("Precio: {0:C}", precio);
        Console.WriteLine("Cantidad: {0}", cantidad);
        Console.WriteLine("Total: {0:C}", total);
    }
}
