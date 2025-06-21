using System;

namespace Clinica
{
    public class Turno
    {
        public Paciente[] Pacientes = new Paciente[100];
        public string?[,] Agenda = new string?[7, 5]; // Ahora acepta valores nulos
        private int contador = 0;

        public void RegistrarTurno()
        {
            if (contador >= 100)
            {
                Console.WriteLine("No se pueden registrar más pacientes.");
                return;
            }

            Paciente paciente;
            Console.Write("Ingrese nombre del paciente: ");
            paciente.Nombre = Console.ReadLine() ?? "";
            Console.Write("Ingrese cédula: ");
            paciente.Cedula = Console.ReadLine() ?? "";
            Console.Write("Ingrese edad: ");
            paciente.Edad = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese día (0 a 6): ");
            int dia = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese hora (0 a 4): ");
            int hora = int.Parse(Console.ReadLine() ?? "0");

            if (Agenda[dia, hora] == null)
            {
                Agenda[dia, hora] = paciente.Nombre;
                Pacientes[contador] = paciente;
                contador++;
                Console.WriteLine("Turno registrado exitosamente.");
            }
            else
            {
                Console.WriteLine("Ese turno ya está ocupado.");
            }
        }

        public void MostrarTurnos()
        {
            Console.WriteLine("Agenda semanal:");
            for (int d = 0; d < 7; d++)
            {
                Console.Write($"Día {d + 1}: ");
                for (int h = 0; h < 5; h++)
                {
                    Console.Write($"[{Agenda[d, h] ?? "Libre"}] ");
                }
                Console.WriteLine();
            }
        }

        public void EliminarTurno()
        {
            Console.Write("Ingrese día (0 a 6): ");
            int dia = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese hora (0 a 4): ");
            int hora = int.Parse(Console.ReadLine() ?? "0");

            if (Agenda[dia, hora] != null)
            {
                Console.WriteLine($"Turno de {Agenda[dia, hora]} eliminado.");
                Agenda[dia, hora] = null;
            }
            else
            {
                Console.WriteLine("No hay turno en esa posición.");
            }
        }
    }
}


