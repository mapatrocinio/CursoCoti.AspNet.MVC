using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Projeto.Entities;
using Projeto.Presentation.Models;

namespace Projeto.Presentation.Mappings
{
    //classe de mapeamento do AutoMapper
    public class ViewModelToEntityMap : Profile
    {
        //construtor -> ctor + 2x[tab]
        public ViewModelToEntityMap()
        {
            CreateMap<FuncionarioCadastroViewModel, Funcionario>();
            CreateMap<FuncionarioEdicaoViewModel, Funcionario>();
        }
    }
}
