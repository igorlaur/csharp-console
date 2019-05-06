using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Condicao;
            Console.WriteLine("Hello World");
            Console.WriteLine("How are you?");
            Condicao = Console.ReadLine();

            Console.WriteLine("A sua condição é: " + Condicao);

            Console.ReadKey();
        }
    }
}
