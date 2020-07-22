using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL;
using Projeto.Entities;

namespace Projeto.BLL
{
    public class SetorBusiness
    {
        //atributo
        private SetorRepository repository;

        public SetorBusiness()
        {
            repository = new SetorRepository();
        }

        public List<Setor> ConsultarSetores()
        {
            return repository.FindAll();
        }
    }
}
