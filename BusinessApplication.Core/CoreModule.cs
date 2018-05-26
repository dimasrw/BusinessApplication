using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Ninject.Activation;
using System.Configuration;

namespace BusinessApplication.Core
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingDataSink>().To<LoggingDataSink>();
            Bind<ILoggingComponent>().To<LoggingComponent>();
            Bind<IDataAccessComponent>().ToProvider(new DataAccessComponentProvider());
            Bind<IWebServiceProxy>().ToProvider(new WebServiceProxyComponentProvider());
        }
    }

    public class DataAccessComponentProvider : Provider<IDataAccessComponent>
    {
        protected override IDataAccessComponent CreateInstance(IContext context)
        {
            var databaseConnectionString =
                ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            return new DataAccessComponent(databaseConnectionString);
        }
    }

    public class WebServiceProxyComponentProvider : Provider<IWebServiceProxy>
    {
        protected override IWebServiceProxy CreateInstance(IContext context)
        {
            var webServiceAddress = ConfigurationManager.AppSettings
                ["MyWebServiceAddress"];
            return new WebServiceProxy(webServiceAddress);
        }
    }
}
