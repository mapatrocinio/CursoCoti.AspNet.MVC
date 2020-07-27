using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL.Entites;
using System.Data.SqlClient;
using System.Configuration;


namespace Projeto.DAL.Reposotories
{
    public class ClienteRepo
    {
        private SqlConnection connnection;
        private SqlCommand comand;
        private SqlDataReader dataReader;
        private string connectionString;
        

        public ClienteRepo()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Projeto"].ConnectionString;
        }

        public void Inserir(Cliente cliente)
        {
            using (connnection = new SqlConnection(connectionString))
            {
                connnection.Open();
                string query = "insert into Cliente (Nome, Email, DataCadastro)" + "values(@Email,@Nome,@DataCadastro)";
                comand = new SqlCommand(query,connnection);
                comand.Parameters.AddWithValue("@Nome", cliente.Nome);
                comand.Parameters.AddWithValue("@Email", cliente.Email);
                comand.Parameters.AddWithValue("@DataCadastro", cliente.DataCadastro);
                comand.ExecuteNonQuery();


            }
        }

        public bool HasEmail(string email) 
        {
            using (connnection = new SqlConnection(connectionString))
            {
                connnection.Open();
                string query = "select * from Cliente where Email = @Email";
                comand = new SqlCommand(query,connnection);
                comand.Parameters.AddWithValue("@Email", email);
                dataReader = comand.ExecuteReader();
                return dataReader.HasRows;
            }
        }

        public void Update(Cliente cliente)
        {
            using (connnection = new SqlConnection(connectionString))
            {
                connnection.Open();
                string query = "update Cliente set Nome = @Nome, Email = @Email " + "where IdCliente = @IdCliente";

                comand = new SqlCommand(query,connnection);
                comand.Parameters.AddWithValue("IdCliente", cliente.IdCliente);
                comand.Parameters.AddWithValue("@Nome", cliente.Nome);
                comand.Parameters.AddWithValue("@Email", cliente.Email);
                comand.ExecuteNonQuery();
                
            }
        }

        public void Delete(int ideCliente) 
        
        {
            using (connnection = new SqlConnection(connectionString))
            {
                connnection.Open();
                string query = "delete from cliente where IdCliente = @idCliente";
                comand = new SqlCommand(query, connnection);
                comand.Parameters.AddWithValue("@idCliente", ideCliente);
                comand.ExecuteNonQuery();

            }
        }

        public List<Cliente> FindAll() 
        {
            using (connnection = new SqlConnection(connectionString))
            {
                connnection.Open();
                string query = "select * from clientes";
                dataReader = comand.ExecuteReader();
                comand = new SqlCommand(query, connnection);

                //declarando uma lista de clientes..
                List<Cliente> lista = new List<Cliente>();

                while (dataReader.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = Convert.ToInt32(dataReader["IdCliente"]);
                    cliente.Nome = Convert.ToString(dataReader["Nome"]);
                    cliente.Email = Convert.ToString(dataReader["Email"]);
                    cliente.DataCadastro = Convert.ToDateTime(dataReader["DataCadastro"]);
                    lista.Add(cliente);
                    
                }
                return lista;

                
                                

            }
        }


        public Cliente FindByID(int idCliente) 
        {

            using (connnection = new SqlConnection(connectionString))
            {
                connnection.Open();

                string query = "select * form cliente where IdCliente = @idCliente";
                comand = new SqlCommand(query,connnection);
                comand.Parameters.AddWithValue("@idCliente", idCliente);
                dataReader = comand.ExecuteReader();

                if (dataReader.Read())
                {
                   Cliente cliente = new Cliente();
                   cliente.IdCliente = Convert.ToInt32(dataReader["IdCliente"]);
                   cliente.Nome = Convert.ToString(dataReader["Nome"]);
                   cliente.Email = Convert.ToString(dataReader["Email"]);
                   cliente.DataCadastro = Convert.ToDateTime(dataReader["DataCadastro"]);
                   return cliente;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
