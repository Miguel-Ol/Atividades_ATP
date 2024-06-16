using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade5
{
    internal class atividade5
    {
        static void Main(string[] args)
        {
            Console.Write("indique o valor da varA:");
            double varA = double.Parse(Console.ReadLine());
            Console.Write("indique o valor da varB:");
            double varB = double.Parse(Console.ReadLine());
            double var1 = varA;
            varA = varB;
            varB = var1;
            Console.WriteLine($"o valor da varA é:{varA}");
            Console.WriteLine($"o valor da varB é:{varB}");
            Console.ReadLine();
        }
    }
}
