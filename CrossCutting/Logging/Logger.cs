namespace DavidTielke.PersonManagerApp.CrossCutting.Logging
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
