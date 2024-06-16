using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            int codigoC;
            double quantHT, valorH;
            char sexo;
            Funcionario[] funcionario = new Funcionario[2];
            for (int i = 0; i < funcionario.Length; i++) 
            {
                Console.WriteLine("informe o código do cargo do funcionario "+ (i+1));
                codigoC = int.Parse(Console.ReadLine());
                Console.WriteLine("informe o valor da hora trabalhada do funcionario " + (i + 1));
                valorH = double.Parse(Console.ReadLine());
                Console.WriteLine("informe o sexo do funcionario " + (i + 1));
                sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("informe a quantidade de horas trabalhadas do funcionario " + (i + 1));
                quantHT = double.Parse(Console.ReadLine());
                funcionario[i] = new Funcionario(codigoC, valorH, sexo, quantHT);
            }
            for (int i = 0;i < funcionario.Length; i++)
            {
                Console.WriteLine(funcionario[i]+"\n"+"possui sário final de: " + funcionario[i].salariofim());
            }
            Console.ReadLine();
        }
    }
}
