using System;

class Persona
{
    public string Nombre;
    public int Edad;

    public void Saludar()
    {
        Console.WriteLine("Hola, soy " + Nombre);
    }
}

class Estudiante : Persona
{
    public string Carrera;
}

class Program
{
    static void Main(string[] args)
    {
        Estudiante e1 = new Estudiante();
        e1.Nombre = "Haniel";
        e1.Edad = 20;
        e1.Carrera = "Informática";

        e1.Saludar();
        Console.WriteLine("Carrera: " + e1.Carrera);
    }
}
