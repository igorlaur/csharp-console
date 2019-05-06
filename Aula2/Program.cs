using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Um diretor de uma empresas quer saber se os seus funcionários estão gostando da empresa, 
             porém caso alguém não goste ele quer saber o motivo. APENAS UM FUNCIONÁRIO.
            */
            string seNao;
            string situacaoFuncionario;
            Console.WriteLine("Você está gostando de trabalhar em nossa empresa? (Sim ou Não)");
            situacaoFuncionario = Console.ReadLine();

            if(situacaoFuncionario.ToLower() == "sim")
            {
                Console.WriteLine("Poxa, ficamos muito felizes em saber que você está gostando de trabalhar conosco!");
            }
            else if (situacaoFuncionario.ToLower() == "não")
            {
                Console.WriteLine("Poxa, como podemos melhorar?");
                seNao = Console.ReadLine();
                Console.WriteLine("A sua resposta é: " + seNao);
            }
            Console.ReadKey();
        }
    }
}
