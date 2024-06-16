using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício5
{
    internal class exercício6
    {
        static void Main(string[] args)
        {
            float w, x, y, z;
            double result;
            Console.WriteLine("informe o valor de w");
            w = float.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor de x");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor de y");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor de z");
            z = float.Parse(Console.ReadLine());
            if (w == 1)
            {
                result = Math.Sqrt(x * y * z);
                Console.WriteLine($"o resultado é: {result}");
            }
            else if (w == 2)
            {
                result =(x + 2 * y + 3 * z)/6;
                Console.WriteLine($"o resultado é: {result}");
            }
            else if (w == 3)
            {
                result = 1/((1/x) + (1/y) + (1/z));
                Console.WriteLine($"o resultado é: {result}");
            }
            else if (w == 4)
            {
                result = (x + y + z) / 3;
                Console.WriteLine($"o resultado é: {result}");
            }
            else Console.WriteLine("valor de w é invalido");

            Console.ReadLine();
        }
    }
}
