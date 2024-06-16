using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício11
{
    internal class exercício11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe a letra:");
            char letra = char.Parse(Console.ReadLine());
            switch (letra)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("a letra é uma vogal");
                    break;
                default:
                    Console.WriteLine("a letra é uma consoante");
                    break;

            }


        }
    }
}
