using Clinica;

class Program
{
    static void Main()
    {
        Turno agenda = new Turno();
        int opcion;

        do
        {
            Console.WriteLine("\n--- AGENDA CLÍNICA ---");
            Console.WriteLine("1. Registrar turno");
            Console.WriteLine("2. Ver turnos");
            Console.WriteLine("3. Eliminar turno");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine() ?? "0");

            switch (opcion)
            {
                case 1: agenda.RegistrarTurno(); break;
                case 2: agenda.MostrarTurnos(); break;
                case 3: agenda.EliminarTurno(); break;
                case 4: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }

        } while (opcion != 4);
    }
}


