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
    public class SetorRepository
    {
        //atributo..
        private string connectionString;

        public SetorRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings
                                ["projeto"].ConnectionString;
        }

        public List<Setor> FindAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select * from Setor order by Nome";

                return conn.Query<Setor>(query).ToList();
            }
        }
    }
}
