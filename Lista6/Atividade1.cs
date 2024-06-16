using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6
{
    internal class Atividade1
    {
        static void Main(string[] args)
        {
            int n;
            double soma=0;
            Random r = new Random();
            byte esc;
            Console.WriteLine("informe o valor de n:");
            n = int.Parse(Console.ReadLine());
            double[,] mat = new double[n, n];
            do
            {
                Console.WriteLine("deseja preencher a matriz de forma manual ou automática?\n1 para manual\n2 para automática");
                esc = byte.Parse(Console.ReadLine());
            }
            while (esc != 1 && esc!=2);
            switch (esc)
            {
                case 1:
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.WriteLine($"informe o valor da linha: {i} e coluna: {j}");
                            mat[i, j] = double.Parse(Console.ReadLine());
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            mat[i,j] =r.Next(1,100);
                            Console.WriteLine($"o valor da linha: {i} e coluna: {j} é: {mat[i, j]}");
                        }
                    }
                    break;
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    soma += mat[i, j];
                }
                Console.WriteLine($"a soma da linha {i} é: {soma}");
                soma = 0;
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    soma += mat[j, i];
                }
                Console.WriteLine($"a soma da coluna {i} é: {soma}");
                soma = 0;
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                soma += mat[i, i];
            }
            Console.WriteLine($"a soma da diagonal princial é: {soma}");
            soma = 0;
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                soma += mat[i, (n-1)-i];
            }
            Console.WriteLine($"a soma da diagonal secundária é: {soma}");

            Console.ReadLine();
        }
    }
}
