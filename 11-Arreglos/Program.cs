using System;

class Persona
{
    public string Nombre;
    public int Edad;

    // Constructor
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persona p1 = new Persona("Haniel", 20);

        Console.WriteLine("Nombre: " + p1.Nombre);
        Console.WriteLine("Edad: " + p1.Edad);
    }
}
