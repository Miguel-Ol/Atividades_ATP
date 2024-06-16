using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    internal class Circulo
    {
        public double raio;

        public Circulo(double raio) 
        {
            this.raio = raio;
        }

        public double CalcularArea()
        {
            return Math.Pow(raio,2) * Math.PI;
        }
        public  double CalularDiametro() 
        {
            return raio * 2;
        }
        public double CalcularPerimetro() 
        {
            return 2*Math.PI*raio;
        }
    }
}
