using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        //Associação TER-1 (EMPRESA TEM 1 CONTATO)
        public Contato Contato { get; set; }

        //Associação TER-N (EMPRESA TEM MUITOS ENDERECOS)
        public List<Endereco> Enderecos { get; set; }

        public Empresa()
        {

        }

        public Empresa(int idEmpresa, string razaoSocial, string cnpj)
        {
            IdEmpresa = idEmpresa;
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
        }

        public override string ToString()
        {
            return $"Id: {IdEmpresa}, Razão Social: {RazaoSocial}, CNPJ: {Cnpj}";
        }

    }

}
