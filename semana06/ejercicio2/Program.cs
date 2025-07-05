using System;

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        Random rnd = new Random();

        // Generar 50 números aleatorios entre 1 y 999
        for (int i = 0; i < 50; i++)
        {
            int numero = rnd.Next(1, 1000);
            lista.Agregar(numero);
        }

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        // Leer valores mínimo y máximo del rango
        Console.Write("\nIngrese el valor mínimo del rango: ");
        int minimo = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el valor máximo del rango: ");
        int maximo = int.Parse(Console.ReadLine()!);

        // Eliminar nodos fuera del rango
        lista.EliminarFueraDeRango(minimo, maximo);

        Console.WriteLine("\nLista después de eliminar nodos fuera del rango:");
        lista.Mostrar();
    }
}


