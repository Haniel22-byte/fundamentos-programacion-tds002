using System;

class Persona
{
    public string Nombre;
    public int Edad;
}

class Program
{
    static void Main(string[] args)
    {
        Persona p1 = new Persona();
        p1.Nombre = "Haniel";
        p1.Edad = 20;

        Console.WriteLine("Nombre: " + p1.Nombre);
        Console.WriteLine("Edad: " + p1.Edad);
    }
}
