namespace ConsoleClient;

public interface IPersonManager
{
    List<Person> GetAllAdults();
    List<Person> GetAllChildren();
}