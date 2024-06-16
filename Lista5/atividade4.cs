using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer4
{
    internal class atividade4
    {
        static void Main(string[] args)
        {
            int w = 100,esc, maivv=int.MinValue, menvv=int.MaxValue,maivc=-1, menvc=-1;
            string menvn="empate";
            string[] candn = {"Perna lona", "Pluto", "Mickey", "Bob Esponja", "Cebolinha"};
            int[] candv = new int[6];
            Console.WriteLine("tabela de voto:\r\n0. Perna Longa\r\n1. Pluto\r\n2. Mickey\r\n3. Bob Esponja\r\n4. Cebolinha\r\n");

            for (int i = 0; i < w; i++) 
            {
                Console.WriteLine("informe o código do voto:");
                esc = int.Parse(Console.ReadLine());
                switch (esc) 
                {
                        case 0:
                        candv[0]++; break;
                        case 1:
                        candv[1]++; break;
                        case 2:
                        candv[2]++; break;
                        case 3:
                        candv[3]++; break;
                        case 4:
                        candv[4]++; break;
                        default:
                        candv[5]++; break;
                }
            }

            for (int i = 0; i < candv.Length-1; i++)
            {
                    if (candv[i] > maivv)
                    {
                    maivv = candv[i];
                    maivc = i;
                    }
                
            }
            for (int i = 0; i < candv.Length-1; i++)
            {
                if (candv[i] < menvv)
                {
                    menvv = candv[i];
                    menvn = candn[i];
                    menvc = i;
                }

            }

            Console.WriteLine($"com {candv[maivc]} votos, o código do candidato mais votado é: {maivc}");
            Console.WriteLine($"com {candv[menvc]} votos, o candidato menos votado é: {menvn}");
            Console.WriteLine($"a quantidade de votos nulos é: {candv[5]}");

            Console.ReadLine();
        }
    }
}
