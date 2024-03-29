﻿using DavidTielke.PersonManagerApp.Backend;
using DavidTielke.PersonManagerApp.Backend.Data.DataAccess;
using DavidTielke.PersonManagerApp.Backend.Data.FileStorage;
using DavidTielke.PersonManagerApp.Backend.PersonManagement;
using DavidTielke.PersonManagerApp.CrossCutting.Configuration;
using DavidTielke.PersonManagerApp.CrossCutting.Logging;
using Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationServices(this IServiceCollection source)
        {
            new ServiceCollectionInitializer().Initialize(source);
        }

    }
}

namespace Mappings
{

    public class ServiceCollectionInitializer
    {
        public void Initialize(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPersonManager, PersonManager>();
            serviceCollection.AddScoped<IPersonRepository, PersonRepository>();
            serviceCollection.AddScoped<IPersonConverter, PersonConverter>();
            serviceCollection.AddScoped<IPersonParser, PersonParser>();
            serviceCollection.AddScoped<IFileStorer, FileStorer>();
            serviceCollection.AddScoped<IPersonDataValidator, PersonDataValidator>();
            serviceCollection.AddScoped<IPersonLogicValidator, PersonLogicValidator>();
            serviceCollection.AddScoped<ILogger, Logger>();
            serviceCollection.AddSingleton<IConfigurator, Configurator>();
        }
    }
}
