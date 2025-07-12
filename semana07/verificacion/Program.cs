using System;
using System.Collections.Generic;

class VerificacionParentesis
{
    static void Main()
    {
        Console.WriteLine("Ingrese una fórmula para verificar si está balanceada:");
        string? entrada = Console.ReadLine();

        if (string.IsNullOrEmpty(entrada))
        {
            Console.WriteLine("No se ingresó ninguna fórmula.");
            return;
        }

        if (EstaBalanceada(entrada))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula no balanceada.");
    }

    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '[' || c == '{')
                pila.Push(c);
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pila.Count == 0) return false;

                char apertura = pila.Pop();
                if (!EsPar(apertura, c)) return false;
            }
        }

        return pila.Count == 0;
    }

    static bool EsPar(char a, char c)
    {
        return (a == '(' && c == ')') || (a == '[' && c == ']') || (a == '{' && c == '}');
    }
}



