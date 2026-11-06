using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas2
{
    public class Funcionario : Pessoa
    {
        public decimal Salario;

        public decimal CalcularBonus()
        {
            return Salario * 0.10m;
        }

        public void ExibirDadosFuncionario()
        {
            Console.WriteLine("Salario: " + Salario);
            Console.WriteLine("Bônus: " + CalcularBonus());
            Apresentar();
        }
    }
}
