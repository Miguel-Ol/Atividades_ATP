using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade4
{
    internal class atividade4
    {
        static void Main(string[] args)
        {
            int eleit;
            double branc, nulo, valid;
            Console.Write("informe a quantidade de eleitores:");
            eleit = int.Parse(Console.ReadLine());
            Console.Write("informe a quantidade de votos em branco:");
            branc = double.Parse(Console.ReadLine());
            Console.Write("informe a quantidade de votos nulos:");
            nulo = double.Parse(Console.ReadLine());
            valid = eleit - branc - nulo;
            double branPorc = (100 * branc) / eleit;
            double nuloPorc = (100 * nulo) / eleit;
            double validPorc = (100 * valid) / eleit;
            Console.WriteLine($"a porcentagem de votos em branco são: {branPorc}%");
            Console.WriteLine($"a porcentagem de votos nulos são {nuloPorc}%");
            Console.WriteLine($"a porcentagem de votos validos são {validPorc}%");
            Console.ReadLine();
        }
    }
}
