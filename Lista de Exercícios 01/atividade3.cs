using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade3
{
    internal class atividade3
    {
        static void Main(string[] args)
        {
            double Cel, fare;
            Console.Write("informe a temperatura em graus Fahrenheit:");
            fare = double.Parse(Console.ReadLine());
            Cel = (fare-32)* 5 / 9;
            Console.WriteLine($"a temperatura em graus Celsius é {Cel}°");
            Console.ReadLine();
        }
    }
}
