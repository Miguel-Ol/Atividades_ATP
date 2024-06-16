using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer8
{
    internal class Atividade8
    {
        static void Main(string[] args)
        {
            char[,] jogo = new char[3, 3];

            for (int i = 0; i < jogo.GetLength(0); i++)
            {
                for (int j = 0; j < jogo.GetLength(1); j++)
                {
                    jogo[i, j] = '-';
                }
            }
            byte contr = 1,lin,col,venc=0;
            bool jog;
            do
            {
                if (contr <= 9 && venc == 0)
                {
                    do {
                        Console.Write($"jogador 1 informe a linha da {contr}º jogada: ");
                        lin = byte.Parse(Console.ReadLine());
                        Console.Write($"jogador 1 informe a coluna da {contr}º jogada: ");
                        col = byte.Parse(Console.ReadLine());
                        if (jogo[lin - 1, col - 1] != 'X' && jogo[lin - 1, col - 1] != 'O')
                        {
                            jogo[lin - 1, col - 1] = 'X';
                            jog = true;
                        }
                        else
                        {
                            Console.WriteLine("jogada inválida\n");
                            jog = false;
                        }
                    }
                    while (jog==false);

                    for (int i = 0; i < jogo.GetLength(0); i++)
                    {
                        for (int j = 0; j < jogo.GetLength(1); j++)
                        {
                            Console.Write(jogo[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    for (int i = 0; i < jogo.GetLength(0); i++) {
                        if ((jogo[0, i] == 'X' && jogo[1, i] == 'X' && jogo[2, i] == 'X') || (jogo[i, 0] == 'X' && jogo[i, 1] == 'X' && jogo[i, 2] == 'X') || (jogo[0, 0] == 'X' && jogo[1, 1] == 'X' && jogo[2, 2] == 'X') || (jogo[0, 2] == 'X' && jogo[1, 1] == 'X' && jogo[2, 0] =='X'))
                        {
                            venc = 1;
                        }                   
                    }
                }
                contr++;

                if (contr <= 9 && venc == 0)
                {
                    do
                    {
                        Console.Write($"jogador 2 informe a linha da {contr}º jogada: ");
                        lin = byte.Parse(Console.ReadLine());
                        Console.Write($"jogador 2 informe a coluna da {contr}º jogada: ");
                        col = byte.Parse(Console.ReadLine());
                        if (jogo[lin - 1, col - 1] != 'X' && jogo[lin - 1, col - 1] != 'O')
                        {
                            jogo[lin - 1, col - 1] = 'O';
                            jog = true;
                        }
                        else
                        {
                            Console.WriteLine("jogada inválida\n");
                            jog = false;
                        }
                    }
                    while (jog == false);

                    for (int i = 0; i < jogo.GetLength(0); i++)
                    {
                        for (int j = 0; j < jogo.GetLength(1); j++)
                        {
                            Console.Write(jogo[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    for (int i = 0; i < jogo.GetLength(0); i++)
                    {
                        if ((jogo[0, i] == 'O' && jogo[1, i] == 'O' && jogo[2, i] == 'O') || (jogo[i, 0] == 'O' && jogo[i, 1] == 'O' && jogo[i, 2] == 'O') || (jogo[0, 0] == 'O' && jogo[1, 1] == 'O' && jogo[2, 2] == 'O') || (jogo[0, 2] == 'O' && jogo[1, 1] == 'O' && jogo[2, 0] == 'O'))
                        {
                            venc = 2;
                        }
                    }
                }

                contr ++;
            }
            while (contr <= 9 && venc==0);

            if (venc != 0)
                Console.WriteLine($"\no vencedor é o jogador {venc}");
            else
                Console.WriteLine("houve um empate");

            Console.ReadLine();
        }
    }
}
