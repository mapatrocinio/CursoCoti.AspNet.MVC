﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        //Relacionamento -> TEM MUITOS Dependentes
        public List<Dependente> Dependentes { get; set; }

        //Relacionamento -> TEM MUITAS Funções
        public List<Funcao> Funcoes { get; set; }
    }
}
