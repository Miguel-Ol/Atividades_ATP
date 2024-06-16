using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1
{
    class atividade1
    {
        static void Main(string[] args)
        {
            double perim, area, diag, lado;
            Console.Write("diga o valor do lado:");
            lado = double.Parse(Console.ReadLine());
            perim = 4 * lado;
            area = Math.Pow(lado, 2);
            diag = lado * Math.Sqrt(2);
            Console.WriteLine($"o perímetro é:{perim}");
            Console.WriteLine($"a área é:{area}");
            Console.WriteLine($"a diagonal é:{diag}");
            Console.ReadLine();
        }
    }
}
