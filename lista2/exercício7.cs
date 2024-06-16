using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício7
{
    internal class exercício7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o número a ser dividido:");
            float num = float.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 5 == 0)
                Console.WriteLine($"o número {num} é divisível por 3 e 5");

            else if (num % 3 == 0)
                Console.WriteLine($"o número {num} é divisível apenas por 3");

            else if (num % 5 == 0)
                Console.WriteLine($"o número {num} é divisível apenas por 5");

            else
                Console.WriteLine($"o número {num} não é divisível por 3 e nem por 5");

            Console.ReadLine();

        }
    }
}
