using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista9
{
    public class Registro
    {
        static void Main(string[] args)
        {
            string nomep,endereçop,telefonep;
            Clientes[] cliente = new Clientes[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("informe o nome do cliente:");
                nomep = Console.ReadLine();
                Console.WriteLine("informe o endereço do cliente:");
                endereçop = Console.ReadLine();
                Console.WriteLine("informe o telefone do cliente:");
                telefonep = Console.ReadLine();
                cliente[i] = new Clientes(nomep, endereçop, telefonep);
                Console.WriteLine();
            }
            Console.WriteLine("informe o nome do cliente que não possui endereço:");
            nomep = Console.ReadLine();
            Console.WriteLine("informe o telefone do cliente que não possui endereço:");
            telefonep = Console.ReadLine();
            Clientes solo = new Clientes (nomep,telefonep);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(cliente[i]);
            }
            Console.WriteLine($"nome do cliente que não possui endereço: {solo.Nome}\ntelefone do cliente que não possui endereço: {solo.Telefone}");
            Console.ReadLine();
        }
    }
}
