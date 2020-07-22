using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities; //importando

namespace Projeto02.Contracts
{
    //contrato
    public interface IClienteRepository
    {
        //método abstrato (sem corpo, somente assinatura)
        void ExportarJson(Cliente cliente);

        //método abstrato (sem corpo, somente assinatura)
        Cliente ImportarJson();
    }
}
