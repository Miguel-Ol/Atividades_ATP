using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade8
{
    internal class atividade8
    {
        static void Main(string[] args)
        {
            double fib1 = 0, fib2 = 1, fibt = 0, n, cont = 0;
            Console.WriteLine("informe um número que os elementos da sequência de Fibonacci deverão ser menores:");
            n = int.Parse(Console.ReadLine());
            while (cont != n)
            {
                if (cont == 0)
                    Console.WriteLine($"\n{fibt}");
                else if (cont % 2 == 0)
                {
                    fibt = fib1 + fib2;
                    if (fibt < n)
                    Console.WriteLine($"\n{fibt}");
                    fib1 = fibt;
                }
                else
                {
                    fibt = fib1 + fib2;
                    if (fibt < n)
                        Console.WriteLine($"\n{fibt}");
                    fib2 = fibt;
                }
                cont++;
            }
            Console.ReadLine();
        }
    }
}
