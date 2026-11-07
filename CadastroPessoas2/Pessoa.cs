
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

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
            }
        }


        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public virtual void Apresentar()
        {
            Console.WriteLine("Nome: " + GetNome());
            Console.WriteLine("Idade: " + idade);
        }
        public void Apresentar(bool mostrarTipo)
        {
            Apresentar();

            if (mostrarTipo)
            {
                Console.WriteLine("Tipo: Pessoa");
            }
        }
    }
}
