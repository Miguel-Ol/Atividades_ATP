using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace atividade5
{
    internal class atividade5
    {
        static void Main(string[] args)
        {
            int op,mes;
            bool cont;
            double sala;
            Console.WriteLine("Menu de opções:\r\n1. Novo salário\r\n2. Férias\r\n3. Décimo terceiro\r\n4. Sair\r\n");
            op = int.Parse(Console.ReadLine());
            while (op != 4)
            {
                cont = true;
                if (op == 1)
                {
                    while (cont == true)
                    {
                        Console.WriteLine("informe o salário:");
                        sala = double.Parse(Console.ReadLine());
                        if (sala >= 0 && sala <= 999.99)
                        {
                            Console.WriteLine($"o novo sálario é: R${(sala + ((sala * 15) / 100)).ToString("N2")}");
                            cont = false;
                        }
                        else if (sala >= 1000 && sala <= 2000)
                        {
                            Console.WriteLine($"o novo sálario é: R${(sala + ((sala * 10) / 100)).ToString("N2")}");
                            cont = false;
                        }
                        else if (sala > 2000)
                        {
                            Console.WriteLine($"o novo sálario é: R${(sala + ((sala * 5) / 100)).ToString("N2")}");
                            cont = false;
                        }
                        else
                            Console.WriteLine("valor de sálario inválido, insira um novo valor.");
                    }
                }
                else if (op == 2)
                {
                    while (cont == true)
                    {
                        Console.WriteLine("informe o salário:");
                        sala = double.Parse(Console.ReadLine());
                        if (sala >= 0)
                        {
                            Console.WriteLine($"o novo salário é: R${(sala + (sala / 3)).ToString("N2")}");
                            cont = false;
                        }
                        else
                            Console.WriteLine("valor de sálario inválido, insira um novo valor.");
                    }
                }
                else if (op == 3)
                {
                    while (cont == true)
                    {
                        Console.WriteLine("informe o salário:");
                        sala = double.Parse(Console.ReadLine());
                        Console.WriteLine("informe a quantidade de meses de trabalho na empresa:");
                        mes = int.Parse(Console.ReadLine());
                    
                        if ((mes >= 0 && mes <= 12) && (sala >= 0))
                        {
                            Console.WriteLine($"o sálario de decimo terceiro é: R${((sala * mes) / 12).ToString("N2")}");
                            cont = false;
                        }
                        else
                        {
                            Console.WriteLine("valor de meses de trabalho na empresa ou sálario inválidos, inserir novo valores.");
                        }
                    }
                }
                else
                    Console.WriteLine("opção inválida, escolha uma nova opção.");

                Console.WriteLine("\r\nMenu de opções:\r\n1. Novo salário\r\n2. Férias\r\n3. Décimo terceiro\r\n4. Sair\r\n");
                op = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\r\noperação encerrada.");
            Console.ReadLine();
        }
    }
}
