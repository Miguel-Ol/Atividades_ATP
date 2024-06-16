using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer7
{
    internal class atividade7
    {
        static void Main(string[] args)
        {
            double sal;
            string soun;
            do
            {
                Console.WriteLine("\ninforme o sálario:");
                sal = double.Parse(Console.ReadLine());

                if (sal <= 1412)
                    sal = sal * 0.075;
                else if (sal <= 2666.68)
                    sal = (1412 * 0.075) + ((sal - 1412.01) * 0.09);
                else if (sal <= 4000.03)
                    sal = (1412 * 0.075) + ((2666.68 - 1412.01) * 0.09) + ((sal - 2666.69) * 0.12);
                else if (sal <= 7786.02)
                    sal = (1412 * 0.075) + ((2666.68 - 1412.01) * 0.09) + ((4000.03 - 2666.69) * 0.12) + ((sal - 4000.04) * 0.14);
                else
                    sal = (1412 * 0.075) + ((2666.68 - 1412.01) * 0.09) + ((4000.03 - 2666.69) * 0.12) + ((7786.02 - 4000.04) * 0.14);
                Console.WriteLine($"o valor do desconto do INSS desse funcionário é: R${(sal).ToString("N2")}");
                do
                {
                    Console.WriteLine("deseja continuar? S: sim N: não");
                    soun = Console.ReadLine();
                }
                while (soun != "N" && soun != "S");
            }
            while (soun != "N");
            Console.WriteLine("programa encerrado.");
            Console.ReadLine();
        }
    }
}
