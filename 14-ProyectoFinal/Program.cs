using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Cobro - GymFit ===\n");

        // Precio por día
        const double precioNormal = 100.00;
        const double precioPremium = 150.00;

        // Beneficios de cada plan
        List<string> beneficiosNormal = new List<string>()
        {
            "Acceso al área de pesas",
            "Acceso a caminadoras",
            "Clases grupales básicas"
        };

        List<string> beneficiosPremium = new List<string>()
        {
            "Acceso al área de pesas",
            "Acceso a caminadoras",
            "Clases grupales avanzadas",
            "Entrenador personal",
            "Área de spa y sauna",
            "Suplementos incluidos"
        };

        // Solicitar nombre del cliente
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        // Selección de plan
        Console.WriteLine("\nPlanes disponibles:");
        Console.WriteLine("1. Normal (RD$100 por día)");
        Console.WriteLine("2. Premium (RD$150 por día)");
        Console.Write("\nSeleccione un plan (1-2): ");
        int plan = int.Parse(Console.ReadLine());

        double precioDia;
        List<string> beneficios;
        string nombrePlan;

        if (plan == 1)
        {
            precioDia = precioNormal;
            beneficios = beneficiosNormal;
            nombrePlan = "Normal";
        }
        else if (plan == 2)
        {
            precioDia = precioPremium;
            beneficios = beneficiosPremium;
            nombrePlan = "Premium";
        }
        else
        {
            Console.WriteLine("Opción inválida.");
            return;
        }

        // Selección de días
        Console.WriteLine("\nOpciones de días:");
        Console.WriteLine("1. 1 día");
        Console.WriteLine("2. 7 días");
        Console.WriteLine("3. 15 días");
        Console.WriteLine("4. 30 días");
        Console.Write("\nSeleccione una opción (1-4): ");
        int opcionDias = int.Parse(Console.ReadLine());

        int dias = 0;
        switch (opcionDias)
        {
            case 1: dias = 1; break;
            case 2: dias = 7; break;
            case 3: dias = 15; break;
            case 4: dias = 30; break;
            default:
                Console.WriteLine("Opción inválida.");
                return;
        }

        // Calcular monto total
        double total = CalcularTotal(precioDia, dias);

        // Resumen
        Console.WriteLine("\n--- Resumen de Pago ---");
        Console.WriteLine("Cliente: " + nombre);
        Console.WriteLine("Plan seleccionado: " + nombrePlan);
        Console.WriteLine("Días seleccionados: " + dias);
        Console.WriteLine("Precio por día: RD$" + precioDia);
        Console.WriteLine("Monto total a pagar: RD$" + total);

        Console.WriteLine("\nBeneficios incluidos:");
        foreach (string b in beneficios)
        {
            Console.WriteLine("- " + b);
        }

        Console.WriteLine("\n¡Gracias por elegir GymFit!");
    }

    static double CalcularTotal(double precioDia, int dias)
    {
        return precioDia * dias;
    }
}
