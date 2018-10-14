//using Autofac;
//using Autofac.Integration.Mvc;
//using Autofac.Integration.WebApi;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Web;
//using System.Web.Compilation;
//using System.Web.Http;
//using System.Web.Mvc;

//namespace BuyWeb.App_Start
//{

//    public class AutoFacConfig
//    {
//        static ContainerBuilder builder = new ContainerBuilder();
//        public static IContainer container;

//        public static void Register()
//        {
//            var builder = new ContainerBuilder();
//            var config = GlobalConfiguration.Configuration;
//            var assemblys = BuildManager.GetReferencedAssemblies().Cast<Assembly>();
//            //循环注入
//            foreach (var ass in assemblys)
//            {
//                //只需要注入 所需要的 即可 ，可减少 资源开销
//                if (ass.FullName.Contains("BuyWeb") || ass.FullName.Contains("BuyWeb") || ass.FullName.Contains("Ehi"))
//                    builder.RegisterAssemblyTypes(ass).AsImplementedInterfaces();
//            }


//            builder.RegisterControllers(typeof(MvcApplication).Assembly);
//            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
//            builder.RegisterModelBinderProvider();
//            builder.RegisterModule<AutofacWebTypesModule>();
//            builder.RegisterSource(new ViewRegistrationSource());
//            builder.RegisterFilterProvider();

//            // webapi
//            var config = GlobalConfiguration.Configuration;

//            // Register your Web API controllers.
//            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
//            builder.RegisterWebApiFilterProvider(config);
//            builder.RegisterWebApiModelBinderProvider();

//            var container = builder.Build();
//            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
//            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
//        }

//    }
//}