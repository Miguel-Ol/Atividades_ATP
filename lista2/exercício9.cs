using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício9
{
    internal class exercício9
    {
        static void Main(string[] args)
        {
            Console.Write("informe um valor de 0 a 4: ");
            byte num = byte.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                    case 1:
                    Console.WriteLine("Um");
                    break;
                    case 2:
                    Console.WriteLine("Dois");
                    break;
                    case 3:
                    Console.WriteLine("Três");
                    break;
                    case 4:
                    Console.WriteLine("Quatro");
                    break;
                    default:
                    Console.WriteLine("Valor inválido");
                    break;
            }
            Console.ReadLine();
        }
    }
}