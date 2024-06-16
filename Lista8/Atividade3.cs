using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3
{
    internal class Atividade3
    {
        static void Main(string[] args)
        {
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
            string str;
            int vog=0,cons=0;
            bool veri;
            Console.WriteLine("informe a string");
            str = Console.ReadLine().ToLower();
            foreach (char c in str)
            {
                veri = true;
                for (int i = 0; i < vogais.Length; i++)
                {
                    if (c == vogais[i]&& veri)
                        veri = false;
                }
                if (veri)
                    cons++;
                else
                    vog++;
            }
            Console.WriteLine($"a quantidade de vogais é {vog} e a de consoantes é {cons}");
        }
    }
}
