using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer8
{
    internal class atividade8
    {
        static void Main(string[] args)
        {
            double num,sub=1,cont=0;
            Console.WriteLine("informe o número para a raiz quadrada");
            num = double.Parse(Console.ReadLine());
            do
            {
                num -= sub;
                sub += 2;
                cont++;
            }
            while (num > 0);
            Console.WriteLine($"o resultado é: {cont}");
            Console.ReadLine();
        }
    }
}
