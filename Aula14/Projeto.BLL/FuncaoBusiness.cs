using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.DAL;

namespace Projeto.BLL
{
    public class FuncaoBusiness
    {
        //atributo
        private FuncaoRepository repository;

        //construtor
        public FuncaoBusiness()
        {
            repository = new FuncaoRepository();
        }

        //método para executar a consulta de funções
        public List<Funcao> ConsultarFuncoes()
        {
            return repository.FindAll();
        }
    }
}
