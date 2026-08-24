using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static double AreaTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2.0;
        }

        static void Main(string[] args)
        {
            double baseTriangulo;
            double altura;
            double resultado;

            Console.Write("Digite o valor da base: ");
            baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura: ");
            altura = double.Parse(Console.ReadLine());
            resultado = AreaTriangulo(baseTriangulo, altura);

            Console.WriteLine($"A área do triângulo é: {resultado}");
        }
    }
}