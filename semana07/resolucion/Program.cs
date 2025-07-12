using System;
using System.Collections.Generic;

class TorresHanoi
{
    static Stack<int> origen = new Stack<int>();
    static Stack<int> destino = new Stack<int>();
    static Stack<int> auxiliar = new Stack<int>();

    static void Main()
    {
        Console.Write("Ingrese el número de discos: ");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int n) || n <= 0)
        {
            Console.WriteLine("Entrada inválida. Debe ingresar un número entero positivo.");
            return;
        }

        for (int i = n; i >= 1; i--)
            origen.Push(i);

        Resolver(n, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }

    static void Resolver(int n, Stack<int> o, Stack<int> d, Stack<int> a, string nomO, string nomD, string nomA)
    {
        if (n == 1)
        {
            d.Push(o.Pop());
            Console.WriteLine($"Mover disco 1 de {nomO} a {nomD}");
        }
        else
        {
            Resolver(n - 1, o, a, d, nomO, nomA, nomD);
            d.Push(o.Pop());
            Console.WriteLine($"Mover disco {n} de {nomO} a {nomD}");
            Resolver(n - 1, a, d, o, nomA, nomD, nomO);
        }
    }
}

