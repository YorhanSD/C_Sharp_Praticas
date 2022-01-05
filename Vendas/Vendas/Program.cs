using System;

namespace Vendas
{
    class Vendas
    {
        static void Main(string[] args)
        {
            string nome;
            float valor_a;
            float valor_b;
            float valor_c;
            float valorTotal;
            int numMeses = 3;
            float mediaDeVendas;

            float comissao_15;
            float comissao_10;
            float comissao_5;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome);
            Console.WriteLine("Digite aqui o valor de vendas referente ao mes de janeiro: ");
            valor_a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o valor de vendas referente ao mes de fevereiro: ");
            valor_b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o valor de vendas referente ao mes de março: ");
            valor_c = int.Parse(Console.ReadLine());
            valorTotal = valor_a + valor_b + valor_c;
            Console.WriteLine("O valor total das vendas em " + numMeses + " meses é: " + valorTotal);
            mediaDeVendas = valorTotal / numMeses;
            Console.WriteLine("A Média de vendas feitas em " + numMeses + " meses é: " + mediaDeVendas);

            if(mediaDeVendas >= 7000)
            {
                Console.WriteLine("Parabéns " + nome + " você recebera uma comissão de 15%");
                comissao_15 = 15 * mediaDeVendas / 100;
                Console.WriteLine("Voce recebera um valor adicional de " + comissao_15 + " reais a mais");
            }
            else if(mediaDeVendas >= 5000)
            {
                Console.WriteLine("Parabéns " + nome + " você recebera uma comissão de 10%");
                comissao_10 = 10 * mediaDeVendas / 100;
                Console.WriteLine("Voce recebera um valor adicional de " + comissao_10 + " reais a mais");
            }
            else if (mediaDeVendas >= 3000)
            {
                Console.WriteLine("Parabéns " + nome + " você recebera uma comissão de 5%");
                comissao_5 = 5 * mediaDeVendas / 100;
                Console.WriteLine("Voce recebera um valor adicional de " + comissao_5 + " reais a mais");
            }

        }
    }
}
