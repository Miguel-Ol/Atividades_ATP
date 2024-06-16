using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer8
{
    internal class Atividade8
    {
        static double SVal(int n)
        {
            double x,y,r;
            r = 0;
            x = 2;
            y = 4;
            for (int i = 2; i < n+2; i++) 
            {
                r += x / y;
                x=(i*i)+1;
                y++;
            }
            return r;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("informe o valor de n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"o resultado é: {SVal(n)}");
            Console.ReadLine();
        }
    }
}
