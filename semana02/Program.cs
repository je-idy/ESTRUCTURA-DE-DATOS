using System;

namespace FigurasGeometricas
{
    // Clase que representa un Círculo
    public class Circulo
    {
        // Atributo privado que almacena el radio del círculo
        private double radio;

        // Constructor que recibe el valor del radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // CalcularArea es una función que devuelve un valor double, 
        // se utiliza para calcular el área de un círculo. 
        // Requiere como argumento el radio del círculo.
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro devuelve el perímetro (circunferencia) del círculo.
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase que representa un Rectángulo
    public class Rectangulo
    {
        // Atributos privados que almacenan la base y la altura del rectángulo
        private double baseRect;
        private double altura;

        // Constructor que recibe la base y la altura
        public Rectangulo(double baseRect, double altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        // CalcularArea devuelve el área del rectángulo usando base por altura
        public double CalcularArea()
        {
            return baseRect * altura;
        }

        // CalcularPerimetro devuelve la suma de todos los lados del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }
    }

    // Clase principal para probar las figuras
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto Círculo con radio 5
            Circulo miCirculo = new Circulo(5);
            Console.WriteLine("Área del Círculo: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro del Círculo: " + miCirculo.CalcularPerimetro());

            // Crear un objeto Rectángulo con base 4 y altura 6
            Rectangulo miRectangulo = new Rectangulo(4, 6);
            Console.WriteLine("Área del Rectángulo: " + miRectangulo.CalcularArea());
            Console.WriteLine("Perímetro del Rectángulo: " + miRectangulo.CalcularPerimetro());
        }
    }
}
