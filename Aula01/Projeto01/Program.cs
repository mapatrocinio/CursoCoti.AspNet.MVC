using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades; //importando
using Projeto01.Repositorios; //importando
namespace Projeto01
{
    class Program
    {
        //função que executa o projeto
        static void Main(string[] args)
        {
            //impressão no prompt de comando
            Console.WriteLine("\n - CADASTRO DE CLIENTE - \n");
            Cliente cliente = new Cliente();
            Console.Write("Informe o Id do Cliente......: ");
            cliente.IdCliente = int.Parse(Console.ReadLine());
            Console.Write("Informe o Nome do Cliente....: ");
            cliente.Nome = Console.ReadLine();
            Console.Write("Informe o Email do Cliente...: ");
            cliente.Email = Console.ReadLine();
            //imprimindo..
            Console.WriteLine("\nDados do Cliente:");
            Console.WriteLine("\tId do Cliente.: " + cliente.IdCliente);
            Console.WriteLine("\tNome..........: " + cliente.Nome);
            Console.WriteLine("\tEmail.........: " + cliente.Email);
            //instanciando a classe de repositorio
            ClienteRepository clienteRepository = new ClienteRepository();
            try //tentativa
            {
                clienteRepository.ExportarParaCsv(cliente);
                Console.WriteLine("\nDados gravados em CSV com sucesso!");
            }

            catch (Exception e) //captura da exceção
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
            Console.Write("\nDeseja continuar? (S)im ou (N)ão: ");
            string opcao = Console.ReadLine();
            if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                //recurvidade..
                Main(args);
            }
            else
            {
                Console.WriteLine("Bye!");
            }
            //pausar a execução do prompt até que
            //qualquer tecla seja pressionada
            //Console.ReadKey();
        }
    }
}