using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Presentation.Models
{
    public class FuncionarioConsultaViewModel
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public int IdSetor { get; set; }
        public string NomeSetor { get; set; }

        public int IdFuncao { get; set; }
        public string NomeFuncao { get; set; }
    }
}
