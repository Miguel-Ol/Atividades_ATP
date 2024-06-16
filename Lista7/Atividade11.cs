using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer11
{

    internal class Atividade11
    {
        static void ConvertSegs(int totSegs, out int hora, out int min, out int seg)
    {
        hora = min = seg = 0;
        while (totSegs >= 59)
        {

            if (totSegs - 60 >= 0)
            {
                totSegs = totSegs - 60;
                min++;
            }
            if (min == 60)
            {
                min = 0;
                hora++;
            }
        }
        seg = totSegs;
    }

        static void Main(string[] args)
        {
            int h, m, s, st;
            Console.WriteLine("informe o valor em segundos");
            st = int.Parse(Console.ReadLine());
            ConvertSegs(st, out h, out m, out s);
            Console.WriteLine($"o valor convertido é {h}:{m}:{s}");
        }
    }
}
