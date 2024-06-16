using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer6
{
    internal class atividade6
    {
        static void Main(string[] args)
        {
            int w = 10;
            double[] VetA = new double[w];
            double[] VetB = new double[w];
            char[] VetC = new char[w];
            double[] VetD = new double[w];

            for (int i = 0; i < w; i++) 
            {
                Console.WriteLine($"informe o º{i + 1} número do VatA: ");
                VetA[i] = double.Parse( Console.ReadLine() );
                Console.WriteLine($"informe o º{i + 1} número do VatB: ");
                VetB[i] = double.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine($"informe a operação matemática (+, -, *, /) do º{i + 1} cálculo: ");
                    VetC[i] = char.Parse(Console.ReadLine());
                    switch (VetC[i])
                    {
                        case '+':
                            VetD[i] = VetA[i] + VetB[i];
                            break;
                        case '-':
                            VetD[i] = VetA[i] - VetB[i];
                            break;
                        case '*':
                            VetD[i] = VetA[i] * VetB[i];
                            break;
                        case '/':
                            VetD[i] = VetA[i] / VetB[i];
                            break;
                        default:
                            Console.WriteLine("caractere inválido");
                            break;
                    }
                }
                while (VetC[i] != '+' && VetC[i] != '-' && VetC[i] != '*' && VetC[i] != '/');
                Console.WriteLine();
            }
            for (int i = 0; i<w;i++)
            {
                Console.Write(VetA[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < w; i++)
            {
                Console.Write(VetB[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < w; i++)
            {
                Console.Write(VetC[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < w; i++)
            {
                Console.Write(VetD[i] + " ");
            }
        }
    }
}
