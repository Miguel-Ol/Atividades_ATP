using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4
{
    internal class Atividade4
    {
        static void Media(int n1,  int n2, int n3, char esc) 
        {
            double result;
            switch (esc) 
            {                
                case ('A'):
                    result = (n1 + n2 + n3) / 3.0;
                    Console.WriteLine("a média aritmédica dos valores é: " + result);
                    break;
                case ('P'):
                    result = ((n1 * 5) + (n2 * 3) + (n3 * 2)) / (5 + 3 + 2.0);
                    Console.WriteLine("a média ponderada dos valores é: " + result);
                    break;
                default:
                    Console.WriteLine("opção inválida");
                    break;

            }
        }
        static void Main(string[] args)
        {
            char esc;
            int num1, num2, num3;
            Random r = new Random();
            num1 = r.Next(1, 100);
            Console.WriteLine(num1);
            num2 = r.Next(1, 100);
            Console.WriteLine(num2);
            num3 = r.Next(1, 100);
            Console.WriteLine(num3);
            Console.WriteLine("A: média aritmédica\nP: média ponderada");
            esc = char.Parse(Console.ReadLine());
            Media(num1,num2,num3,esc);
            Console.ReadLine();
        }
    }
}
