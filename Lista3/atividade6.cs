using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade6
{
    internal class atividade6
    {
        static void Main(string[] args)
        {
            string soun;
            double sal, msal=0, est, conts = 0, contp = 0, conte = 0, salt=0,estt=0;
            soun = "a";
            while (soun != "não")
            {
                soun = "a";
                Console.WriteLine("\ninforme o salário do habitante:");
                sal = float.Parse(Console.ReadLine());
                Console.WriteLine("informe a quantidade de anos de estudo do habitante:");
                est = int.Parse(Console.ReadLine());
                contp++;
                salt += sal;
                Console.WriteLine($"\n1.média do salário da população:\nR${(salt / contp).ToString("N2")}\n");
                estt += est;
                Console.WriteLine($"2.média de anos de estudo:\n{estt / contp} anos\n");
                if (sal > msal)
                    msal = sal;
                Console.WriteLine($"3. maior salário:\nR${(msal).ToString("N2")}\n");
                if (sal <= 5000)
                    conts++;
                Console.WriteLine($"4. percentual de pessoas com salário até R$5000,00:\n{(conts / contp) * 100.0}%\n");
                if (est >= 15)
                    conte++;
                Console.WriteLine($"5.percentual de pessoas com 15 ou mais anos de estudo:\n{(conte / contp) * 100.0}%\n");
                while (soun != "não" && soun != "sim")
                {
                    Console.WriteLine("deseja continuar? sim/não");
                    soun = Console.ReadLine();
                    if (soun != "não" && soun != "sim")
                        Console.WriteLine("opção inválida, escolha entre \"sim\" ou \"não\".");
                }
            }
            Console.WriteLine("programa encerrado.");
            Console.ReadLine();
                
        }
    }
}
