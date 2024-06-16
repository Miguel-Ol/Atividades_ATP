using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer12
{
    internal class Atividade12
    {
        static int Maifound(int[,] vet,out int lin,out int col)
        {
            int mai =  int.MinValue;
            lin = col = -1;
            for(int i=0;i<vet.GetLength(0);i++)
            {
                for (int j = 0; j < vet.GetLength(1); j++)
                {
                    if (vet[i,j] > mai)
                    {
                        mai = vet[i,j];
                        lin = i;
                        col = j;
                    }
                }
            }
            return mai;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("informe quantas linhas a matriz terá:");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("informe quantas colunas a matriz terá:");
            int c = int.Parse(Console.ReadLine());

            Random r = new Random();
            int k, col, lin;
            int[,] vet = new int[l,c];
            for (int i = 0; i < vet.GetLength(0); i++)
            {
                for (int j = 0; j < vet.GetLength(1); j++)
                {
                    vet[i,j] = r.Next(10,100);
                    Console.Write(vet[i,j] + " ");
                }
                Console.WriteLine();
            }
            k = Maifound(vet,out lin,out col);
            Console.WriteLine($"o maior valor da matriz é {k} que está na {lin+1}º linha e na {col+1}º coluna");   

        }
    }
}
