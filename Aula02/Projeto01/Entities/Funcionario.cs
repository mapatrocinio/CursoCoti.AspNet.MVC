using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    //Funcionário É-UMA Pessoa
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }

        //Relacionamentos de Associação
        public Funcao Funcao { get; set; } //TER-1
        public Setor Setor { get; set; } //TER-1
    }
}
