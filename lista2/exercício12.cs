using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício12
{
    internal class exercício12
    {
        static void Main(string[] args)
        {
            double h, result;
            Console.WriteLine("informe sua altura");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("informe o seu sexo com F ou M");
            char gen = char.Parse(Console.ReadLine());
            result = (gen == 'M') ? 72.7 * h - 58: (62.1 * h)-44.7;
            Console.WriteLine($"seu peso ideal seria {result}");


        }
    }
}
