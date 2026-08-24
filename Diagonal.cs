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
        static int áreadiagonal(int a)
        {
            return a * a /2;
        }

        static void Main(string[] args)
        {


            int diagonal;
            int resultado;

            Console.Write("Digite o valor da diagonal: ");
            diagonal = int.Parse(Console.ReadLine());

            Console.Write("A área do quadrado é: ");
            resultado = áreadiagonal(diagonal);
            Console.WriteLine(resultado);


        }
    }
}
