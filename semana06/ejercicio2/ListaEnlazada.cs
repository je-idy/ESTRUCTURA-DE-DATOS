using System;

public class ListaEnlazada
{
    private Nodo? cabeza = null;

    public void Agregar(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    public void Mostrar()
    {
        Nodo? actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    public void EliminarFueraDeRango(int min, int max)
    {
        // Eliminar desde el principio si hay que hacerlo
        while (cabeza != null && (cabeza.Dato < min || cabeza.Dato > max))
        {
            cabeza = cabeza.Siguiente;
        }

        Nodo? actual = cabeza;

        while (actual != null && actual.Siguiente != null)
        {
            if (actual.Siguiente.Dato < min || actual.Siguiente.Dato > max)
            {
                // Saltarse el nodo que no está en el rango
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
            else
            {
                actual = actual.Siguiente;
            }
        }
    }
}
