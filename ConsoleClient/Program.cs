using Ninject;

namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();

            kernel.Bind<IPersonManager>().To<PersonManager>();
            kernel.Bind<IPersonRepository>().To<PersonRepository>();
            kernel.Bind<IPersonParser>().To<PersonParser>();
            kernel.Bind<IFileLoader>().To<FileLoader>();
            kernel.Bind<ILogger>().To<Logger>();
            kernel.Bind<IConfigurator>().To<Configurator>().InSingletonScope();
            kernel.Bind<IAgeProvider>().To<AgeProvider>().InSingletonScope();

            var config = kernel.Get<IConfigurator>();
            config.Set("AgeTreshold",10);
            config.Set(DataConfigConstants.FILEPATH,"data.csv");
            config.Set("Separator", ",");

            var manager = kernel.Get<IPersonManager>();


            var adults = manager.GetAllAdults();
            Console.WriteLine($"### ERWACHSENE ({adults.Count})###");
            adults.ForEach(a => Console.WriteLine(a.Name));

            var children = manager.GetAllChildren();
            Console.WriteLine($"### Kinder ({children.Count})###");
            children.ForEach(c => Console.WriteLine(c.Name));
        }
    }
}
