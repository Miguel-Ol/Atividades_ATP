using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício8
{
    internal class exercício8
    {
        static void Main(string[] args)
        {
            Console.Write("informe o número do dia da semana: ");
            byte dia = byte.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("domingo");
                    break;
                    case 2:
                    Console.WriteLine("segunda-feira");
                    break;
                    case 3:
                    Console.WriteLine("terça-feira");
                    break;
                    case 4:
                    Console.WriteLine("quarta-feira");
                    break;
                    case 5:
                    Console.WriteLine("quinta-feira");
                    break;
                    case 6:
                    Console.WriteLine("sexta-feira");
                    break;
                    case 7:
                    Console.WriteLine("sábado");
                    break;
                default:
                    Console.WriteLine("Dia inválido");
                    break;
            }
            Console.ReadLine();
            
        }
    }
}
