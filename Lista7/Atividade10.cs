using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer10
{
    internal class Atividade10
    {
        static int[] Inter(int[] atp, int[] diw,ref bool nul,out int cont)
        {
            int[] jun = new int[10];
            int w = 0;
            for (int i = 0; i < atp.Length; i++)
            {
                for(int j = 0; j < atp.Length; j++)
                {
                    if (atp[i] == diw[j])
                    {
                        jun[w] = diw[j];
                        w++;
                    }
                }
            }
            cont = w;
            if (w==0)
                nul= false;
            return jun;
        }
        static void Main(string[] args)
        {
            int cont;
            bool nulM = true;
            int[] ATP= new int[10],DIW= new int[ATP.Length];
            for (int i = 0;i < ATP.Length;i++) 
            {
                Console.WriteLine($"informe a matrícula{i + 1}º de ATP");
                ATP[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"informe a matrícula{i + 1}º de DIW");
                DIW[i] = int.Parse(Console.ReadLine());
            }
            int[] simul = Inter(ATP, DIW, ref nulM, out cont);
            if (nulM)
            {
                Console.WriteLine("os alunos que estão matrículados em ambas as matérias são:");
                for (int i = 0; i < cont; i++)
                {
                    Console.WriteLine(simul[i]);
                }
            }
            else Console.WriteLine("não houveram aluos matrículados em ambas as matérias.");
            
            Console.ReadLine();
        }
    }
}
