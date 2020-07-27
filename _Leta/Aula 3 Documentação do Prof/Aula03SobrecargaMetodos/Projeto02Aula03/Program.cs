using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02Aula03.Repositorio;
using Projeto02Aula03.Entities;

namespace Projeto02Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(1, "Mouse", 25.0m, 10);

            try
            {
                GerarXml repository = new GerarXml();
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
