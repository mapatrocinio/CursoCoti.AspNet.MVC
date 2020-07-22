using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //importando
using Projeto.BLL.Contracts; //importando
using Projeto.DAL.Contracts; //importando

namespace Projeto.BLL.Business
{
    public class DependenteBusiness
        : BaseBusiness<Dependente>, IDependenteBusiness
    {
        //atributo
        private IDependenteRepository repository;

        //construtor para inicializar o atributo
        public DependenteBusiness(IDependenteRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
