using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula03Projeto01.Entities;
using Aula03Projeto01.Entities.Types;

namespace Aula03Projeto01.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }        
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public string Texto { get; set; }

        public Cliente()
        {

        }

        public Cliente(int idcliente , string nome, string email,  Sexo sexo ,  EstadoCivil estadocivil )
        {
            IdCliente = idcliente;
            Nome = nome;
            Email = email;
            Sexo = sexo;
            EstadoCivil = estadocivil;
            

        }

        public override string ToString()
{
 	 return string.Format("Id: {0} - Nome: {1} - Email :{2} Sexo : {3} - Estado Civil: {4} texto{5}",IdCliente,Nome,Email,Sexo,EstadoCivil);
}

    }
}
