using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //SqlServer
using System.Configuration; //connectionstring
using Dapper; //framework para acesso ao BD
using Projeto.Entities; //classes de entidade
namespace Projeto.DAL
{
    public class ProdutoRepository
    {
        //atributo
        private string connectionString;
        //construtor -> ctor + 2x[tab]
        public ProdutoRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["projeto"].ConnectionString;
        }
        //método para inserir um novo produto no banco de dados
        public void Insert(Produto produto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PRODUTO(NOME, PRECO, QUANTIDADE) "
                + "VALUES(@Nome, @Preco, @Quantidade)";
                conn.Execute(query, produto);
            }
        }
        //método para atualizar um produto no banco de dados
        public void Update(Produto produto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE PRODUTO SET NOME = @Nome, PRECO = @Preco, "
            + "QUANTIDADE = @Quantidade WHERE IDPRODUTO = @IdProduto";
            conn.Execute(query, produto);
            }
        }
        //método para excluir um produto no banco de dados
        public void Delete(int idProduto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM PRODUTO WHERE IDPRODUTO = @IdProduto";
            conn.Execute(query, new { IdProduto = idProduto });
            }
        }
        //método para retornar todos os produtos do banco de dados
        public List<Produto> FindAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PRODUTO";
                return conn.Query<Produto>(query)
                .ToList();
            }
        }
        //método para retornar 1 produto pelo id
        public Produto FindById(int idProduto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PRODUTO WHERE IDPRODUTO = @IdProduto";
            return conn.Query<Produto>(query,
            new { IdProduto = idProduto })
            .SingleOrDefault();
            }
        }
        //método para retornar produtos pelo nome
        public List<Produto> FindByNome(string nome)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PRODUTO WHERE NOME LIKE @Nome";
                return conn.Query<Produto>(query,
                new { Nome = $"%{nome}%" })
                .ToList();
            }
        }
    }
}