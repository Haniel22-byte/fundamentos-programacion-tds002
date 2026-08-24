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

        bool llueve = false;
        bool tengoParaguas = true;

        if (llueve || tengoParaguas)
        {
            Console.WriteLine("Puedes salir sin problema.");
        }
        else
        {
            Console.WriteLine("Mejor espera un poco.");
        }

        int nota = 85;

        if (nota >= 90)
        {
            Console.WriteLine("Excelente");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}
