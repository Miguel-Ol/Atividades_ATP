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
            bool vf = true;
            int w = 4,lin=1;
            int[,] mat = new int[w,w];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.WriteLine($"informe o valor da linha: {i} e coluna: {j}");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0;i < (mat.GetLength(0)/2)+1; i++)
            {
                for (int j = 0; j < lin; j++)
                {
                    Console.WriteLine(mat[lin, j]);
                    if (mat[lin, j] != 0)
                        vf = false;
                }
                lin++;
            }
            if (vf == true)
                Console.WriteLine("é uma matriz triangular superior");
            else Console.WriteLine("não é uma matriz triangular superior");

            Console.ReadLine();
        }
    }
}
