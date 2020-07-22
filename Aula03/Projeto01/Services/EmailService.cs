using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities; //importando..
using System.Net; //importando..
using System.Net.Mail; //importando..
using System.Configuration; //importando..

namespace Projeto01.Services
{
    public class EmailService
    {
        public void EnviarMensagem(Cliente cliente)
        {
            //definir o remetente da mensagem
            MailAddress from = new MailAddress(ConfigurationManager
                        .AppSettings["EMAIL"]);
            //definir o destinatário da mensagem
            MailAddress to = new MailAddress(cliente.Email);

            //Montar um email
            MailMessage msg = new MailMessage(from, to);


            //assunto da mensagem
            msg.Subject = "Seja bem vindo ao Sistema";
            //corpo da mensagem
            msg.Body = $"Olá {cliente.Nome}\nSeu cadastro foi realizado com sucesso.";

            //enviar a mensagem..
            SmtpClient smtp = new SmtpClient();
            smtp.Host = ConfigurationManager.AppSettings["SMTP"];
            smtp.Port = int.Parse(ConfigurationManager.AppSettings["PORTA"]);

            //autenticar na conta de email do remetente
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
