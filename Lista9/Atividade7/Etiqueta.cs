using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    internal class Etiqueta
    {
        private string marca;



        private string tamanho;

        public Etiqueta (string marca, string tamanho)
        {
            this.marca = marca;
            this.tamanho = tamanho;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        public override string ToString()
        {
            return $"marca: {marca}\ntamanho: {tamanho}";
        }
    }
}
