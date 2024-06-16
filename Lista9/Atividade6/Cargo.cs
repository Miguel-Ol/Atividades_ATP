using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    internal class Cargo
    {
        private int codigoC;
        private double valorH;
        public Cargo(int codigoC, double valorH) 
        {
            this.codigoC = codigoC;
            this.valorH = valorH;
        }
        public int CodigoC
        {
            get { return codigoC; }
            set { codigoC = value; }
        }
        public double ValorH
        {
            get { return valorH; }
            set { valorH = value; }
        }
        public override string ToString()
        {
            return "o funcionario com código de cargo: " + codigoC + " e com valor de horas trabalhadas de: " + valorH; 
        }
    }
}
