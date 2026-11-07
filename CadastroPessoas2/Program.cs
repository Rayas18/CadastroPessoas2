using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas2
{
    internal class program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(
                "Ana Souza",
                28,
                "CLI-001");

            cliente.Apresentar();
            cliente.Apresentar(true);

            Funcionario funcionario = new Funcionario("Carlos Lima",
                35,
                4500.00m);

            Gerente gerente = new Gerente(
                "Marina Alves",
                42,
                7000.00m,
                "Tecnologia");

            Console.WriteLine("=== Cliente ===");
            cliente.ExibirDadosCliente();

            Console.WriteLine();

            Console.WriteLine("=== Funcionario ===");
                funcionario.ExibirDadosFuncionario();

            Console.WriteLine();
            Console.WriteLine("=== Gerente ===");
            gerente.ExibirDadosGerente();

            Console.ReadKey();
        }
    }
}
