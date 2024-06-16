using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opcional1
{
    internal class opcional1
    {
        static void Main(string[] args)
        {
            Console.Write("informe o número de até 3 dígitos a ser invertido a ser invertido: ");
            int num = int.Parse(Console.ReadLine());
            int cent = num / 100;
            int dez = (num % 100) / 10;
            int uni = (num % 100) % 10;
            double inv = (uni * 100) + (dez * 10) + cent;
            Console.WriteLine($"o número informado invertido fica: {inv}");
            Console.ReadLine();
        }
    }
}
