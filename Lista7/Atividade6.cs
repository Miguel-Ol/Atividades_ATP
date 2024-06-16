using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer6
{
    internal class Atividade6
    {
        static void MultEsc(int[,] mat,int n)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] *= n;
                }
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int l,c,n;
            n = r.Next(1,100);
            Console.WriteLine("informe a quantidade de linhas da matriz");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("informe a quantidade de colunas da matriz");
            c = int.Parse(Console.ReadLine());
            int[,] matm = new int[l,c];

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matm[i, j] = r.Next(1,100);
                    Console.WriteLine(matm[i, j]);
                }
            }
            Console.WriteLine($"n é igual á {n}");
            MultEsc(matm,n);
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine(matm[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
