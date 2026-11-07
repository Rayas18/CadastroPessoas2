
using System;

namespace CadastroPessoas2
{
    public abstract class Pessoa
    {
        private string nome;
        private int idade;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string novoNome)
        {
            nome = novoNome;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int novaIdade)
        {
            idade = novaIdade;
        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void Apresentar()
        {
            Console.WriteLine("Nome: " + GetNome());
            Console.WriteLine("Idade: " + GetIdade());
        }
    }
}
