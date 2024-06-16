using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exer5
{
    internal class Atividade5
    {
        static void Main(string[] args)
        {
            string str;
            bool conf= true;
            int dec = 1, cont = 0;
            Console.WriteLine("informe a string:");
            str = Console.ReadLine();
            char[] strc = new char[str.Length];
            foreach (char c in str)
            {
                strc[strc.Length - dec] = c;
                dec++;
            }
            foreach (char c in str)
            {
                if (c != strc[cont])
                {
                    conf = false;
                }
                cont++;
            }
            Console.WriteLine(conf);
        }
    }
}
