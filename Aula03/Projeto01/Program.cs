using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities; //importando
using Projeto01.Entities.Types; //importando
using Projeto01.Services; //importando

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(1, "Miguel Angelo",
                    "mapatrocinio@gmail.com",
                                  Sexo.Masculino, EstadoCivil.Solteiro);

            Console.WriteLine("Cliente: " + cliente.ToString());


            try
            {
                EmailService emailService = new EmailService();
                emailService.EnviarMensagem(cliente);

                Console.WriteLine("\nEmail enviado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }

            //pausar o console.
            Console.ReadKey();
        }
    }
}
