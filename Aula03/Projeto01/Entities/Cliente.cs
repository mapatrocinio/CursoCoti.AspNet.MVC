using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities.Types; //importando

namespace Projeto01.Entities
{
    public class Cliente
    {
        //prop + 2x[tab]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }

        //ctor + 2x[tab]
        public Cliente()
        {
            //método construtor
        }

        //Sobrecarga do método Construtor
        public Cliente(int idCliente, string nome, string email,
              Sexo sexo, EstadoCivil estadoCivil)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
        }

        //sobrescrita do método ToString()
        public override string ToString()
        {
            //retornando os dados da entidade de forma concatenada..
            return $"Id: {IdCliente}, Nome: {Nome}, Email: {Email} "
                 + $"Sexo: {Sexo}, Estado Civil: {EstadoCivil}";
        }
    }
}
