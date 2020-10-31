using System;
using System.Globalization;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe a quantidade de produtos: ");   //O usuário irá informar a quantidade de produtos
            int n = int.Parse(Console.ReadLine());



            Produtos[] p = new Produtos[n]; // Isso irá criar o vetor 

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o nome do produto:"); //Usuario irá digitar o nome do produto
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o valor do produto:");// Agora o valor
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Produtos { Nome = nome, Valor = valor };
            }


            double soma = 0.0; 
            for (int i = 0; i < n; i++)
            {
                soma += p[i].Valor;
            }



            Console.WriteLine("Preço médio: " + soma / p.Length);
        }
    }
}