using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer5
{
    internal class Atividade5
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            bool vf=true;
            int w = 500,diagp=0,diags=0;
            byte esc;
            int[,] mat = new int[w,w];
            int[] lin = new int[w];
            int[] col = new int[w];

            do
            {
                Console.WriteLine("deseja preencher a matriz de forma manual ou automática?\n1 para manual\n2 para automática");
                esc = byte.Parse(Console.ReadLine());
            }
            while (esc != 1 && esc != 2);
            switch (esc)
            {
                case 1:
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            Console.WriteLine($"informe o valor da linha: {i} e coluna: {j}");
                            mat[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            mat[i, j] = r.Next(10, 100);
                            Console.WriteLine($"o valor da linha: {i} e coluna: {j} é: {mat[i, j]}");
                        }
                    }
                    break;
            }
            Console.WriteLine();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    lin[i] += mat[i, j];
                }
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    col[i] += mat[j,i];
                }
            }
            for (int i = 0; i < w; i++)
            {
                diagp += mat[i, i];
            }

            for (int i = 0; i < w; i++)
            {
                diags += mat[i, (w - 1) - i];
            }

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++) 
                {

                        if ( (lin[i] != col[j]) || (lin[j] != col[i]) || (lin[i]!=diagp)||(col[i] != diagp) || (lin[i] != diags) || (col[i] != diags))
                            vf = false; 
                }
            }
            if (vf == false)
                Console.WriteLine("não é um quadrado mágico");
            else Console.WriteLine("é um quadrado mágico");

            Console.ReadLine();
        }
    }
}
