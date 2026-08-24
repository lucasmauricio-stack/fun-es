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
        static int multiplica(int a)
        {
            return a * a;
        }

        static void Main(string[] args)
        {


            int aresta;
            int resultado;

            Console.Write("Digite o valor da aresta: ");
            aresta = int.Parse(Console.ReadLine());

            Console.Write("A área do quadrado é: ");
            resultado = multiplica(aresta);
            Console.WriteLine(resultado);


        }
    }
}
