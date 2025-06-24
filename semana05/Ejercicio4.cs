using System;
using System.Collections.Generic;

public class Ejercicio4
{
    public static void Ejecutar()
    {
        // Matriz A: 2x3
        List<List<int>> A = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 }
        };

        // Matriz B: 3x2
        List<List<int>> B = new List<List<int>>
        {
            new List<int> { -1, 0 },
            new List<int> { 0, 1 },
            new List<int> { 1, 1 }
        };

        // Verificamos compatibilidad para multiplicación
        if (A[0].Count != B.Count)
        {
            Console.WriteLine("No se pueden multiplicar: columnas de A != filas de B");
            return;
        }

        // Crear la matriz resultado (2x2)
        int filasA = A.Count;
        int columnasB = B[0].Count;
        int columnasA = A[0].Count;

        List<List<int>> resultado = new List<List<int>>();

        for (int i = 0; i < filasA; i++)
        {
            List<int> filaResultado = new List<int>();

            for (int j = 0; j < columnasB; j++)
            {
                int suma = 0;
                for (int k = 0; k < columnasA; k++)
                {
                    suma += A[i][k] * B[k][j];
                }
                filaResultado.Add(suma);
            }

            resultado.Add(filaResultado);
        }

        // Mostrar el resultado
        Console.WriteLine("Producto de A x B:");
        foreach (var fila in resultado)
        {
            foreach (var valor in fila)
            {
                Console.Write(valor + "\t");
            }
            Console.WriteLine();
        }
    }
}
