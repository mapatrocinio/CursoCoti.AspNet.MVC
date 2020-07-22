using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities.Types; //importando

namespace Projeto01.Entities
{
    public class Endereco
    {
        //prop + 2x[tab]
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public TipoEndereco Tipo { get; set; }

        //ctor + 2x[tab]
        public Endereco()
        {
            //construtor default (vazio)
        }

        //sobrecarga de método construtor (overloading)
        public Endereco(int idEndereco, string logradouro, string bairro,
          string cidade, string estado, string cep, TipoEndereco tipo)
        {
            IdEndereco = idEndereco;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Tipo = tipo;
        }

        //sobrescrita do método ToString (override)
        public override string ToString()
        {
            return $"Id: {IdEndereco}, Logradouro: {Logradouro}, Bairro: { Bairro}, "
+ $"Cidade: {Cidade}, Estado: {Estado}, Cep: {Cep}, Tipo: { Tipo}";
        }

    }

}
