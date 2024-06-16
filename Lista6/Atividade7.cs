using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer7
{
    internal class Atividade7
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[10, 4];
            double mai = 0, maic=0, med=0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine($"informe o número da matrícula do {i + 1}º aluno");
                        mat[i, j] = double.Parse(Console.ReadLine());
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine($"informe a média das provas do {i + 1}º aluno");
                        mat[i, j] = double.Parse(Console.ReadLine());
                    }
                    else if (j == 2)
                    {
                        Console.WriteLine($"informe a média dos trabalhos do {i + 1}º aluno");
                        mat[i, j] = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }
                }
            }
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                mat[i,3]= mat[i, 1] + mat[i, 2];
                med += mat[i, 3];
                if (mat[i, 3] > mai)
                {
                    mai= mat[i, 3];
                    maic = mat[i, 0];
                }
            }
            Console.WriteLine($"o aluno com maior média foi {maic}\n");
            Console.WriteLine($"a média das notas finais foi {med/ mat.GetLength(0)}");
            Console.ReadLine();
        }
    }
}
