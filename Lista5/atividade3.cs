using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer3
{
    internal class atividade3
    {
        static void Main(string[] args)
        {
            int w = 200, menu, cont=0;
            double[] nota = new double[w], pos = new double[w];
            double men=double.MaxValue, mai=double.MinValue, med=0, pesq;
            for (int i = 0; i<nota.Length; i++)
            {
                pos[i] = i;
                Console.WriteLine($"informe a nota {i}:");
                nota[i] = int.Parse(Console.ReadLine());
                if (nota[i] < men)
                    men = nota[i];
                if (nota[i] > mai)
                    mai = nota[i];
                med += nota[i];
            }
            med /= w;
            for (int i = 0; i < nota.Length; i++)
            {
                if (nota[i] > med)
                    cont++;
            }
            do
            {
                do
                {
                    Console.WriteLine("\r\nOpções \r\n1. Mostrar menor nota\r\n2. Mostrar maior nota\r\n3. Pesquisar nota\r\n4. Mostrar média das notas e quantidade de notas acima da média\r\n5. Sair");
                    menu = int.Parse(Console.ReadLine());
                }
                while (menu != 1 && menu != 2 && menu != 3 && menu != 4 && menu != 5);
                switch (menu)
                {
                    case 1:
                        Console.WriteLine($"a menor nota é: {men}");
                        break;
                    case 2:
                        Console.WriteLine($"a maior nota é: {mai}");
                        break;
                    case 3:
                        Console.WriteLine("informe a nota que deseja pesquisar:");
                        pesq = int.Parse(Console.ReadLine());
                        Console.Write($"a nota {pesq} consta nas posições: ");
                        for (int i = 0; i < nota.Length; i++)
                        {
                            if (nota[i] == pesq)
                                Console.Write($"{pos[i]}, ");
                        }
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.Write($"a média é {med} e a quantidade de notas maiores que ela é {cont}");
                        break;
                    case 5:
                        Console.WriteLine("programa encerrado");
                        break;
                }
            }
            while(menu != 5);

            Console.ReadLine();
        }
    }
}
