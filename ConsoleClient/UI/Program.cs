using ConsoleClient.CrossCutting;
using ConsoleClient.CrossCutting.Configuration;
using ConsoleClient.CrossCutting.DataClasses;
using ConsoleClient.CrossCutting.Logging;
using ConsoleClient.Data.DataAccess;
using ConsoleClient.Data.FileStorage;
using ConsoleClient.Logic.PersonManagement;
using Ninject;

namespace ConsoleClient.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();

            kernel.Bind<IPersonManager>().To<PersonManager>();
            kernel.Bind<IPersonRepository>().To<PersonRepository>();
            kernel.Bind<IPersonConverter>().To<PersonConverter>();
            kernel.Bind<IPersonParser>().To<PersonParser>();
            kernel.Bind<IFileStorer>().To<FileStorer>();
            kernel.Bind<IPersonDataValidator>().To<PersonDataValidator>();
            kernel.Bind<IPersonLogicValidator>().To<PersonLogicValidator>();
            kernel.Bind<ILogger>().To<Logger>();
            kernel.Bind<IConfigurator>().To<Configurator>().InSingletonScope();

            var config = kernel.Get<IConfigurator>();
            config.Set("AgeTreshold", 10);
            config.Set(DataConfigConstants.FILEPATH, "data.csv");
            config.Set("Separator", ",");

            var manager = kernel.Get<IPersonManager>();

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
