using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IAnimal
    {
        void Nome(string nome);
        void Peso(int peso);
        void Venenoso(bool venenoso);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public int Peso { get; set; }
        public bool Venenoso { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IAnimal.Peso(int peso)
        {
            this.Peso = peso;
        }
        void IAnimal.Venenoso(bool venenoso)
        {
            this.Venenoso = venenoso;
        }
    }

}



