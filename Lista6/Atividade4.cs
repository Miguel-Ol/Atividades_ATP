using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4
{
    internal class Atividade4
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            byte esc;
            int cont=0;
            double[,] mat = new double[3,6];
            double soma=0;
            do
            {
                Console.WriteLine("deseja preencher a matriz de forma manual ou automática?\n1 para manual\n2 para automática");
                esc = byte.Parse(Console.ReadLine());
            }
            while (esc != 1 && esc != 2);
            switch (esc)
            {
                case 1:
                    for (int i = 0/*,t=1*/; i < mat.GetLength(0); i++)
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            Console.WriteLine($"informe o valor da linha: {i} e coluna: {j}");
                            mat[i, j] = double.Parse(Console.ReadLine());
                            /*mat[i, j] = t;
                            t++;*/
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
            Console.WriteLine("a matriz é:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < mat.GetLength(1); i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    if ((i+1) % 2 != 0)
                    {
                        soma += mat[j, i];
                    }
                }
            }
            Console.WriteLine($"a soma das colunas ímpares é: {soma}");
            soma = 0;

            Console.WriteLine();

            for (int i = 0; i < mat.GetLength(1); i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    if ((i + 1) == 2 || (i + 1) == 4)
                    {
                        soma += mat[j, i];
                        cont++;
                    }
                }
            }
            Console.WriteLine($"a média aritmética da segunda e quarta coluna é: {soma/cont}");

            Console.WriteLine();

            for (int i = 0; i < mat.GetLength(1); i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    if ((i + 1) == 1)
                    {
                        mat[j, 5] = mat[j, 0] + mat[j, 1];
                    }
                }
            }

            Console.WriteLine("a matriz modificada é:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }






            Console.ReadLine();
        }
    }
}
