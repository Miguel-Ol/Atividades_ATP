using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    internal class Agencia
    {
        private string nome;
        private int numero;
        private int digito;

        public Agencia(string nome, int numero, int digito) 
        {
            this.nome = nome;
            this.numero = numero;
            this.digito = digito;
        }

        public string Nome { get {  return nome; } set { nome = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
        public int Digito { get { return digito; } set { digito = value; } }

        public override string ToString()
        {
            return $"número agência: {numero}, dígito: {digito}";
        }
    }
}
