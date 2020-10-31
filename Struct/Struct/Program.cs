using System;
using System.Globalization;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int pessoa;

                Console.WriteLine("Informe a quantidade de pessoas: "); //Usuário irá informar quantas pessoas
                pessoa = int.Parse(Console.ReadLine());
                double[] vect = new double[pessoa];  //Criação de um laço para criar o vetor conforme o tamanho indicado pelo usuário


                Console.WriteLine("Informe a altura da pessoa: ");



                for (int i = 0; i < pessoa; i++)
                {
                    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Altura da pessoa " + "(" + i + "): " + vect[i]);
                }

                double soma = 0.0;             


                for (int i = 0; i < pessoa; i++) //Utilização do comando "for" para percorrer o vetor
                {
                    soma += vect[i]; //Somatoria dos elementos inseridos
                }



                Console.WriteLine("A média de altura das pessoas é = " + soma/ pessoa);
            }
        }
    }
}
