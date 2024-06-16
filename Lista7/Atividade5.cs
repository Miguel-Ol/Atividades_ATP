using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer5
{
    internal class Atividade5
    {
        static int VogCont(char[] a)
        {
            int cont = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] =='a'|| a[i] == 'A'||a[i] == 'e' || a[i] == 'E' || a[i] == 'i' || a[i] == 'I' || a[i] == 'o' || a[i] == 'O' || a[i] == 'u' || a[i] == 'U' )
                cont++;
            }
            return cont;
        }
        static void Main(string[] args)
        {
            int w;
            Console.WriteLine("informe a quantidade de caracteres");
            w= int.Parse(Console.ReadLine());
            char[] b = new char[w];
            Console.WriteLine("informe os caracteres");
            for (int i = 0;i < b.Length;i++)
            {
                b[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("a quantidade de vogais é: " + VogCont(b));
            Console.ReadLine();
        }
    }
}
