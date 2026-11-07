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

            Funcionario funcionario = new Funcionario(
                "Carlos Lima",
                35,
                4500.00m);

            Gerente gerente = new Gerente(
                "Marina Alves",
                42,
                7000.00m,
                "Tecnologia");

            // Propriedade completa: atribuir e ler idade.
            cliente.Idade = 29;
            Console.WriteLine("Idade do cliente: " + cliente.Idade);

            // Sobrecarga: mesmo método, argumentos diferentes.
            cliente.Apresentar();
            cliente.Apresentar(true);

            // Sobrecarga de construtor: duas formas de criar Cliente.
            Cliente clienteSemCodigo = new Cliente("Bruno Lima", 31);

            // Sobrescrita: cada tipo concreto apresenta seus próprios dados.
            Pessoa[] pessoas = new Pessoa[]
            {
                cliente,
                funcionario,
                gerente
            };

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine();
                pessoa.Apresentar();
            }

            // Exibição dos dados específicos de cada classe.
            Console.WriteLine();
            Console.WriteLine("=== Cliente ===");
            cliente.ExibirDadosCliente();

            Console.WriteLine();
            Console.WriteLine("=== Cliente sem código ===");
            clienteSemCodigo.ExibirDadosCliente();

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