using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas2
{
    public class Cliente : Pessoa
    {
        public string CodigoCliente;

        public void ExibirDadosCliente()
        {
            Console.WriteLine("Codigo do cliente: " + CodigoCliente);
            Apresentar();
        }
    }
}
