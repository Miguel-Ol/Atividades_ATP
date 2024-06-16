using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade9
{
    class Estacionamento
    {
        private String nome;  //nome do estacionamento.  
        private int numTotalVagas;//número total de vagas do estacionamento. 
        private int numVagasLivres;  //número de vagas livres no estacionamento. 
        private String[] vagas; // vetor que armazena cada uma das vagas do estacionamento.Caso a vaga esteja ocupada, este vetor indica a placa do veículo que aocupa.
    public Estacionamento(String nome, int numTotalVagas)
        {
            this.nome = nome;
            this.numVagasLivres = numTotalVagas;
            this.vagas = new string[numTotalVagas];
        }
        public int Estacionar(String placa)
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if(vagas[i] == null)
                {
                    vagas[i] = placa;
                    return i;
                }
            }
            return -1;
        }
        public int ObterVagaOcupada(String placa)
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == placa)
                {
                    return i;
                }
            }
            return -1;
        }
        public void RetirarVeiculo(String placa)
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == placa)
                {
                    vagas[i] = null;
                }
            }
        }
        public int ObterNumVagasLivres()
        {
            int vagasLivres=0;
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == null)
                {
                    vagasLivres++;
                }
            }
            return vagasLivres;
        }
        public void ExibirOcupacao()
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] != null)
                {
                    Console.WriteLine("vaga "+ i + ": " + vagas[i]);
                }
                else
                {
                    Console.WriteLine("vaga " + i + ": " + "vazia");
                }                
            }
            Console.WriteLine();
        }
    }
}
