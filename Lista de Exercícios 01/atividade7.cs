using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade7
{
    internal class atividade7
    {
        static void Main(string[] args)
        {
            Console.Write("informe o valor gasto: ");
            Double valorGast = Double.Parse(Console.ReadLine());
            Console.Write("informe a porcentagem de gorjeta que deseja pagar: ");
            Double gorjePorc = Double.Parse(Console.ReadLine());
            Double gorjVal = (valorGast * gorjePorc) / 100;
            Double total = gorjVal + valorGast;
            Console.WriteLine($"o valor total a ser pago é: {total}");
            Console.ReadLine();
        }
    }
}
