using System;
using DemoLibrary;
using DemoLibrary.Utilties;
using Autofac;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var continer = ContinerConfig.Configure();
            using (var scope = continer.BeginLifetimeScope())
            {
                var app = scope.Resolve<IAppliction>();
                app.Run();
            }
            Console.ReadLine();
        }
    }
}
