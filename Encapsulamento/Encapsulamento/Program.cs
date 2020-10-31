using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pega os dados que o usuario digitar
            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Quantidade: ");
            int qtde = int.Parse(Console.ReadLine());
            Produtos produto = new Produtos(nome, preco, qtde);

            //mostra as informaçoes na tela
            Console.WriteLine("Dados do produto: " + produto );

            //add os produtos de acordo com a quantidade que o usario digitar
            Console.WriteLine("Digite o número de produtos a serem adicionados: ");
            int _qtde = int.Parse(Console.ReadLine());
            produto.AdicionaProduto(_qtde);
            Console.WriteLine("Produto atualizado: " + produto);

            //remove os produtos de acordo com a quantidade que o usuario digitar 
            Console.WriteLine("Informea quantidade de produtos a serem removidos: ");
            _qtde = int.Parse(Console.ReadLine());
            produto.RemoveProduto(_qtde);
            Console.WriteLine("Produtos atualizados: " + produto);

        }
    }
    }

