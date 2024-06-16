using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class atividade1
    {
        static void Main(string[] args)
        {
            int w = 31;
            int[] dia = new int[w];
            double[] temp = new double[w];
            int esc;
            for(int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine($"informe a temperatura do dia {i + 1}");
                temp[i] = double.Parse(Console.ReadLine());
                dia[i] = i+1;
            }
            Console.WriteLine("qual temperatura deseja pesquisar?");
            esc = int.Parse(Console.ReadLine());
            for (int i = 0; i < temp.Length; i++)
            {
                if( esc == temp[i]) 
                {
                    Console.Write($"{dia[i]}, ");
                }
            }
            Console.ReadLine();
        }
    }
}
