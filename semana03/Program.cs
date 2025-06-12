using System;

class Estudiante
{
    // Atributos del estudiante con required
    public int Id { get; set; }
    public required string Nombres { get; set; }
    public required string Apellidos { get; set; }
    public required string Direccion { get; set; }
    public string[] Telefonos { get; set; } = new string[3]; // Inicializado directamente

    // Método para mostrar la información del estudiante
    public void MostrarInformacion()
    {
        Console.WriteLine("===== INFORMACIÓN DEL ESTUDIANTE =====");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto de la clase Estudiante y asignar valores obligatorios
        Estudiante estudiante = new Estudiante
        {
            Id = 1,
            Nombres = "Juan",
            Apellidos = "Pérez",
            Direccion = "Av. Siempre Viva 123"
        };

        // Asignar teléfonos usando el array
        estudiante.Telefonos[0] = "0991111111";
        estudiante.Telefonos[1] = "0992222222";
        estudiante.Telefonos[2] = "0993333333";

        // Mostrar los datos del estudiante
        estudiante.MostrarInformacion();
    }
}
