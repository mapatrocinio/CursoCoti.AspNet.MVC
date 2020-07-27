using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Entites
{
  public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public Cliente()
        {

        }

        public Cliente(int idCliente, string name, string email, DateTime dataCadastro)
        {
            IdCliente = idCliente;
            Nome = name;
            Email = email;
            DataCadastro = dataCadastro;
        }

        public override string ToString()
        {
           return string.Format("Id:{0},Nome:{1},Email:{2}, Data Cadastro{3}", IdCliente,Nome,Email,DataCadastro);
        }
    }
}
