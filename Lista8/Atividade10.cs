using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer10
{
    internal class Atividade10
    {
        static void Main(string[] args)
        {
            int cont=0;
            Console.WriteLine("informe a frase A");
            string frase = Console.ReadLine().ToLower();
            Console.WriteLine("informe a string B com dois caracteres");
            string carc = Console.ReadLine().ToLower();
            for (int i = 0; i < frase.Length-1; i++) 
            {
                if (frase[i] == carc[0] && frase[i + 1] == carc[1])
                    cont++;
            }
            Console.WriteLine(cont);

        }
    }
}
