using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;
            Console.WriteLine("informe o dia atual:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o mes atual:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o ano atual:");
            ano = int.Parse(Console.ReadLine());
            Data hoje = new Data(dia, mes, ano);
            Console.WriteLine(hoje);
            Console.ReadLine();
        }
    }
}
