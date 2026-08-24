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

        // Ciclo while
        int j = 5;
        while (j > 0)
        {
            Console.WriteLine("Cuenta regresiva: " + j);
            j--;
        }

        // Ciclo do-while: se ejecuta al menos una vez
        int k = 0;
        do
        {
            Console.WriteLine("Iteración do-while: " + k);
            k++;
        } while (k < 3);
    }
}


