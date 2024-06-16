using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    internal class CaixaEletronico
    {
        static void Main(string[] args)
        {
            Agencia agencia = new Agencia("Pampulha", 7890, 5);
            ContaCorrente contacorrente = new ContaCorrente(1234, 4,150, agencia);
            Cliente cliente = new Cliente("Ademar da Silva", "123231518-12",contacorrente);

            contacorrente.sacar(140);
            Console.WriteLine(contacorrente.ConsultarSaldo());
            contacorrente.depositar(200);
            Console.WriteLine(contacorrente.ConsultarSaldo());
            contacorrente.depositar(25.45);
            Console.ReadLine();
        }
    }
}
