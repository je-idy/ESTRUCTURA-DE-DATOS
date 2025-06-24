using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear(); // Limpia pantalla en cada ciclo
            Console.WriteLine("=====================================");
            Console.WriteLine("  MENÚ DE EJERCICIOS EN C#");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Mostrar asignaturas de un curso");
            Console.WriteLine("2. Números ganadores de la lotería");
            Console.WriteLine("3. Calcular media y desviación típica");
            Console.WriteLine("4. Producto de dos matrices");
            Console.WriteLine("5. Producto escalar de dos vectores");
            Console.WriteLine("0. Salir");
            Console.Write("\nSeleccione una opción (0-5): ");

            string? opcion = Console.ReadLine();

            Console.Clear();

            switch (opcion)
            {
                case "1":
                    Ejercicio1.Ejecutar();
                    break;
                case "2":
                    Ejercicio2.Ejecutar();
                    break;
                case "3":
                    Ejercicio3.Ejecutar();
                    break;
                case "4":
                    Ejercicio4.Ejecutar();
                    break;
                case "5":
                    Ejercicio5.Ejecutar();
                    break;
                case "0":
                    Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
