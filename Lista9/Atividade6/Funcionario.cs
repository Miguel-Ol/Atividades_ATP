using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    internal class Funcionario
    {
        private Cargo cargo;
        private char sexo;
        private double quantHT;

        public Funcionario(int codigoC,double valorH,char sexo,double quantHT) 
        {
            this.cargo = new Cargo(codigoC,valorH);
            this.sexo = sexo;
            this.quantHT = quantHT;
        }

        public double salariofim() 
        {
            double salariofim = quantHT * cargo.ValorH;
            return salariofim;
        }
        public override string ToString() 
        {
            return cargo.ToString() + " de sexo: " + sexo + " com quantidade de horas trabalhadas de: " + quantHT;
        }
    }
}
