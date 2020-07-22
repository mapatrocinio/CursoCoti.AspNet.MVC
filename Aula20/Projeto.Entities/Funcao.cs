using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{

    public class Funcao
    {
        public int IdFuncao { get; set; }
        public string Nome { get; set; }

        //Relacionamento TER-MUITOS
        public List<Funcionario> Funcionarios { get; set; }
    }
}
