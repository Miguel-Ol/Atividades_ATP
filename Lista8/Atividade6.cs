using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer6
{
    internal class Atividade6
    {
        static void Main(string[] args)
        {
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
            bool veri;
            string str;
            Console.WriteLine("informe a string:");
            str = Console.ReadLine();
            foreach (char c in str)
            {
                veri = true;
                for (int i = 0; i < vogais.Length; i++)
                {
                    if (c == vogais[i] && veri)
                        veri = false;
                }
                if (veri)
                    Console.Write(c);
                else
                    Console.Write('*');
            }
            Console.ReadLine();
        }
    }
}
