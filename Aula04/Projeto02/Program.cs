using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities; //importando..
using Projeto02.Repositories; //importando..

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(1, "Ana Paula", "anapaula@gmail.com");

            try
            {
                ClienteRepository repository = new ClienteRepository();
                repository.ExportarJson(cliente);


                Console.WriteLine("\nJSON gravado com sucesso!\n");

                Cliente resultado = repository.ImportarJson();
                Console.WriteLine("Cliente: " + cliente.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
