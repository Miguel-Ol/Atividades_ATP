using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8
{
    internal class Atividade1
    {
        static void Main(string[] args)
        {
            string str;
            char ch;
            int quant=0;
            Console.WriteLine("informe a string: ");
            str = Console.ReadLine();
            Console.WriteLine("informe o caractere: ");
            ch = char.Parse(Console.ReadLine());
            foreach(char c in str)
            {
                if (c == ch)
                {
                    quant++;
                } 
            }
            Console.WriteLine($"a quantidade de vezes em que {ch} aparece em {str} é: {quant}");
        }
    }
}
