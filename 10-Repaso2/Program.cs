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

        // Condicional
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("Eres menor de edad.");
        }

        // Ciclo for
        Console.WriteLine("\nCiclo for:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Número: " + i);
        }

        // Vector
        int[] numeros = { 10, 20, 30, 40, 50 };
        Console.WriteLine("\nRecorriendo el vector:");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }

        // Matriz
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6}
        };
        Console.WriteLine("\nRecorriendo la matriz:");
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int col = 0; col < matriz.GetLength(1); col++)
            {
                Console.Write(matriz[fila, col] + " ");
            }
            Console.WriteLine();
        }

        // Métodos
        MostrarMensaje();
        MostrarSuma(5, 7);
        int resultado = Multiplicar(4, 3);
        Console.WriteLine("La multiplicación es: " + resultado);

        // Salida con formato
        Console.WriteLine("\n--- Resumen ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Precio: {0:C}", precio);
        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("Total: {0:C}", total);
    }

    static void MostrarMensaje()
    {
        Console.WriteLine("\nBienvenido al repaso 2.");
    }

    static void MostrarSuma(int a, int b)
    {
        int resultado = a + b;
        Console.WriteLine("La suma es: " + resultado);
    }

    static int Multiplicar(int x, int y)
    {
        return x * y;
    }
}
