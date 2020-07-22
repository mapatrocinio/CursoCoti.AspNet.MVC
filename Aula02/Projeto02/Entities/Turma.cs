using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Turma
    {
        public int IdTurma { get; set; }
        public DateTime DataInicio { get; set; }

        //Relacionamento TER 1 Professor
        public Professor Professor { get; set; }

        //Relacionamento TER 1 Curso
        public Curso Curso { get; set; }

        //Relacionamento TER MUITAS Turmas
        public List<Aluno> Alunos { get; set; }

        //Relacionamento TER 1 Turno
        public Turno Turno { get; set; }
    }

}
