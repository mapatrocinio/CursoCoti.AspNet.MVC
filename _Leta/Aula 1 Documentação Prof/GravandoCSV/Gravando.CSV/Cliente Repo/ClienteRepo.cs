using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Gravando.CSV.Entites;

namespace Gravando.CSV.Cliente_Repo
{
    public class ClienteRepo
    {
        public void ExportarParaCSV(Cliente cliente)
        {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Thiago Leta Home\\Desktop\\Material Curso Coti\\Aula 1 Documentação Prof\\Arquivo\\cliente.csv", true))
            {
                writer.WriteLine("{0},{1},{2}", cliente.IdCliente,cliente.Nome,cliente.Email);

            }

        }
    }
}
