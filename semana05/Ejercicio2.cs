using System;
using System.Collections.Generic;

public class Ejercicio2
{
    public static void Ejecutar()
    {
        List<int> numerosGanadores = new List<int>();

        Console.WriteLine("Ingrese los 6 números ganadores de la lotería primitiva:");

        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"Número {i}: ");
            string? entrada = Console.ReadLine();
            bool convertido = int.TryParse(entrada, out int numero);

            if (convertido)
            {
                numerosGanadores.Add(numero);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Intente nuevamente.");
                i--; // Repetir la posición
            }
        }

        numerosGanadores.Sort(); // Ordenar de menor a mayor

        Console.WriteLine("\nNúmeros ganadores ordenados:");
        foreach (int numero in numerosGanadores)
        {
            Console.WriteLine("- " + numero);
        }
    }
}
