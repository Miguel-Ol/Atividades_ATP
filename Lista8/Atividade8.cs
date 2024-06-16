using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer8
{
    internal class Atividade8
    {
        static void Main(string[] args)
        {
            string[] termis = { "o", "as", "a", "amos", "ais", "am","ei","aste","ou","amos","astes","aram","arei","arás","ará","aremos","areis","arão"};
            string esc="sim",str;
            while (esc == "sim")
            {
                Console.WriteLine("informe a palavra a ser conjugada");
                str = Console.ReadLine().ToLower();
                if (str.EndsWith("ar"))
                {
                    for (int j = 0; j < termis.Length; j++)
                    {
                        if (j == 0)
                            Console.WriteLine("\nPresente do indicativo:");
                        else if (j == 6)
                            Console.WriteLine("\nPretérito perfeito do indicativo:");
                        else if (j == 12)
                            Console.WriteLine("\nFuturo do presente do indicativo:");
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (i != str.LastIndexOf('a') && i != str.LastIndexOf('r'))
                            {
                                Console.Write(str[i]);
                            }
                        }
                        Console.WriteLine(termis[j]);
                    }
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("palavra inválida");
                do
                {
                    Console.WriteLine("deseja continuar?\nsim ou não");
                    esc = Console.ReadLine().ToLower();
                }
                while (esc != "sim" && esc != "não");
            }
            Console.WriteLine("programa encerrado");
            Console.ReadLine();
        }
    }
}
