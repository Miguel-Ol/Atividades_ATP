using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer2
{
    internal class Atividade2
    {
        static void Main(string[] args)
        {
            bool vf=true;
            int lin, col, esc;
            Random r = new Random();
            Console.WriteLine("informe o tamanho da linha: ");
            lin = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o tamanho da coluna: ");
            col = int.Parse(Console.ReadLine());
            double[,] m1 = new double[lin, col];
            double[,] m2 = new double[lin, col];
            do
            {
                Console.WriteLine("deseja preencher a matriz de forma manual ou automática?\n1 para manual\n2 para automática");
                esc = byte.Parse(Console.ReadLine());
            }
            while (esc != 1 && esc != 2);
            switch (esc)
            {
                case 1:
                    Console.WriteLine("Matriz 1:");
                    for (int i = 0; i < lin; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.WriteLine($"informe o valor da linha: {i} e coluna: {j}");
                            m1[i, j] = double.Parse(Console.ReadLine());
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Matriz 2:");
                    for (int i = 0; i < lin; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.WriteLine($"informe o valor da linha: {i} e coluna: {j}");
                            m2[i, j] = double.Parse(Console.ReadLine());
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Matriz 1:");
                    for (int i = 0; i < lin; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            m1[i, j] = r.Next(1, 100);
                            Console.WriteLine($"o valor da linha: {i} e coluna: {j} é: {m1[i, j]}");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Matriz 2:");
                    for (int i = 0; i < lin; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            m2[i, j] = r.Next(1, 100);
                            Console.WriteLine($"o valor da linha: {i} e coluna: {j} é: {m2[i, j]}");
                        }
                    }
                    break;
            }
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                        if (m1[i, j] != m2[i,j])
                            vf = false;  
                }
            }
            Console.WriteLine();
            if (vf == true)
                Console.WriteLine("as matrizes são iguais");
            else Console.WriteLine("as matrizes são diferentes");
            Console.ReadLine();
        }
    }
}
