using DependencyInjection.Core;
using DependencyInjection.Core.Contracts;
using DependencyInjection.Models;
using DependencyInjection.Models.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices();
            var engine = serviceProvider.GetService<IEngine>();
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IEngine, Engine>();
            serviceCollection.AddTransient<IWriter, ConsoleWriter>();
            serviceCollection.AddTransient<IWriter, FileWriter>();
            serviceCollection.AddTransient<IReader, ConsoleReader>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
