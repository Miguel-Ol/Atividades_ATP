using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer7
{
    internal class Atividade7
    {
        static double FracAdd(int x)
        {
            double y = 0;
            for (int i = 1; i < x+1; i++)
            {
                y += 1.0 / i;
            }
            return y;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("informe o valor de n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"o resultado é: {FracAdd(n)}");
            Console.ReadLine();

        }
    }
}
