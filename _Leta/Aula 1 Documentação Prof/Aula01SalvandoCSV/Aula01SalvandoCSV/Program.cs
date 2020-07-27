using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula01SalvandoCSV.Entidades;
using Aula01SalvandoCSV.CLienteReposirory;

namespace Aula01SalvandoCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("////Cadastro de cliente grando dados no CSV///");

            Cliente cliente = new Cliente();

            Console.WriteLine("Informe seu ID:");
            cliente.Idcliente =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe seu nome:");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Informe seu Email:");
            cliente.Email = Console.ReadLine();

            //Mstrando na tela os dados do CLiente
            Console.WriteLine("\n Dados do Cliente:");
            Console.WriteLine("\t Id do Cliente:  " + cliente.Idcliente);
            Console.WriteLine("\tNome..........:  " + cliente.Nome);
            Console.WriteLine("\t Email.........:" + cliente.Email);

            Console.WriteLine("Salvando o registro no csv....");

            try
            {
                ClienteRepository clienteReposirio = new ClienteRepository();
                clienteReposirio.GravarClienteCsv(cliente);
                Console.WriteLine("Registros Gravados com sucesso!");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro ao gravar:" + ex);
            }

            Console.WriteLine("/n Deseja continuar? (S)im ou (N)ão:");
            string opcao = Console.ReadLine();

            if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                //recursividade
                Main(args);
            }
            else
            {
                Console.WriteLine("Bye!");
            }
           
            
        }
    }
}
