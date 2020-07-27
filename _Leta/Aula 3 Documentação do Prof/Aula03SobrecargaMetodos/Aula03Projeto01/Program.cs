using Aula03Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula03Projeto01.Entities.Types;
using Aula03Projeto01.Services;

namespace Aula03Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
          
            try
            {
                Cliente cliente = new Cliente(1, "thiago Leta", "mapatrocinio@gmail.com", Sexo.Masculino, EstadoCivil.Casado);

                Console.WriteLine(cliente.ToString());
                EnviarEmail email = new EnviarEmail();
                email.EnviarMensagem(cliente);
                Console.WriteLine("EMAIL ENVIADO COM SUCESSO");

                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error:" + ex);
                Console.ReadKey();
            }

    

        }

       
     
    }
}
