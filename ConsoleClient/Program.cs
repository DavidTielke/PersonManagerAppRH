using DavidTielke.PersonManagerApp.Backend;
using DavidTielke.PersonManagerApp.Backend.Data.DataAccess;
using DavidTielke.PersonManagerApp.Backend.Data.FileStorage;
using DavidTielke.PersonManagerApp.Backend.PersonManagement;
using DavidTielke.PersonManagerApp.CrossCutting.Configuration;
using DavidTielke.PersonManagerApp.CrossCutting.Logging;
using Mappings;
using Microsoft.Extensions.DependencyInjection;
using Ninject;

namespace DavidTielke.PersonManagerApp.Frontend.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddApplicationServices();

            var kernel = serviceCollection.BuildServiceProvider();

            var config = kernel.GetService<IConfigurator>();
            config.Set("AgeTreshold", 18);
            config.Set(DataConfigConstants.FILEPATH, "data.csv");
            config.Set("Separator", ",");

            var manager = kernel.GetService<IPersonManager>();

            //var person = new Person(5, "Maus", 0);
            //manager.Add(person);


            var adults = manager.GetAllAdults();
            Console.WriteLine($"### ERWACHSENE ({adults.Count})###");
            adults.ForEach(a => Console.WriteLine(a.Name));

            var children = manager.GetAllChildren();
            Console.WriteLine($"### Kinder ({children.Count})###");
            children.ForEach(c => Console.WriteLine(c.Name));
        }
    }
}
