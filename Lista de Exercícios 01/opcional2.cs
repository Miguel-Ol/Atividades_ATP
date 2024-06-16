using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opcional2
{
    internal class opcional2
    {
        static void Main(string[] args)
        {
            Console.Write("informe o valor do sálario mínimo:");
            double s = double.Parse(Console.ReadLine());
            Console.Write("informe a quantidade de kilowatt gasto:");
            double k = double.Parse(Console.ReadLine());
            double custPK = s / (10*100);
            double valorT = custPK * k;
            Console.WriteLine($"o valor em reais de cada kilowatt é: {custPK} R$");
            Console.WriteLine($"o valor em reais a ser pago é {valorT} R$");
            Console.ReadLine();
        }
    }
}
