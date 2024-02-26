namespace ConsoleClient;

public interface IPersonRepository
{
    List<Person> GetAllPersons();
    void Insert(Person person);
}