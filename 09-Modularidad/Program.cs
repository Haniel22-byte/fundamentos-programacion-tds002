using System;

class Program
{
    static void Main(string[] args)
    {
        MostrarMensaje();
        MostrarSuma(5, 7);
    }

    static void MostrarMensaje()
    {
        Console.WriteLine("Bienvenido al módulo de modularidad.");
    }

    static void MostrarSuma(int a, int b)
    {
        int resultado = a + b;
        Console.WriteLine("La suma es: " + resultado);
    }
}
