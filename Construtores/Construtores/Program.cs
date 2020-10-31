using System;
using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
            //Primeiro entrei com os dados e pedi para o usuario entrar com os dados
        {
            Console.WriteLine("Entre com os dados do produto: "); 
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine(); // variaveis do usuario
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produtos p = new Produtos(nome, preco, quantidade); // Passo TODOS os valores das variaveis 

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("Digite o numero de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverPodutos(qte);

            Console.WriteLine("Dados atualizados" + p); 
        }
    }
}
