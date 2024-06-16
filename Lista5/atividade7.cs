using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer7
{
    internal class atividade7
    {
        static void Main(string[] args)
        {
            byte w = 5;
            bool vf;
            int[] x = new int[w];
            int[] y = new int[w];
            for (int i = 0; i < w; i++)
            {
                Console.WriteLine($"informe o número {i} do vetor x");
                x[i] = int.Parse(Console.ReadLine());   
            }
            Console.WriteLine("");
            for (int i = 0; i < w; i++)
            {
                Console.WriteLine($"informe o número {i} do vetor y");
                y[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0;i < w; i++) 
            {
                Console.WriteLine($"\a soma da posição{i} é: {x[i] + y[i]}");
            }
            Console.WriteLine("");
            for(int i = 0; i < w; i++)
            {
                Console.WriteLine($"a multiplicação da posição{i} é: {x[i] * y[i]}");
            }

            Console.WriteLine();
            Console.Write($"os elementos de x que não aparecem em y são: ");

            for (int i = 0; i < w; i++)
            {
                vf = true;
                for (int j = 0; j < w; j++) 
                {
                    if (vf == true)
                    {
                        if (x[i] == y[j])
                            vf = false;
                    }
                }
                if (vf == true)
                    Console.Write($"{x[i]} ");
            }

            Console.WriteLine();

            Console.Write($"os elementos que aparecem em x e y são: ");
            for (int i = 0; i < w; i++)
            {
                vf = true;
                for (int j = 0; j < w; j++)
                {
                    if (vf == true)
                    {
                        if (x[i] == y[j])
                        {
                            Console.Write($"{x[i]} ");
                            vf = false;
                        }
                    }
                }
            }

            Console.WriteLine();

            Console.Write("a união entre os vetores x e y é: ");   

            for (int i = 0; i < w; i++)
            {
                    Console.Write($"{x[i]} ");
            }
            for (int i = 0; i < w; i++)
            {
                vf = true;
                for (int j = 0; j < w; j++)
                {
                    if (vf == true)
                    {
                        if (y[i] == x[j])
                            vf = false;
                    }
                }
                if (vf == true)
                    Console.Write($"{y[i]} ");
            }



            Console.ReadLine();
        }
    }
}
