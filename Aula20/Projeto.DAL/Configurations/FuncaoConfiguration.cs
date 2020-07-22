using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //importando
using System.Data.Entity.ModelConfiguration; //importando

namespace Projeto.DAL.Configurations
{
    //classe de mapeamento para a entidade Funcao
    public class FuncaoConfiguration
        : EntityTypeConfiguration<Funcao>
    {
        //construtor -> ctor + 2x[tab]
        public FuncaoConfiguration()
        {
            //nome da tabela
            ToTable("FUNCAO");

            //chave primária
            HasKey(f => new { f.IdFuncao });

            //mapear os campos
            Property(f => f.IdFuncao)
                .HasColumnName("IDFUNCAO");

            Property(f => f.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            //mapeamento do relacionamento..
            //muitos para muitos
            HasMany(f => f.Funcionarios)
                .WithMany(f => f.Funcoes)
                .Map(map =>
                {
                    //nome da tabela associativa
                    map.ToTable("FUNCAOFUNCIONARIO");

                    //chave estrangeira para a entidade 'Funcao'
                    map.MapLeftKey("IDFUNCAO");

                    //chave estrangeira para a entidade 'Funcionario'
                    map.MapRightKey("IDFUNCIONARIO");
                });
        }
    }
}
