using Projeto02HerancaTurma.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Não estou usando 
namespace Projeto02HerancaTurma.Repository
{
    public class TurmaRepository
    {
        public void GravarTurmaCsv (Turma turma)        
        {

            using (StreamWriter arquivo = new StreamWriter("C:\\TEMP\\turma.csv"))
            {

                arquivo.WriteLine("{0};{1};{2};{3}", turma.IdTurma,turma.DataInicio,turma.Professor.Nome, turma.Aluno.Count());
            
            }
        
        

        }
    }
}




        