using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3
{
    internal class atividade1
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("informe o valor de x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor de y:");
            y = int.Parse(Console.ReadLine());

            if ((x % 2 == 0 || y % 2 == 0)||(x>y))
                Console.WriteLine("Erro! Valores Inválidos.");
            else
            {
                Console.Write($"os valores de {x} até {y} são: ");
                while (x < y)
                {
                    Console.Write($"{x}, ");
                    x += 2;
                }
                Console.WriteLine($"{y}.");
            }
            Console.ReadLine();
        }
    }
}
