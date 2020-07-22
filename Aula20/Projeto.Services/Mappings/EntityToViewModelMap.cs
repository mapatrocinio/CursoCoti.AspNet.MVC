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
    public class EntityToViewModelMap : Profile
    {
        //Regra 2) Construtor -> ctor + 2x[tab]
        public EntityToViewModelMap()
        {
            CreateMap<Dependente, DependenteConsultaViewModel>();
            CreateMap<Funcionario, FuncionarioConsultaViewModel>();
            CreateMap<Funcao, FuncaoConsultaViewModel>();
        }
    }
}

