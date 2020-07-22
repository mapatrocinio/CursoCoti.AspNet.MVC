using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities; //importando
using Projeto01.Entities.Types; //importando
using Projeto01.Repositories; //importando

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();
            empresa.Contato = new Contato();
            empresa.Enderecos = new List<Endereco>();

            empresa.IdEmpresa = 1;
            empresa.RazaoSocial = "COTI Informática";
            empresa.Cnpj = "123456-7890";
            empresa.Contato.Telefone = "(21)2262-9043";
            empresa.Contato.Email = "contato@cotiinformatica.com.br";

            Endereco endereco1 = new Endereco();
            endereco1.IdEndereco = 1;
            endereco1.Logradouro = "Av Rio Branco, 185";
            endereco1.Bairro = "Centro";
            endereco1.Cidade = "Rio de Janeiro";
            endereco1.Estado = "RJ";
            endereco1.Cep = "25000-000";
            endereco1.Tipo = TipoEndereco.Comercial;

            Endereco endereco2 = new Endereco();
            endereco2.IdEndereco = 2;
            endereco2.Logradouro = "Av Presidente Vargas, 100";
            endereco2.Bairro = "Centro";
            endereco2.Cidade = "Rio de Janeiro";
            endereco2.Estado = "RJ";
            endereco2.Cep = "24000-000";
            endereco2.Tipo = TipoEndereco.Comercial;

            //incluindo os endereços na Empresa..
            empresa.Enderecos.Add(endereco1);
            empresa.Enderecos.Add(endereco2);

            try
            {
                EmpresaRepository empresaRepository = new EmpresaRepository();
                empresaRepository.ExportarJson(empresa);

                Console.WriteLine("\nARQUIVO JSON GRAVADO COM SUCESSO.\n");

                //ler o conteudo do arquivo..
                Empresa resultado = empresaRepository.ImportarJson();


                //imprimindo
                Console.WriteLine("Empresa....: "
                + resultado.ToString());

                Console.WriteLine("Contato....: "
                + resultado.Contato.ToString());

                //varrer e imprimir os endereços
                foreach (Endereco endereco in resultado.Enderecos)
                {
                    Console.WriteLine("Endereço...: " + endereco.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            Console.ReadKey(); //pausar..
        }
    }
}
