
using System;

namespace CadastroPessoas2
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public void Apresentar()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
