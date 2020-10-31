using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Construtores
{
    class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produtos(string nome, double preco, int quantidade) //Parametros para o produto
        {
            Nome = nome; // Nome corresponde a nome. nome = informaçoes do usuario
            Preco = preco;
            Quantidade = quantidade;

        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        //Agora so fazer os metodos para adicionar e remover produtos
        public void AdicionarProduto(int quantidade) //Guardou na memoria para nao perder. Adicionei o produto
        {
            Quantidade += quantidade;//Letra maiuscula valor que depositei e minuscula a referencia 
        }
        public void RemoverPodutos(int quantidade) // Para remover o produto
        {
            Quantidade = Quantidade - quantidade;
        }
        public override string ToString()//Metodo ToString para concatenar todas as informaçoes
        {
            return Nome + ",R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + "," + Quantidade + "unidades, Total: R$" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
