using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //connectionstring
using System.Data.Entity; //entityframework
using Projeto.Entities; //classes de entidade
using Projeto.DAL.Configurations; //classes de mapeamento

namespace Projeto.DAL.Context
{
    //REGRA 1) HERDAR DbContext
    public class DataContext : DbContext
    {
        //REGRA 2) Criar um construtor que envie para a DbContext
        //o caminho da connectionstring do banco de dados
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["projeto"].ConnectionString)
        {

        }

        //REGRA 3) Sobrescrever o método OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //adicionar as classes de mapeamento..
            modelBuilder.Configurations.Add(new FuncaoConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
            modelBuilder.Configurations.Add(new DependenteConfiguration());
        }

        //REGRA 4) Declarar uma propriedade (prop + 2x[tab]) 
        //DbSet para cada entidade
        public DbSet<Funcao> Funcao { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Dependente> Dependente { get; set; }
    }
}
