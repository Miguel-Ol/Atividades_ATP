using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer5
{
    internal class atividade5
    {
        static void Main(string[] args)
        {
            int c1,c2,c3,vb,vn;
            c1=c2=c3=vb=vn=0;
            String sn;
            byte vot;
            do
            {
                Console.WriteLine("em qual opção o voto é declarado?\n1: Candidato 1\r\n2: Candidato 2\r\n3: Candidato 3\r\n4: Voto em branco");
                vot= byte.Parse(Console.ReadLine());
                if (vot == 1)
                    c1++;
                else if (vot == 2)
                    c2++;
                else if (vot == 3)
                    c3++;
                else if (vot == 4)
                    vb++;
                else vn++;
                do
                {
                    Console.WriteLine("deseja continuar? S: sim N: não");
                    sn = Console.ReadLine();
                }
                while (sn != "N" && sn != "S");
            }
            while (sn!="N");

            Console.WriteLine($"a quantidade total de votos para candidato foi:\r\ncandidato 1: {c1}\r\ncandidato 2: {c2}\r\ncandidato 3: {c3}");
            if (c1 > c2 && c1 > c2)
                Console.WriteLine("o candidato mais votado foi o candidato 1");
            else if (c2 > c1 && c2 > c3)
                Console.WriteLine("o candidato mais votado foi o candidato 2");
            else if (c3 > c2 && c3 > c1)
                Console.WriteLine("o candidato mais votado foi o candidato 3");
            else
                Console.WriteLine("houve um empate entre dois ou três candidatos.");
            Console.WriteLine($"votos nulos: {vn}\r\nvotos em branco: {vb}");
            Console.ReadLine();

        }
    }
}
