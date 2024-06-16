using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer11
{
    internal class Atividade11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe a string em formato de CSV");
            string strc, str = Console.ReadLine();
            strc = str.Replace("\\n", ",*");
            string[] div = strc.Split(',');
            for (int i = 0; i < div.Length; i++) 
            {
                if (div[i].Contains("*"))
                {
                    Console.Write("\n"+"\"" + div[i].Remove(0,1) + "\"");
                }
                else
                Console.Write("\""+div[i]+"\""+" ");
            }
            Console.ReadLine();
        }
    }
}
