using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities; //importando
using Projeto01.Repositories; //importando


namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando e instanciando objetos
            Funcionario funcionario = new Funcionario();
            funcionario.Setor = new Setor();
            funcionario.Funcao = new Funcao();

            try
            {
                Console.WriteLine("\n - CADASTRO DE FUNCIONÁRIO - \n");

                Console.Write("Informe o Id do Funcionário.....: ");
                funcionario.Id = int.Parse(Console.ReadLine());

                Console.Write("Informe o Nome..................: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("Informe a Data de Admissão......: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                Console.Write("Informe o Salário...............: ");
                funcionario.Salario = decimal.Parse(Console.ReadLine());

                Console.Write("Informe a Descrição da Função...: ");
                funcionario.Funcao.Descricao = Console.ReadLine();

                Console.Write("Informe o Código do Setor.......: ");
                funcionario.Setor.Codigo = Console.ReadLine();

                Console.Write("Informe o Nome do Setor.........: ");
                funcionario.Setor.Nome = Console.ReadLine();

                //gravar o arquivo..
                FuncionarioRepository repository = new FuncionarioRepository();
                repository.ExportarParaTxt(funcionario);

                Console.WriteLine("\nDados gravados em arquivo TXT com sucesso.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            Console.ReadKey();
        }

    }

}

