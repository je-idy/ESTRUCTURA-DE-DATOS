using System;
using System.Collections.Generic;

public class Ejercicio5
{
    public static void Ejecutar()
    {
        // Vectores
        List<int> u = new List<int> { 1, 2, 3 };
        List<int> v = new List<int> { -1, 0, 2 };

        // Verificamos que tengan la misma dimensión
        if (u.Count != v.Count)
        {
            Console.WriteLine("Los vectores deben tener la misma dimensión.");
            return;
        }

        // Producto escalar
        int productoEscalar = 0;
        for (int i = 0; i < u.Count; i++)
        {
            productoEscalar += u[i] * v[i];
        }

        // Mostrar resultado
        Console.WriteLine("Producto escalar de los vectores u · v = " + productoEscalar);
    }
}
