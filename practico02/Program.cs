using System;
using System.Collections.Generic;

namespace ParqueDiversiones
{
    // Clase Persona con nombre y número de asiento
    public class Persona
    {
        public string Nombre { get; set; }
        public int NumeroAsiento { get; set; }

        public Persona(string nombre, int asiento)
        {
            Nombre = nombre;
            NumeroAsiento = asiento;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Asiento #{NumeroAsiento} - {Nombre}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue<Persona> colaEspera = new Queue<Persona>();
            int totalAsientos = 30;

            Console.WriteLine(" Asignación de asientos en la atracción\n");

            for (int i = 1; i <= totalAsientos; i++)
            {
                Console.Write($"Ingrese el nombre de la persona #{i}: ");
                string? nombre = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    nombre = $"Persona{i}";
                    Console.WriteLine($" No se ingresó nombre. Se asignó automáticamente: {nombre}");
                }

                Persona nuevaPersona = new Persona(nombre, i);
                colaEspera.Enqueue(nuevaPersona);

                // Mostrar inmediatamente el número de asiento asignado
                Console.WriteLine($" {nombre} ha sido asignado al asiento número {i}.\n");
            }

            Console.WriteLine("\n Personas que subirán a la atracción en orden de llegada:\n");

            while (colaEspera.Count > 0)
            {
                Persona personaSube = colaEspera.Dequeue();
                personaSube.MostrarDatos();
            }

            Console.WriteLine("\n Todos los asientos han sido asignados correctamente.");
            Console.ReadLine(); // Pausa para ver la salida
        }
    }
}

