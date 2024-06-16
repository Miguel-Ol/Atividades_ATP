using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade6
{
    internal class atividade6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o numerador:");
            Double numer = Double.Parse(Console.ReadLine());
            Console.WriteLine("informe o denominador:");
            Double deno = Double.Parse(Console.ReadLine());
            double result = numer / deno;
            Console.WriteLine($"o resultado da fração {numer}/{deno} é:{result.ToString("N2")}");
            Console.ReadLine();
        }
    }
}
