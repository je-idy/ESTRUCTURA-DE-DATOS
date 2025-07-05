using System;

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();

        // Agregar datos a la lista
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);
        lista.Agregar(40);
        lista.Agregar(50);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        // Invertir la lista
        lista.Invertir();

        Console.WriteLine("Lista invertida:");
        lista.Mostrar();
    }
}

