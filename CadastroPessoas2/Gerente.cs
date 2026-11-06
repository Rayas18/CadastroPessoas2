using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas2
{
    public class Gerente : Funcionario
    {
        public string Departamento;

        public Gerente(string nome, int idade, decimal salario, string departamento)
            : base(nome, idade, salario)
        {
            Departamento = departamento;
        }

        public void ExibirDadosGerente()
        {
            Console.WriteLine("Departamento: " + Departamento);
            ExibirDadosFuncionario();
                
        }
    }
}
