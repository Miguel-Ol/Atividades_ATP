using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe um ano");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine((ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0)) ? "é um ano bissexto" : "não é um ano bissexto");
        }
    }
}
