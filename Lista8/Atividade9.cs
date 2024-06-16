using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer9
{
    internal class Atividade9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o nome completo");
            string name = Console.ReadLine().ToLower();
            string[] nomes = name.Split(' ');
            Console.WriteLine("o email é: " +nomes[0] + '.' + nomes[nomes.Length-1]+ "@acme.br");
        }
    }
}
