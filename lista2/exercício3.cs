using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício3
{
    internal class exercício3
    {
        static void Main(string[] args)
        {
            int id, temp;
            Console.WriteLine("informe sua idade:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("informe seu tipo de carteira:");
            char cart = char.Parse(Console.ReadLine());
            Console.WriteLine("informe por quantos anos você tem esta carteira:");
            temp = int.Parse(Console.ReadLine());

            if (id <= 21)
                Console.WriteLine("inválido por idade inferior á 21");

            else if (cart != 'B' && cart != 'C' && cart != 'b' && cart != 'c')
                Console.WriteLine("tipo de carteira inválida");

            else if ((cart == 'B' || cart == 'b') && temp < 2)
                Console.WriteLine("inválido por tempo insuficiente de carteira B");

            else if ((cart == 'C' || cart == 'c') && temp < 1)
                Console.WriteLine("inválido por tempo insuficiente de carteira C");
            else
                Console.WriteLine("válido para tirar a carteira tipo D");

            Console.ReadLine();
        }
    }
}
