using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            
            double n;
            Random rnd = new Random();
            Circulo[] raioTeste = new Circulo[4];
            for (int i = 0; i < 4; i++)
            {
                n = rnd.Next(1, 100);
                Console.WriteLine($"o novo valor do raio é: {n}");
                raioTeste[i] = new Circulo(n);
                Console.WriteLine($"área: {raioTeste[i].CalcularArea()}\ndiâmrtro: {raioTeste[i].CalularDiametro()}\nperimetro: {raioTeste[i].CalcularPerimetro()}\n");
            }
            Console.ReadLine();
        }
    }
}
