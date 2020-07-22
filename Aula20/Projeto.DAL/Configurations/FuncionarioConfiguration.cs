using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration; //ORM
using Projeto.Entities; //importando

namespace Projeto.DAL.Configurations
{
    //REGRA 1) Herdar EntityTypeConfiguration
    public class FuncionarioConfiguration
        : EntityTypeConfiguration<Funcionario>
    {
        //REGRA 2) Construtor -> ctor + 2x[tab]
        public FuncionarioConfiguration()
        {
            //nome da tabela
            ToTable("FUNCIONARIO");

            //chave primária
            HasKey(f => new { f.IdFuncionario });

            //demais campos
            Property(f => f.IdFuncionario)
                .HasColumnName("IDFUNCIONARIO");

            Property(f => f.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            Property(f => f.Salario)
                .HasColumnName("SALARIO")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(f => f.DataAdmissao)
                .HasColumnName("DATAADMISSAO")
                .IsRequired();
        }
    }
}
