using System;

class Program
{
    static void Main(string[] args)
    {
        // Ciclo for
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Número: " + i);
        }

        // Ciclo while: cuenta hacia atrás
        int j = 5;
        while (j > 0)
        {
            Console.WriteLine("Cuenta regresiva: " + j);
            j--;
        }
    }
}

