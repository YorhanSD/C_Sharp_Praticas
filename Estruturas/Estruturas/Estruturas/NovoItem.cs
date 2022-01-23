using System;
using System.Collections.Generic;
using System.Text;
using NovosValores;
using NovosNomes;
using Interface;
using Enum;

namespace NovoItem
{
    class NovoItem
    {
        static void Main(string[] args)
        {
            Numeros number = new Numeros(); 

            NomesPessoas person = new NomesPessoas();

            Animal animal = new Animal();

            Meses meses = new Meses();

            number.ValorA = 16;
            number.ValorB = 13;

            person.Nome = "Joana";
            person.Estado = "MG";
            person.Idade = 38;

            person.Nome = "Kleber";
            person.Estado = "RJ";
            person.Idade = 17;

            var person2 = new NomesPessoas();

            person2.Nome = "Samantha";
            person2.Estado = "BA";
            person2.Idade = 22;

            animal.Nome = "Crocodilo";
            animal.Peso = 1020;
            animal.Venenoso = false;

            animal.Nome = "Naja";
            animal.Peso = 01;
            animal.Venenoso = true;

            Console.WriteLine(animal.Nome = "Naja");

            animal.Nome = "Dromedário";
            animal.Peso = 450;
            animal.Venenoso = false;

            animal.Nome = "Dragão de komodo";
            animal.Peso = 60;
            animal.Venenoso = true;

            Meses meses1 = Meses.janeiro;
            var meses3 = (Meses)3;
            var meses0 = (Meses)0;
            var meses4 = (Meses)4;
            Meses meses5 = (Meses)5;

            Console.WriteLine("Fim");

        }
    }
}
