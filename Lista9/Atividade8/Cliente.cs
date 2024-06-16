using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    internal class Cliente
    {
        private string nome;
        private string CPF;
        private ContaCorrente conta;

        public Cliente(string nome, string CPF, ContaCorrente conta)
        {
            this.nome = nome;
            this.CPF = CPF;
            this.conta = conta;
        }
    }
}
