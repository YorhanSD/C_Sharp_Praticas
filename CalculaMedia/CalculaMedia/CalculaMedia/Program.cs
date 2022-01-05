using System;

namespace CalculaMedia
{
    class CalculaMedia
    {
        static void Main(string[] args)
        {
            float[] valor = new float[4];
            float valorTotal;
            float media;

            Console.WriteLine("===Calcula=Media===");

            Console.WriteLine("Digite o primeiro numero: ");
            valor[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            valor[1] = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            valor[2] = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto numero: ");
            valor[3] = float.Parse(Console.ReadLine());

            valorTotal = valor[0] + valor[1] + valor[2] + valor[3];

            Console.WriteLine("O total dos valores somados é: " + valorTotal);

            media = valorTotal / 4;

            Console.WriteLine("A media é: " + media);


        }
    }
}
