using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Contato
    {
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato()
        {

        }

        public Contato(string telefone, string email)
        {
            Telefone = telefone;
            Email = email;
        }

        public override string ToString()
        {
            return $"Telefone: {Telefone}, Email: {Email}";
        }
    }
}
