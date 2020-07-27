using Gravando.CSV.Cliente_Repo;
using Gravando.CSV.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gravando.CSV
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n - CADASTRO DE CLIENTE - \n");

            Cliente cliente = new Cliente();

            Console.WriteLine("Informe o Id do CLiente:");
            cliente.IdCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Nome:");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Email:");
            cliente.Email = Console.ReadLine();

            Console.WriteLine("Dados do Cliente:");

            Console.WriteLine("O id do cliente é:" + cliente.IdCliente);
            Console.WriteLine("O nome do cliente é:" + cliente.Nome);
            Console.WriteLine("Email do Cliente é:" + cliente.Email);

            try
            {
                ClienteRepo repo = new ClienteRepo();

                repo.ExportarParaCSV(cliente);
                Console.WriteLine("Dados Salvos com sucesso!");
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro na gravação do arquivo:" + e.Message);
            }

            Console.WriteLine("Deseja Cadastrar um novo cliente (S) ou (N)?");
         string opcao = Console.ReadLine();

            if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Fim!");
            }
            

            Console.ReadKey();


            
        }
    }
}
