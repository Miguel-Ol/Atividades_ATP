using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    internal class ContaCorrente
    {
        private int numero;
        private int digito;
        private Agencia agencia;
        private double saldo;

        public ContaCorrente(int numero, int digito, double saldo, Agencia agencia)
        {
            this.numero = numero;
            this.digito = digito;
            this.agencia = agencia;
            this.saldo = saldo;
        }

        public string Nome 
        {
            get {return agencia.Nome;}
            set { agencia.Nome = value; }
        }

        public int Numero { get { return agencia.Numero;} set {  agencia.Numero = value; } }
        public int Digito { get { return agencia.Digito; } set { agencia.Digito = value; } }

        public void depositar(double deposito)
        {
            saldo += deposito;
        }

        public void sacar(double saque)
        {
            if (saldo - saque >= 0)
            {
                saldo -= saque;
            }
            else
            {
                saldo = 0;
            }
        }

        public string ConsultarSaldo() 
        {
            return $"número conta corrente: {numero}, dígito: {digito}\n{agencia}\nsaldo: {saldo}";
        }
    }
}
