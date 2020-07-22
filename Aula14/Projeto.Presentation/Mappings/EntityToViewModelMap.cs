using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Projeto.Entities;
using Projeto.Presentation.Models;

namespace Projeto.Presentation.Mappings
{
    public class EntityToViewModelMap : Profile
    {
        //construtor -> ctor + 2x[tab]
        public EntityToViewModelMap()
        {
            CreateMap<Funcionario, FuncionarioConsultaViewModel>()
                .AfterMap((from, to) => to.NomeSetor = from.Setor.Nome)
                .AfterMap((from, to) => to.NomeFuncao = from.Funcao.Nome);

            CreateMap<Funcionario, FuncionarioEdicaoViewModel>();
        }
    }
}
