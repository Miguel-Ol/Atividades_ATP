using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    internal class TesteProduto
    {
        static void Main(string[] args)
        {
            string marca, tamanho, nome;
            double preço;
            Console.WriteLine("escreva a marca do produto 1:");
            marca = Console.ReadLine();
            Console.WriteLine("escreva o tamanho do produto 1:");
            tamanho = Console.ReadLine();
            Console.WriteLine("escreva o nome do produto 1:");
            nome = Console.ReadLine();
            Console.WriteLine("escreva o preço do produto 1:");
            preço = double.Parse(Console.ReadLine());

            Etiqueta etiqueta = new Etiqueta(marca,tamanho);
            Produto produto1 = new Produto(nome,preço,etiqueta);
            Console.WriteLine(produto1 + "\n");


            Console.WriteLine("escreva a marca do produto 2:");
            marca = Console.ReadLine();
            Console.WriteLine("escreva o tamanho do produto 2:");
            tamanho = Console.ReadLine();
            Console.WriteLine("escreva o nome do produto 2:");
            nome = Console.ReadLine();
            Console.WriteLine("escreva o preço do produto 2:");
            preço = double.Parse(Console.ReadLine());

            Produto produto2 = new Produto(nome, preço, marca, tamanho);
            Console.WriteLine(produto2 + "\n");

            Console.WriteLine("altere a marca do produto 2:");
            produto2.Marca = Console.ReadLine();
            Console.WriteLine("altere o tamanho do produto 2:");
            produto2.Tamanho = Console.ReadLine();
            Console.WriteLine("altere o nome do produto 2:");
            produto2.Nome = Console.ReadLine();
            Console.WriteLine("altere o preço do produto 2:");
            produto2.Preço = double.Parse(Console.ReadLine());

            
            Console.WriteLine(produto2);
            Console.ReadLine();
        }
    }
}
