using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int multiplica(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {


            int altura;
            int baseretangulo;
            int resultado;

            Console.Write("Digite a altura: ");
            altura = int.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            baseretangulo = int.Parse(Console.ReadLine());

            Console.Write("A área do retangulo é: ");
            resultado = multiplica(altura, baseretangulo);
            Console.WriteLine(resultado);


        }
    }
}
