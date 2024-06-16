using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id1, id2, id3;
            Console.WriteLine("informe a idade 1:");
            id1 = int.Parse(Console.ReadLine());
            Console.WriteLine("informe a idade 2:");
            id2 = int.Parse(Console.ReadLine());
            Console.WriteLine("informe a idade 3:");
            id3 = int.Parse(Console.ReadLine());
            int men, mai;

            if (id1 <= id2 && id1 <= id3)
                men = id1;
            else if (id2 <= id1 && id2 <= id3)
                men = id2;
            else
                men = id3;

            if (id1 >= id2 && id1 >= id3)
                mai = id1;
            else if (id2 >= id1 && id2 >= id3)
                mai = id2;
            else
                mai = id3;

            Console.WriteLine($"a menor idade é {men} e a maior é {mai}");

            Console.ReadLine();
        }
    }
}
