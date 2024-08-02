using System;

namespace EjercicioAbstraccion
{
    public class OperacionesMatematicas : Matematicas
    {
        public double Radio { get; set; }
        public double BaseT { get; set; }
        public double Altura { get; set; }
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public double Lado { get; set; }

        public override double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override double CalcularAreaTriangulo(double baseT, double altura)
        {
            return (baseT * altura) / 2;
        }

        public override double CalcularAreaRectangulo(double largo, double ancho)
        {
            return largo * ancho;
        }

        public override double CalcularAreaCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }
    }
}
