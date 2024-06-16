using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercíxio10
{
    internal class exercício10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe qual opção do menu deseja:\r\n1. Converter de centímetros para metros\r\n2. Converter de metros para centímetros\r\n3. Converter de milímetros para metros\r\n4. Converter de metros para milímetros");
            byte op = byte.Parse (Console.ReadLine());
            Console.Write("informe o valor do número: ");
            double num = double.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine($"o resultado é {num/100}m");
                    break;
                case 2:
                    Console.WriteLine($"o resultado é {num*100}cm");
                    break;
                case 3:
                    Console.WriteLine($"o resultado é {num/1000}m");
                    break;
                case 4:
                    Console.WriteLine($"o resultado é {num*1000}mm");
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
    }
}
