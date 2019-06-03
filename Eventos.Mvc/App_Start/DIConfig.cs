using Eventos.Repositories.Dapper.Eventos;
using Eventos.UnitOfWork;
using log4net;
using log4net.Core;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Eventos.Mvc.App_Start
{
    public class DIConfig
    {
        public static void ConfigureInjector()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            container.Register<IUnitOfWork>(() =>
                new EventosUnitOfWork(ConfigurationManager.ConnectionStrings["NorthwindConnection"].ToString()), Lifestyle.Scoped);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.RegisterConditional(typeof(ILog),
                c => typeof(Log4NetAdapter<>).MakeGenericType(c.Consumer.ImplementationType),
                Lifestyle.Singleton, c => true);
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }

    //sealed: la clase no puede ser heredad
    public sealed class Log4NetAdapter<T> : LogImpl
    {
        public Log4NetAdapter() : base(LogManager.GetLogger(typeof(T)).Logger) { }
    }
}