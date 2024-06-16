using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer2
{
    internal class atividade2
    {
        static void Main(string[] args)
        {
            int quant;
            bool vf = true;
            Console.WriteLine("informe o a quantidade de dígitos do número: ");
            quant = int.Parse(Console.ReadLine());
            int[] tot = new int[quant];
            for (int i = 0; i < quant; i++) 
            {
                Console.WriteLine($"informe o {i+1}º dígito");
                tot[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i<quant; i++)
            {
                if (vf == true)
                {
                    if (tot[0 + i] == tot[quant - (i + 1)])
                    {
                        vf = true;
                    }
                    else vf = false;
                }
            }
            if (vf == true)
                Console.WriteLine("\né um palíndromo");
            else Console.WriteLine("\nnão é um palíndromo");

            Console.ReadLine();
        }
    }
}
