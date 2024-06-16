using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer4
{
    internal class atividade4
    {
        static void Main(string[] args)
        {
            double temp, mait=double.MinValue, ment=double.MaxValue,diaq=1,diaf=1;
            for (int i = 1; i<=4;i++)
            {
                Console.WriteLine($"informe o valor da temperatura no dia {i}/4:");
                temp = double.Parse(Console.ReadLine());
                if (temp > mait)
                {
                    mait = temp;
                    diaq = i;
                }
                if (temp < ment)
                {
                    ment = temp;
                    diaf = i;
                }
            }
            Console.WriteLine($"\na maior temperatura foi: {mait}º no dia {diaq}/4");
            Console.WriteLine($"a menor temperatura foi: {ment}º no dia {diaf}/4");
            Console.ReadLine();
        }
    }
}
