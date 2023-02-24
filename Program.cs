using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Gerente MandaChuva = new Gerente();
            Vendedor ExecutivoDeVendas = new Vendedor();

            //menu principal
            while (true)
            {
                Console.WriteLine("Bem Vindo à Loja");
                Console.WriteLine("Digite sua opção: (1) para Cadastro, (2) para Vendas, (3) para Sair do Programa:");
                int opcao = int.Parse(Console.ReadLine());

                //switch case do menu principal
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\nMódulo Cadastro\n");
                        CadastroGerente();
                        Console.WriteLine("\n");
                        CadastroVendedor();
                        break;

                    case 2:
                        Vendas();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }


                //modulo vendas
                void Vendas()
                {
                    //submenu modulo vendas
                    while (true)
                    {
                        Console.WriteLine("\nModulo Vendas\n");
                        Console.WriteLine("Deseja fazer uma Venda? Digite (1) Sim pelo Gerente ou (2) Sim pelo Vendedor ou (3) Não:");
                        Console.WriteLine("Digite (4) para Voltar à Tela Inicial");
                        int menu = int.Parse(Console.ReadLine());

                        //switch case do submenu vendas
                        switch (menu)
                        {
                            case 1:
                                Console.WriteLine($"Efetuando uma venda pelo Gerente {MandaChuva.Nome}, cuja Idade é {MandaChuva.Idade} e cujo código de Funcionário é {MandaChuva.CodigoFuncionario}.");
                                MandaChuva.Vender();
                                break;

                            case 2:
                                Console.WriteLine($"Efetuando uma venda pelo Vendedor {ExecutivoDeVendas.Nome}, cuja Idade é {ExecutivoDeVendas.Idade} e cujo código de Funcionário é {ExecutivoDeVendas.CodigoFuncionario}.");
                                ExecutivoDeVendas.Vender();
                                break;

                            case 3:
                                Console.WriteLine("Funcionários não estão efetuando vendas, estão à toa...");
                                break;

                            case 4:
                                return;

                            default:
                                Console.WriteLine("Opção Inválida");
                                break;
                        }
                    }
                }
            }

            //modulo cadastro gerente
            void CadastroGerente()
            {
                Console.WriteLine("Insira o nome do Gerente: ");
                MandaChuva.Nome = Console.ReadLine();
                Console.WriteLine("Insira a idade do Gerente: ");
                MandaChuva.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o Codigo de Funcionario do Gerente: ");
                MandaChuva.CodigoFuncionario = int.Parse(Console.ReadLine());
            }

            //modulo cadastrovendedor
            void CadastroVendedor()
            {
                Console.WriteLine("Insira o nome do Vendedor: ");
                ExecutivoDeVendas.Nome = Console.ReadLine();
                Console.WriteLine("Insira a idade do Vendedor: ");
                ExecutivoDeVendas.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o Codigo de Funcionario do Vendedor: ");
                ExecutivoDeVendas.CodigoFuncionario = int.Parse(Console.ReadLine());
            }
        }
    }
    
}
