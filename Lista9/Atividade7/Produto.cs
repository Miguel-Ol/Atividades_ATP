using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    internal class Produto
    {
        private string nome;
        private double preço;
        private Etiqueta etiqueta;

        public Produto(string nome, double preço, Etiqueta etiqueta)
        {
            this.nome = nome;
            this.preço = preço;
            this.etiqueta = etiqueta;
        }

        public Produto(string nome, double preço, string marca, string tamanho)
        {
            this.nome = nome;
            this.preço = preço;
            this.etiqueta = new Etiqueta(marca,tamanho);
        }

        public string Nome 
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preço
        {
            get { return preço; }
            set { preço = value; }
        }

        public string Marca
        {
            get { return etiqueta.Marca; }
            set { etiqueta.Marca = value; }
        }
        public string Tamanho
        {
            get { return etiqueta.Tamanho; }
            set { etiqueta.Tamanho = value; }
        }

        public override string ToString()
        {
            return $"nome: {nome}\npreço: {preço}\n{etiqueta}";
        }

    }
}
