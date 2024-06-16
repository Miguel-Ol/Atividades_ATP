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
            Random r = new Random();
            byte esc;
            int w = 10;
            double[,] mat = new double[w,w];
            do
            {
                Console.WriteLine("deseja preencher a matriz de forma manual ou automática?\n1 para manual\n2 para automática");
                esc = byte.Parse(Console.ReadLine());
            }
            while (esc != 1 && esc != 2);
            switch (esc)
            {
                case 1:
                    for (int i = 0; i < w; i++)
                    {
                        for (int j = 0; j < w; j++)
                        {
                            Console.WriteLine($"informe o valor da linha: {i} e coluna: {j}");
                            mat[i, j] = double.Parse(Console.ReadLine());
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < w; i++)
                    {
                        for (int j = 0; j < w; j++)
                        {
                            mat[i, j] = r.Next(10, 100);
                            Console.WriteLine($"o valor da linha: {i} e coluna: {j} é: {mat[i, j]}");
                        }
                    }
                    break;
            }

            Console.WriteLine();

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(mat[i, j]+ "  ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if(i==j)
                    mat[i, j] = Math.Sqrt(mat[i, j]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write((mat[i, j].ToString("F2")) + "  ");
                }
                Console.WriteLine();
            }





            Console.ReadLine();
        }
    }
}
