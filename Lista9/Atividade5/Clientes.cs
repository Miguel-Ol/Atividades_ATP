using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista9
{
	public class Clientes
	{
		private string nome;
		private string endereço;
		private string telefone;

		public Clientes(string nome, string endereço, string telefone)
		{
			this.nome = nome;
			this.endereço = endereço;
			this.telefone = telefone;
		}
		public Clientes(string nome, string telefone) 
		{
			this.nome = nome;
			this.telefone= telefone;
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public override string ToString()
		{
			return $"nome: {nome}\nendereço: {endereço}\ntelefone: {telefone}\n";
		}

    }
}
