using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.Core
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingDataSink>().To<LoggingDataSink>();
            Bind<ILoggingComponent>().To<LoggingComponent>();
        }
    }
}
