using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Vendedor
    {
        
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int CodigoFuncionario { get; set; }

        public void Vender()
        {
            Console.WriteLine("Mais uma venda com sucesso feita pelo Vendedor!");
        }

        public Vendedor()
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.CodigoFuncionario = CodigoFuncionario;
        }

    }



}
