﻿using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TrashBin.Domain;
using TrashBin.Mvc.App_Start;
using TrashBin.Mvc.Models;

namespace TrashBin.Mvc
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
            AutofacConfig.Configure();

            Database.SetInitializer(new TrashBinDatabaseInitializer());

            // TODO: move this to its' own bootstrapper 
            AutoMapper.Mapper.CreateMap<Project, ProjectViewModel>();
        }
    }
}