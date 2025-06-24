using System;
using System.Collections.Generic;

public class Ejercicio1
{
    public static void Ejecutar()
    {
        // Creamos la lista de asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        // Mostramos las asignaturas en pantalla
        Console.WriteLine("Las asignaturas del curso son:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine("- " + asignatura);
        }
    }
}
