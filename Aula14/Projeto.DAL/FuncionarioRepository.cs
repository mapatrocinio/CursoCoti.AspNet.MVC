using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //importando
using System.Configuration; //importando
using Projeto.Entities; //importando
using Dapper; //importando

namespace Projeto.DAL
{
    public class FuncionarioRepository
    {
        //atributo
        private string connectionString;

        //construtor
        public FuncionarioRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings
                                ["projeto"].ConnectionString;
        }

        //método para inserir um funcionario na base de dados
        public void Insert(Funcionario funcionario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "insert into Funcionario(Nome, Salario, "
                             + "DataAdmissao, IdSetor, IdFuncao) "
                             + "values(@Nome, @Salario, @DataAdmissao, "
                             + "@IdSetor, @IdFuncao)";

                conn.Execute(query, funcionario);
            }
        }

        //método para atualizar um funcionario na base de dados
        public void Update(Funcionario funcionario)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "update Funcionario set Nome = @Nome, Salario = @Salario, "
                             + "DataAdmissao = @DataAdmissao, IdSetor = @IdSetor, "
                             + "IdFuncao = @IdFuncao where IdFuncionario = @IdFuncionario";

                conn.Execute(query, funcionario);
            }
        }

        //método para excluir um funcionário na base de dados
        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "delete from Funcionario where IdFuncionario = @IdFuncionario";

                conn.Execute(query, new { IdFuncionario = id });
            }
        }

        //método para listar todos os funcionarios da base de dados
        public List<Funcionario> SelectAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select * from Funcionario f "
                             + "inner join Funcao fn on fn.IdFuncao = f.IdFuncao "
                             + "inner join Setor s on s.IdSetor = f.IdSetor";

                return conn.Query(query,
                    (Funcionario funcionario, Funcao funcao, Setor setor) =>
                    {
                        funcionario.Funcao = funcao;
                        funcionario.Setor = setor;
                        return funcionario;
                    },
                    splitOn: "IdFuncao, IdSetor")
                    .ToList();
            }
        }

        //método para listar todos os funcionarios pelo nome
        public List<Funcionario> SelectAllByNome(string nome)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select * from Funcionario f "
                           + "inner join Funcao fn on fn.IdFuncao = f.IdFuncao "
                           + "inner join Setor s on s.IdSetor = f.IdSetor "
                           + "where f.Nome like @Nome";

                return conn.Query(query,
                    (Funcionario funcionario, Funcao funcao, Setor setor) =>
                    {
                        funcionario.Funcao = funcao;
                        funcionario.Setor = setor;
                        return funcionario;
                    },
                    new { Nome = $"%{nome}%" },
                    splitOn: "IdFuncao, IdSetor")
                    .ToList();
            }
        }

        //método para obter 1 funcionario pelo id
        public Funcionario SelectById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select * from Funcionario f "
                             + "inner join Funcao fn on fn.IdFuncao = f.IdFuncao "
                             + "inner join Setor s on s.IdSetor = f.IdSetor "
                             + "where f.IdFuncionario = @IdFuncionario";

                return conn.Query(query,
                    (Funcionario funcionario, Funcao funcao, Setor setor) =>
                    {
                        funcionario.Funcao = funcao;
                        funcionario.Setor = setor;
                        return funcionario;
                    },
                    new { IdFuncionario = id }, //filtros
                    splitOn: "IdFuncao, IdSetor")
                    .SingleOrDefault();
            }
        }
    }
}
