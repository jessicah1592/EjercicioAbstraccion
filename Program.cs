using System;

namespace EjercicioAbstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacionesMatematicas operaciones = new OperacionesMatematicas();

            Console.WriteLine("Ingrese el radio del círculo:");
            operaciones.Radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Área del círculo: " + operaciones.CalcularAreaCirculo(operaciones.Radio));

            Console.WriteLine("Ingrese la base del triángulo:");
            operaciones.BaseT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triángulo:");
            operaciones.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Área del triángulo: " + operaciones.CalcularAreaTriangulo(operaciones.BaseT, operaciones.Altura));

            Console.WriteLine("Ingrese el largo del rectángulo:");
            operaciones.Largo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el ancho del rectángulo:");
            operaciones.Ancho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Área del rectángulo: " + operaciones.CalcularAreaRectangulo(operaciones.Largo, operaciones.Ancho));

            Console.WriteLine("Ingrese el lado del cuadrado:");
            operaciones.Lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Área del cuadrado: " + operaciones.CalcularAreaCuadrado(operaciones.Lado));

            operaciones.Imprimir();
        }
    }
}