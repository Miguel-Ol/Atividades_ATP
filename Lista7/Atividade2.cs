using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
    internal class Atividade2
    {
        static double Hipo(double a, double b)
        {
            double r;
            r = Math.Sqrt(a * a + b * b);
            return r;
        }
        static void Main(string[] args)
        {
            double l1, l2;
            Random r = new Random();
            l1 = r.Next(1,100);
            Console.WriteLine(l1);
            l2 = r.Next(1,100);
            Console.WriteLine(l2);
            Console.WriteLine("o valor da hipotenusa desses números é:" + Hipo(l1,l2));
            Console.ReadLine();
        }
    }
}
