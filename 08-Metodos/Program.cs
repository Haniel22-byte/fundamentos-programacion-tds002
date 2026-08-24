using System;

class Program
{
    static void Main(string[] args)
    {
        // Arreglo de enteros
        int[] numeros = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Primer número: " + numeros[0]);
        Console.WriteLine("Último número: " + numeros[4]);

        // Recorrido con for
        Console.WriteLine("\nRecorriendo el arreglo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Elemento en posición " + i + ": " + numeros[i]);
        }

        // Arreglo de cadenas
        string[] nombres = { "Haniel", "Carlos", "Ana" };
        Console.WriteLine("\nLista de nombres:");
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}
