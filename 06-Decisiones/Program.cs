using System;

class Program
{
    static void Main(string[] args)
    {
        int edad = 20;
        bool tieneLicencia = true;

        if (edad >= 18 && tieneLicencia)
        {
            Console.WriteLine("Puedes conducir.");
        }
        else
        {
            Console.WriteLine("No puedes conducir.");
        }
    }
}
