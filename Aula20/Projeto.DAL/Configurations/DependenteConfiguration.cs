using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration; //importando
using Projeto.Entities; //entidades

namespace Projeto.DAL.Configurations
{
    public class DependenteConfiguration
        : EntityTypeConfiguration<Dependente>
    {
        //construtor -> ctor + 2x[tab]
        public DependenteConfiguration()
        {
            //nome da tabela
            ToTable("DEPENDENTE");

            //chave primária
            HasKey(d => new { d.IdDependente });

            //demais campos
            Property(d => d.IdDependente)
                .HasColumnName("IDDEPENDENTE");

            Property(d => d.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            Property(d => d.DataNascimento)
                .HasColumnName("DATANASCIMENTO")
                .IsRequired();

            //Mapeamento do relacionamento
            HasRequired(d => d.Funcionario)
                .WithMany(f => f.Dependentes)
                .Map(map => map.MapKey("IDFUNCIONARIO"))
                .WillCascadeOnDelete(false);

        }
    }
}
