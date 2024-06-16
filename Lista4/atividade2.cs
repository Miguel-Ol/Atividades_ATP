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
            double S=1,Sv=1;
            Console.WriteLine("informe o valor de n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Sv = 1;
                for (int j = 1; j <= i; j++)
                {
                    Sv = Sv * j;
                }
                S = S + 1 / Sv;
            }
            Console.WriteLine($"o resultado é: {S}");
            Console.ReadLine();
        }
    }
}
