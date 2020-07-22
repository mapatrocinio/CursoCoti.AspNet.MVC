using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities; //importando
using Projeto02.Contracts; //importando
using System.IO; //importando
using Newtonsoft.Json; //importando

namespace Projeto02.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public void ExportarJson(Cliente cliente)
        {
            using (StreamWriter streamWriter
            = new StreamWriter("C:\\_Pessoal\\CursoCoti\\tmp\\cliente.json"))
            {
                streamWriter.WriteLine
            (JsonConvert.SerializeObject(cliente, Formatting.Indented));
            }
        }

        public Cliente ImportarJson()
        {
            using (StreamReader streamReader
            = new StreamReader("C:\\_Pessoal\\CursoCoti\\tmp\\cliente.json"))
            {
                return JsonConvert.DeserializeObject<Cliente>
                (streamReader.ReadToEnd());
            }
        }
    }
}
