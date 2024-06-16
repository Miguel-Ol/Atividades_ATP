using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer3
{
    internal class atividade3
    {
        static void Main(string[] args)
        {
            double pk, qk, maiqk=0, menqk=double.MaxValue,somqk=0, medqk=0;
            for (int i = 1; i<=50;i++)
            {
                Console.WriteLine("informe o preço do kWh:");
                pk = double.Parse(Console.ReadLine());
                Console.WriteLine("informe a quantidade de kWh consumidos durante o mês:");
                qk = double.Parse(Console.ReadLine());
                if (qk > maiqk)
                    maiqk= qk;
                if (qk < menqk)
                    menqk= qk;
                somqk += qk;
                Console.WriteLine($"\no total a ser pago pelo cliente {i} é:{pk * qk}\n");
            }
            Console.WriteLine($"o maior consumo foi: {maiqk}");
            Console.WriteLine($"o menor consumo foi: {menqk}");
            medqk = somqk / 50;
            Console.WriteLine($"o consumo médio foi: {medqk}");
            Console.ReadLine();
        }
    }
}
