using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            string nomep;
            int matriculap;
            double[] notap = new double[10];
            Random rnd = new Random();
            Aluno[] alunoAtual = new Aluno[2];
            for (int i = 0; i< 2; i++)
            {
                Console.WriteLine("informe o nome do aluno:");
                nomep = Console.ReadLine();
                Console.WriteLine("informe a matricula do aluno:");
                matriculap = int.Parse(Console.ReadLine());
                for(int j = 0;j < 10; j++)
                {
                    notap[j] = rnd.Next(1,101);
                    Console.WriteLine($"{j+1}º nota: {notap[j]}");
                }
                alunoAtual[i] = new Aluno(nomep, matriculap, notap);
                Console.WriteLine($"a media do aluno {nomep} com matricula {matriculap} é: {alunoAtual[i].Media()}");
            }
            Console.ReadLine();
        }
    }
}
