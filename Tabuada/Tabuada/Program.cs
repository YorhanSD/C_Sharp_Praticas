using System;

namespace Tabuada
{
    class Tabuada
    {
        static void Main(string[] args)
        {
            int numero = 0;

            int resultado = 0;
            int multiplicador = 0;
            
            Console.WriteLine("Tabuada do 9");

            while (numero < 90)
            {
                numero = numero + 9;
                Console.WriteLine(numero);
            }

            while(multiplicador < 10)
            {
                multiplicador = multiplicador + 1;
                resultado = multiplicador * 9;
                Console.WriteLine(multiplicador + " X 9 = " + resultado);
            }
        }
    }
}
