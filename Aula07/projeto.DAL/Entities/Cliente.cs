using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Projeto.DAL.Entities
{
    public class Cliente
    {
        //propriedades -> prop + 2x[tab]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        //construtor -> ctor + 2x[tab]
        public Cliente()
        {
            //vazio
        }
        //construtor com entrada de argumentos (sobrecarga de construtores)
        public Cliente(int idCliente, string nome, string email,
        DateTime dataCadastro)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
        }
        //Sobrescrita do método ToString()
        public override string ToString()
        {
            return $"Id: {IdCliente}, Nome: {Nome}, Email: {Email}, Data de Cadastro: { DataCadastro}";
        }
    }
}