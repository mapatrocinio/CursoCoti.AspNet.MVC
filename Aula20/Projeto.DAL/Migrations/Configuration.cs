namespace Projeto.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration
                         <Projeto.DAL.Context.DataContext>
    {
        public Configuration()
        {
            //flag que dá permissão ao EntityFramework para
            //criar ou atualizar o conteudo do banco de dados
            AutomaticMigrationsEnabled = true;

            //flag que dá permissão ao EntityFramework para
            //excluir o conteudo do banco de dados
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Projeto.DAL.Context.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
