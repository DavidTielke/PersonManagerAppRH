using ConsoleClient.CrossCutting.DataClasses;

namespace ConsoleClient.Data.DataAccess;

public interface IPersonRepository
{
    List<Person> GetAllPersons();
    void Insert(Person person);
}