using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2
{
    internal class atividade2
    {
        static void Main(string[] args)
        {
            double indfc=1,indf,indfm=0,indfmd=0,indfmed=0;
            while (indfc < 32)
            {
                Console.WriteLine($"informe o índice pluviométrico do dia {indfc}:");
                indf = double.Parse(Console.ReadLine());
                indfmed += indf;
                if (indf > indfm)
                {
                    indfm = indf;
                    indfmd = indfc;
                }
                indfc++;
            }
            Console.WriteLine($"o índice pluviométrico médio é {indfmed/31.0}.");
            Console.WriteLine($"o índice pluviométrico máximo foi {indfm} e o dia que ele ocorreu é {indfmd}.");
            Console.ReadLine();
        }
    }
}
