using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class ContinerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Appliction>().As<IAppliction>();
            builder.RegisterType<BussnisLogic>().As<IBussnisLogic>();
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                 .Where(a => a.Namespace.Contains("Utilties"))
                 .As(a => a.GetInterfaces().FirstOrDefault(i => i.Name == "I" + a.Name));

            return builder.Build();
        }
    }
}
