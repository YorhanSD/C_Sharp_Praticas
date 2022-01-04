using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int adicao = 1;
            int subtracao = 2;
            int multiplicacao = 3;
            int divisao = 4;

            int escolha;

            float valorA;
            float valorB;

            float resultado;

            Console.WriteLine("----Calculadora----\n");

            Console.WriteLine("Operacoes\n");

            Console.WriteLine("1 -> adicao\n");
            Console.WriteLine("2 -> subtracao\n");
            Console.WriteLine("3 -> multiplicacao\n");
            Console.WriteLine("4 -> divisao\n");

            Console.WriteLine("Digite o numero referente a operacao desejada: ");

            escolha = int.Parse(Console.ReadLine());

            if(escolha == adicao)
            {
                Console.WriteLine("Digite a primeira parcela: ");
                valorA = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a segunda parcela: ");
                valorB = float.Parse(Console.ReadLine());

                resultado = valorA + valorB;

                Console.WriteLine("O total da adicao é: " + resultado);
            }

            if (escolha == subtracao)
            {
                Console.WriteLine("Digite o minuendo: ");
                valorA = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o subtraendo: ");
                valorB = float.Parse(Console.ReadLine());

                resultado = valorA - valorB;

                Console.WriteLine("A diferenca da subtracao é: " + resultado);
            }

            if (escolha == multiplicacao)
            {
                Console.WriteLine("Digite o multiplicando: ");
                valorA = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor multiplicador: ");
                valorB = float.Parse(Console.ReadLine());

                resultado = valorA * valorB;

                Console.WriteLine("O produto da multiplicacao é: " + resultado);
            }

            if (escolha == divisao)
            {
                Console.WriteLine("Digite o dividendo: ");
                valorA = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor divisor: ");
                valorB = float.Parse(Console.ReadLine());

                resultado = valorA / valorB;

                Console.WriteLine("O quociente da divisao é: " + resultado);
            }

        }
    }
}
