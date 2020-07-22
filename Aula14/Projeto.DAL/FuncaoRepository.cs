using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using Projeto.Entities;

namespace Projeto.DAL
{
    public class FuncaoRepository
    {
        //atributo
        private string connectionString;

        //construtor
        public FuncaoRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings
                                ["projeto"].ConnectionString;
        }

        public List<Funcao> FindAll()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select * from Funcao order by Nome";

                return conn.Query<Funcao>(query).ToList();
            }
        }
    }
}
