using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Encapsulamento
{
    class Produtos
    {
       

        //Declaração de Váriaveis metodo GET - SET 
        string _nome;
        double _preco;
        int _quantidade; 

     

        //Construtor 
        public Produtos(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome() //usa o return para passar as informaçoes
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)//evitar o nulo
            {
                _nome = nome;
            }

        }
       
        
        public double Preco
        {
            get { return _preco; }
        }

        public int Qtde
        {
            get { return _quantidade; }
        }
        /*
          -- Fim -- 
         */

        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionaProduto(int qtde)
        {
            _quantidade += qtde;
        }

        public void RemoveProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", R$ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

