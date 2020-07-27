using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula01SalvandoCSV.Entidades;
using System.IO;

namespace Aula01SalvandoCSV.CLienteReposirory
{
    public class ClienteRepository
    {
        public void GravarClienteCsv(Cliente cliente) {

           


            using (StreamWriter arquivo = new StreamWriter ("C:\\TEMP\\clientes.csv",true))
                {
                    
                    arquivo.WriteLine("{0};{1};{2}", cliente.Idcliente,cliente.Nome,cliente.Email);
                    
                }

            

            
            
        }

    }
}
