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
            Produto produto = new Produto(1, "Mouse", 25.0m, 10);

            try
            {
                ProdutoRepository repository = new ProdutoRepository();
                repository.ExportarParaXml(produto);

                Console.WriteLine("\nXML gerado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
