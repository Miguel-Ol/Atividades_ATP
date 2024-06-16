using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public Data(int dia, int mes, int ano) 
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        public override string ToString()
        {
            return dia + "/" + mes + "/" + ano;
        }
    }
}
