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
            double bas, altura, peri, area, diag;
            Console.Write("insira o valor da base:");
            bas = double.Parse(Console.ReadLine());
            Console.Write("insira o valor da altura:");
            altura = double.Parse(Console.ReadLine());
            peri = 2 * (bas + altura);
            area = bas* altura;
            diag = Math.Sqrt((Math.Pow(bas, 2))+(Math.Pow(altura, 2)));
            Console.WriteLine($"o valor do perimetro é: {peri}");
            Console.WriteLine($"o valor da área é: {area}");
            Console.WriteLine($"o valor da diagonal é: {diag}");
            Console.ReadLine();
        }
    }
}
