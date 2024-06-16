using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer7
{
    internal class Atividade7
    {
        static void Main(string[] args)
        {
            int cont=1;
            Console.WriteLine("escreva a frase");
            string str = Console.ReadLine();
            foreach(char i in str)
            {
                if (i ==' ')
                {
                    cont++;
                }
            }
            Console.WriteLine($"número de palavras: {cont}");
        }
    }
}
