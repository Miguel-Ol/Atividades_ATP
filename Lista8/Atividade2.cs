using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
    internal class Atividade2
    {
        static void Main(string[] args)
        {
            string str1, str2,strc;
            int tam1, tam2;
            Console.WriteLine("informe a primeira sting:");
            str1 = Console.ReadLine();
            Console.WriteLine("informe a segunda sting:");
            str2 = Console.ReadLine();
            if (str1.Equals(str2)) 
            {
                Console.WriteLine("strings iguais");
            }
            else
            {
                tam1 = str1.Length;
                tam2 = str2.Length;
                Console.Write("a maior string é: ");
                if (tam1 > tam2)                
                    Console.WriteLine(str1);                
                else
                    Console.WriteLine(str2);
                strc = str1 + " " + str2;
                Console.WriteLine("strings concatenadas: " + strc);

            }

        }
    }
}
