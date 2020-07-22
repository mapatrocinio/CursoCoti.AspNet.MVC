using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //acesso ao sqlserver
using System.Configuration; //connectionstring
using Projeto.DAL.Entities; //entidades
namespace Projeto.DAL.Repositories
{
    public class ClienteRepository
    {
        //atributos
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;
        private string connectionString;
        //construtor -> ctor + 2x[tab]
        public ClienteRepository()
        {
            connectionString = ConfigurationManager
            .ConnectionStrings["projeto"].ConnectionString;
        }
        //método para inserir um cliente na base de dados
        public void Insert(Cliente cliente)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open(); //conectado..
                string query = "insert into Cliente(Nome, Email, DataCadastro) "
                + "values(@Nome, @Email, @DataCadastro)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", cliente.Nome);
                command.Parameters.AddWithValue("@Email", cliente.Email);
                command.Parameters.AddWithValue("@DataCadastro",
                cliente.DataCadastro);
                command.ExecuteNonQuery();
            }
        }
        
        //método para verificar se um email já está cadastrado na tabela
        public bool HasEmail(string email)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open(); //conectado..
                string query = "select Email from Cliente where Email = @Email";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                dataReader = command.ExecuteReader();
                return dataReader.HasRows;
            }
        }
        //método para atualizar os dados de um cliente
        public void Update(Cliente cliente)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open(); //conectado
                string query = "update Cliente set Nome = @Nome, Email = @Email "
                + "where IdCliente = @IdCliente";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                command.Parameters.AddWithValue("@Nome", cliente.Nome);
                command.Parameters.AddWithValue("@Email", cliente.Email);
                command.ExecuteNonQuery();
            }
        }
        //método para excluir um registro de cliente
        public void Delete(int idCliente)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "delete from Cliente where IdCliente = @IdCliente";
            command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", idCliente);
                command.ExecuteNonQuery();
            }
        }
        
        //método para consultar todos os clientes cadastrados
        public List<Cliente> FindAll()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from Cliente";
                command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();
                //declarando uma lista de clientes..
                List<Cliente> lista = new List<Cliente>();
                //percorrendo os registros obtidos na consulta..
                while (dataReader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(dataReader["IdCliente"]);
                    cliente.Nome = Convert.ToString(dataReader["Nome"]);
                    cliente.Email = Convert.ToString(dataReader["Email"]);
                    cliente.DataCadastro = Convert.ToDateTime
                    (dataReader["DataCadastro"]);
                    lista.Add(cliente); //adicionando na lista..
                }
                //retornando a lista..
                return lista;
            }
        }
        //método para retornar 1 cliente pelo id
        public Cliente FindById(int idCliente)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open(); //abrindo conexão..
                string query = "select * from Cliente where IdCliente = @IdCliente";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", idCliente);
                dataReader = command.ExecuteReader();
                //verificando se algum registro foi encontrado
                if (dataReader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(dataReader["IdCliente"]);
                    cliente.Nome = Convert.ToString(dataReader["Nome"]);
                    cliente.Email = Convert.ToString(dataReader["Email"]);
                    cliente.DataCadastro = Convert.ToDateTime
                    (dataReader["DataCadastro"]);
                    return cliente;
                }
                else
                {
                    return null; //vazio (sem espaço de memória)
                }
            }
        }
    }
}