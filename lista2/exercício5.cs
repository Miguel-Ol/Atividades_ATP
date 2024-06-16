using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício4
{
    internal class exercício5
    {
        static void Main(string[] args)
        {
            Console.Write("informe sua idade: ");
            int id = int.Parse(Console.ReadLine());

            if (id < 8)
                Console.WriteLine("categoria infatil A");
            else if (id < 11)
                Console.WriteLine("categoria infatil B");
            else if (id < 14)
                Console.WriteLine("categoria juvenil A");
            else if (id < 18)
                Console.WriteLine("categoria juvenil B");
            else
                Console.WriteLine("categoria sênior");

            Console.ReadLine();
        }
    }
}
