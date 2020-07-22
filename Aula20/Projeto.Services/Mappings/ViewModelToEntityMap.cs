using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper; //importando
using Projeto.Services.Models; //importando
using Projeto.Entities; //importando

namespace Projeto.Services.Mappings
{
    //Regra 1) HERDAR Profile
    public class ViewModelToEntityMap : Profile
    {
        //Regra 2) Construtor -> ctor + 2x[tab]
        public ViewModelToEntityMap()
        {
            CreateMap<DependenteCadastroViewModel, Dependente>();
            CreateMap<DependenteEdicaoViewModel, Dependente>();

            CreateMap<FuncionarioCadastroViewModel, Funcionario>();
            CreateMap<FuncionarioEdicaoViewModel, Funcionario>();

            CreateMap<FuncaoCadastroViewModel, Funcao>();
            CreateMap<FuncaoEdicaoViewModel, Funcao>();
        }
    }
}
