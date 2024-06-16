using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade4
{
    internal class atividade4
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("informe o valor de x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor de y: ");
            y = int.Parse(Console.ReadLine());
            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                    Console.WriteLine($"{x}, {y}: 1ºquadrante");
                else if (x < 0 && y > 0)
                    Console.WriteLine($"{x}, {y}: 2ºquadrante");
                else if (x < 0 && y < 0)
                    Console.WriteLine($"{x}, {y}: 3ºquadrante");
                else if (x > 0 && y < 0)
                    Console.WriteLine($"{x}, {y}: 4ºquadrante");
                else
                    Console.WriteLine("quadrante não definido");
                Console.WriteLine("\ninforme o valor de x: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("informe o valor de y: ");
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("programa encerrado.");
            Console.ReadLine();
        }
    }
}
