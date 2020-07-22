using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using AutoMapper;
using Projeto.Services.Mappings;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using Projeto.DAL.Contracts;
using Projeto.DAL.Repositories;

using Projeto.BLL.Business;
using Projeto.BLL.Contracts;
using SimpleInjector.Integration.WebApi;

namespace Projeto.Services
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //configuração do AutoMapper
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<EntityToViewModelMap>();
                cfg.AddProfile<ViewModelToEntityMap>();
            });

            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle
                    = new AsyncScopedLifestyle();

            // Register your types, for instance using the scoped lifestyle:
            container.Register<IDependenteRepository,
            DependenteRepository>(Lifestyle.Scoped);

            container.Register<IFuncaoRepository,
            FuncaoRepository>(Lifestyle.Scoped);

            container.Register<IFuncionarioRepository,
            FuncionarioRepository>(Lifestyle.Scoped);

            container.Register<IDependenteBusiness,
            DependenteBusiness>(Lifestyle.Scoped);

            container.Register<IFuncaoBusiness,
            FuncaoBusiness>(Lifestyle.Scoped);

            container.Register<IFuncionarioBusiness, FuncionarioBusiness>(Lifestyle.Scoped);

            // This is an extension method from the integration package.
            container.RegisterWebApiControllers
            (GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}
