using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static double ConverterMilhasParaKm(double milhas)
        {
            return milhas * 1.852;
        }

        static void Main(string[] args)
        {
            double milhas;
            double resultadoKm;

            Console.Write("Digite o número de Milhas: ");
            milhas = double.Parse(Console.ReadLine());

            resultadoKm = ConverterMilhasParaKm(milhas);

            Console.WriteLine($"Isso equivale a: {resultadoKm} km");
        }
    }
}