using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    internal class atividade1
    {
        static void Main(string[] args)
        {
            double va, vt, mq,soma;
            for (int i = 0; i<25;i++) 
            {
                Console.WriteLine("informe o valor do vale-alimentação:");
                va= double.Parse(Console.ReadLine());
                Console.WriteLine("informe o valor do vale-transporte:");
                vt = double.Parse(Console.ReadLine());
                Console.WriteLine("informe o valor dos metros quadrados:");
                mq = double.Parse(Console.ReadLine());
                if (mq < 10)
                    mq = 10;
                else if (mq <= 20)
                    mq = 11.50;
                else mq = 13;
                soma = va+(vt*2)+mq;
                Console.WriteLine($"o valor total do funcionário é: R${(soma).ToString("N2")}\n");
            }
            Console.ReadLine();
        }
    }
}
