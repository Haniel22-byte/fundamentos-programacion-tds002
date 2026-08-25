using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista de enteros
        List<int> numeros = new List<int>();
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        Console.WriteLine("Primer número: " + numeros[0]);
        Console.WriteLine("Cantidad de elementos: " + numeros.Count);
    }
}
