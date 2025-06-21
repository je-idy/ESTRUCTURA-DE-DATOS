namespace Clinica
{
    public struct Paciente
    {
        public string Nombre;
        public string Cedula;
        public int Edad;

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}, Cédula: {Cedula}, Edad: {Edad}");
        }
    }
}



