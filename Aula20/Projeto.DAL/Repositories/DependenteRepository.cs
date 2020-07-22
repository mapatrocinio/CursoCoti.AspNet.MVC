using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //importando
using Projeto.DAL.Contracts; //importando

namespace Projeto.DAL.Repositories
{
    public class DependenteRepository
        : BaseRepository<Dependente>, IDependenteRepository
    {

    }
}
