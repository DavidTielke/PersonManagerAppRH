namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileLoader = new FileLoader();
            var personParser = new PersonParser();
            var repository = new PersonRepository(fileLoader, personParser);
           var personManager = new PersonManager(repository);

           var adults = personManager.GetAllAdults();
           Console.WriteLine($"### ERWACHSENE ({adults.Count})###");
           adults.ForEach(a => Console.WriteLine(a.Name));

           var children = personManager.GetAllChildren();
           Console.WriteLine($"### Kinder ({children.Count})###");
           children.ForEach(c => Console.WriteLine(c.Name));
        }
    }
}
