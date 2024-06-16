using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade3
{
    internal class atividade3
    {
        static void Main(string[] args)
        {
            int n, idade,cont,fx1,fx2,fx3,fx4,fx5;
            cont=fx1=fx2=fx3=fx4=fx5=0;
            Console.WriteLine("informe a quantidade de idades á serem calculadas: ");
            n = int.Parse(Console.ReadLine());
            while (cont!=n)
            {
                Console.WriteLine("informe a idade a ser calculada: ");
                idade = int.Parse(Console.ReadLine());

                if (idade < 16)
                    fx1++;
                else if (idade < 31)
                    fx2++;
                else if (idade < 46)
                    fx3++;
                else if (idade < 61)
                    fx4++;
                else if (idade > 60)
                    fx5++;

                cont++;
            }
            Console.WriteLine($" 1 a 15 anos: {fx1} \n 16 a 30 anos: {fx2} \n 31 a 45 anos: {fx3} \n 46 a 60 anos: {fx4} \n 61+ anos: {fx5} \n");
            Console.WriteLine($" 1 a 15 anos: {100 * fx1 / n}% \n 16 a 30 anos: {100 * fx2 / n}% \n 31 a 45 anos: {100 * fx3 / n}% \n 46 a 60 anos: {100 * fx4 / n}% \n 61+ anos: {100 * fx5 / n}%");
            Console.ReadLine();
        }
    }
}
