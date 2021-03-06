﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using DAL;
using DAL.Models;
using Paul.App_Start;
using DAL.Mapping;

namespace Paul
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            Database.SetInitializer(new CreateDatabaseIfNotExists<PaulContext>());
            AutoMapperServicesConfiguration.Configure();
        }
    }
}
