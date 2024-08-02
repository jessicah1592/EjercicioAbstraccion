using System;

namespace EjercicioAbstraccion
{
    public abstract class Matematicas
    {
        public abstract double CalcularAreaCirculo(double radio);
        public abstract double CalcularAreaTriangulo(double baseT, double altura);
        public abstract double CalcularAreaRectangulo(double largo, double ancho);
        public abstract double CalcularAreaCuadrado(double lado);

        public void Imprimir()
        {
            Console.WriteLine("Métodos matemáticos implementados:");
        }
    }
}
