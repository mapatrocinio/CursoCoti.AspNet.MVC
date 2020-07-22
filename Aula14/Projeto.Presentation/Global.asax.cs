using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using Projeto.Presentation.Mappings;


namespace Projeto.Presentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //registrando as classes de mapeamento do automapper..
            Mapper.Initialize(m =>
            {
                m.AddProfile<EntityToViewModelMap>();
                m.AddProfile<ViewModelToEntityMap>();
            });
        }
    }
}
