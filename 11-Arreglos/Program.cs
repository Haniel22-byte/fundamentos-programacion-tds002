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

    // Método
    public void Saludar()
    {
        Console.WriteLine("Hola, soy " + Nombre + " y tengo " + Edad + " años.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persona p1 = new Persona("Haniel", 20);
        p1.Saludar();
    }
}
