using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula03Projeto01.Entities;
using Aula03Projeto01.Entities.Types;
using System.Configuration;
using System.Net;
using System.Net.Mail;


namespace Aula03Projeto01.Services
{
    public class EnviarEmail
    {
        public void EnviarMensagem(Cliente cliente)
        {

            //definindo remetente
            MailAddress from = new MailAddress(ConfigurationManager.AppSettings["EMAIL"]);

            //DEFINIR DESTINATÁRIO
            MailAddress to = new MailAddress(cliente.Email);

            //montar um email
            MailMessage msg = new MailMessage(from, to);

            //Assunto do email
            msg.Subject = "SEJA BEM VINDO";
            //CORPO DE EAMIL
            msg.Body = string.Format("Olá {0} \nSeu cadastro foi realizado com sucesso" + cliente.Email);

            //enviar o email
            SmtpClient smtp = new SmtpClient();
            smtp.Host = ConfigurationManager.AppSettings["SMTP"];
            smtp.Port = int.Parse(ConfigurationManager.AppSettings["PORTA"]);

            //AUTENTICANDO NA CONTA DE EMAIL

            NetworkCredential credential = new NetworkCredential();
            credential.UserName = ConfigurationManager.AppSettings["EMAIL"];
            credential.Password = ConfigurationManager.AppSettings["SENHA"];

            //enviando..
            smtp.Credentials = credential;
            smtp.EnableSsl = true; //segurança
            smtp.Send(msg); //disparando a mensagem!


        }
    }
}


