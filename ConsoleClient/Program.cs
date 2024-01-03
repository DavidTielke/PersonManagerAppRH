namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var personManager = new PersonManager();

           var adults = personManager.GetAllAdults();
           Console.WriteLine($"### ERWACHSENE ({adults.Count})###");
           adults.ForEach(a => Console.WriteLine(a.Name));

           var children = personManager.GetAllChildren();
           Console.WriteLine($"### Kinder ({children.Count})###");
           children.ForEach(c => Console.WriteLine(c.Name));
        }
    }
}
