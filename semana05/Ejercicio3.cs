using System;
using System.Collections.Generic;
using System.Linq;

public class Ejercicio3
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese una muestra de números separados por comas:");
        string? entrada = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("No se ingresaron números.");
            return;
        }

        try
        {
            // Convertir la entrada en una lista de números
            List<double> numeros = entrada
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n.Trim()))
                .ToList();

            // Calcular la media
            double media = numeros.Average();

            // Calcular la desviación típica (desviación estándar)
            double sumaCuadrados = numeros.Sum(n => Math.Pow(n - media, 2));
            double desviacionTipica = Math.Sqrt(sumaCuadrados / numeros.Count);

            // Mostrar resultados
            Console.WriteLine($"\nMedia: {media:F2}");
            Console.WriteLine($"Desviación típica: {desviacionTipica:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Asegúrate de ingresar solo números válidos separados por comas.");
        }
    }
}
