using System;

namespace Vetor
{
    class Vetor
    {
        static void Main(string[] args)
        {
            int colunas = 5;
            int contador = 5;
            string[] nomes = new string[colunas];

            nomes[0] = "Paula";
            nomes[1] = "Carlos";
            nomes[2] = "Pedro";
            nomes[3] = "Kaique";
            nomes[4] = "Joana";

            for (int posicao = 0; posicao < contador; posicao++)
            {
                Console.WriteLine("Nome " + posicao + ": " + nomes[posicao]);
            }

            int tamanho = 3;
            string[] times = new string[tamanho];

            for (int posicao = 0; posicao < tamanho; posicao++)
            {
                Console.WriteLine("Digite um nome de um Time: ");
                times[posicao] = Console.ReadLine();
            }

            for (int posicao = 0; posicao < tamanho; posicao++)
            {
                Console.WriteLine("Time " + posicao + ": " + times[posicao]);
            }
        }
    }
}
