using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class exercício4
    {
        static void Main(string[] args)
        {
            float num1, num2;
            Console.WriteLine("1. Somar dois números.\r\n2. Subtrair dois números.\r\n3. Multiplicação de dois números.\r\n4. Divisão de dois números.\r\ninforme qual opção do menu deseja:");
            byte menu = byte.Parse(Console.ReadLine());

            if (menu == 1)
            {
                Console.WriteLine("informe o primeiro número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe o segundo número");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"o resultado é: {num1 + num2}");
            }

            else if (menu == 2)
            {
                Console.WriteLine("informe o primeiro número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe o segundo número");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"o resultado é: {num1 - num2}");
            }

            else if (menu == 3)
            {
                Console.WriteLine("informe o primeiro número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe o segundo número");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"o resultado é:  {num1 * num2}");
            }

            else if (menu == 4)
            {
                Console.WriteLine("informe o primeiro número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe o segundo número");
                num2 = int.Parse(Console.ReadLine());

                if (num2 == 0)
                {
                    Console.WriteLine("Erro");
                }
                Console.WriteLine($"o resultado é: {num1 / num2}");
            }

            else
            {
                Console.WriteLine("valor de menu inválido");
            }

            Console.ReadLine();
        }
    }
}
