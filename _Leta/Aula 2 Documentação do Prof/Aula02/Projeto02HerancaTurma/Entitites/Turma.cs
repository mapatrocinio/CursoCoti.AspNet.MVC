using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02HerancaTurma.Entitites
{
   public class Turma
    {
        public int IdTurma { get; set; }
        private DateTime dataInicio;

        public DateTime DataInicio
        {
            get {
                string valor;
                valor = dataInicio.ToString("dd/MM/yyyy");
                
                return DateTime.Parse(valor); }

            set { dataInicio = value; }
        }

        public List<Aluno> Aluno { get; set; }
        public Professor Professor { get; set; }
        public Curso Curso { get; set; }
        public Turno Turno { get; set; }

    }
}
