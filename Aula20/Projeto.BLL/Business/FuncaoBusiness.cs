using Projeto.BLL.Contracts;
using Projeto.DAL.Contracts;
using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Business
{
    public class FuncaoBusiness
        : BaseBusiness<Funcao>, IFuncaoBusiness
    {
        private IFuncaoRepository repository;

        public FuncaoBusiness(IFuncaoRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
