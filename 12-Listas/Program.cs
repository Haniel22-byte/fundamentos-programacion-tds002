using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista de enteros
        List<int> numeros = new List<int>() { 10, 20, 30 };

        Console.WriteLine("Primer número: " + numeros[0]);
        Console.WriteLine("Cantidad de elementos: " + numeros.Count);

        Console.WriteLine("\nRecorriendo la lista:");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }

        // Lista de cadenas
        List<string> nombres = new List<string>() { "Haniel", "Carlos", "Ana" };
        Console.WriteLine("\nLista de nombres:");
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}
