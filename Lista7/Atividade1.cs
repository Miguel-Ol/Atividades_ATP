using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1
{
    internal class Atividade1
    {
        static int MenId(int n1,int n2, int n3, int n4) 
        {
            if (n1 < n2 && n1<n3 && n1<n4) 
            {
                return n1;
            }
            else if (n2 < n1 && n2 < n3 && n2 < n4)
            {
                return n2;
            }
            else if (n3 < n1 && n3 < n2 && n3 < n4)
            {
                return n3;
            }
            else
            {
                return n4;
            }

        }
        static void Main(string[] args)
        {
            int num1,num2,num3,num4;
            Random r = new Random();
            num1 = r.Next(1,100);
            Console.WriteLine(num1);
            num2 = r.Next(1,100);
            Console.WriteLine(num2);
            num3 = r.Next(1, 100);
            Console.WriteLine(num3);
            num4 = r.Next(1, 100);
            Console.WriteLine(num4);
            Console.WriteLine("o menor número é: " + MenId(num1,num2,num3,num4));
            Console.ReadLine();
        }
    }
}
