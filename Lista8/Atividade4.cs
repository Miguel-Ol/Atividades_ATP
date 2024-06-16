using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4
{
    internal class Atividade4
    {
        static void Main(string[] args)
        {
            string str;
            int dec;
            Console.WriteLine("informe a string");
            str = Console.ReadLine();
            char[] strc = new char[str.Length];
            dec = 1;
            foreach (char c in str) 
            {
                strc[strc.Length-dec] = c;
                dec++;
            }
            Console.WriteLine(strc);
        }
    }
}
