using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer9
{
    internal class Atividade9
    {
        static void ObterMaiorMenor(float[] vet, out float menor, out float maior)
        {
            menor = float.MaxValue;
            maior = float.MinValue;
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                }
                if (vet[i] < menor)
                {
                    menor = vet[i];
                }
                  
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            float men,mai;
            int w;
            Console.WriteLine("informe o valor do vetor");
            w= int.Parse(Console.ReadLine());
            float[] vet = new float[w];
            for(int i = 0;i < vet.Length;i++)
            {
                vet[i] = rnd.Next(1,100);
                Console.WriteLine(vet[i]);
            }
            ObterMaiorMenor(vet,out men,out mai);
            Console.WriteLine($"o maior número é:{mai} e o menor é {men}");
            Console.ReadLine();
        }
    }
}
