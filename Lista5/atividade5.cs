using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer5
{
    internal class atividade5
    {
        static void Main(string[] args)
        {
            double[] nota = new double[60];
            double media = 0;
            int i = 0;
            do
            {
                Console.WriteLine($"informe a nota do {i+1}º aluno");
                nota[i] = double.Parse(Console.ReadLine());
                if (nota[i] >= 0)
                    media += nota[i];
                i++;
            }
            while (nota[i-1] >= 0 && i < nota.Length);

            if (nota[i-1] < 0)
                i--;
            media /= i;

            Console.WriteLine("\na nota de todos os alunos é:");
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"aluno {j+1}: {nota[j]}");
            }
            Console.WriteLine($"\ncom a media de {Math.Round(media)} as notas acima da média são:");
            for (int j = 0; j < i; j++)
            {
                if (nota[j] > media)
                Console.WriteLine($"aluno {j + 1}: {nota[j]}");
            }

            Console.ReadLine();
        }
    }
}
