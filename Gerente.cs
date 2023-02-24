using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Gerente
    {

        public string Nome { get; set; }
        private int _idade = 18;
        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value < 18 || value > 80)
                {
                    Console.WriteLine("A idade do Gerente deve ser de no mínimo 18 anos, e no máximo 80 anos. Aplicado o valor padrão de 18.");
                }
                else
                {
                    _idade = value;
                }


            }

        }


        public int CodigoFuncionario { get; set; }

        public void Vender()
        {
            Console.WriteLine("Mais uma venda com Sucesso feita pelo Gerente!");
        }

        public Gerente()
        {
            this.Nome = Nome;
            this.Idade = _idade;
            this.CodigoFuncionario = CodigoFuncionario;
        }
    }
}
