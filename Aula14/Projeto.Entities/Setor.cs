using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Setor
    {
        public int IdSetor { get; set; }
        public string Nome { get; set; }

        //Relacionamento TER-MUITOS
        public List<Funcionario> Funcionarios { get; set; }

        public Setor()
        {

        }

        public Setor(int idSetor, string nome)
        {
            IdSetor = idSetor;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Id: {IdSetor}, Nome: {Nome}";
        }
    }
}
