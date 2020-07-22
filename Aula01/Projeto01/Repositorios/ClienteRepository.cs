using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using System.IO;
namespace Projeto01.Repositorios
{
    /// <summary>
    /// Classe para armazenamento de dados de Clientes
    /// </summary>
    public class ClienteRepository
    {
        /// <summary>
        /// Método para exportar os dados de Cliente para arquivo CSV
        /// </summary>
        /// <param name="cliente">Objeto da classe Cliente</param>
        public void ExportarParaCsv(Cliente cliente)
        {
            using (StreamWriter writer = new StreamWriter
            ("C:\\_Pessoal\\CursoCoti\\tmp\\clientes.csv", true))
            {
                writer.WriteLine("{0};{1};{2}",
                cliente.IdCliente, cliente.Nome, cliente.Email);
            }
        }
    }
}