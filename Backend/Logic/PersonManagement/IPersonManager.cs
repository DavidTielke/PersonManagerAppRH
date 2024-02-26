using ConsoleClient.CrossCutting.DataClasses;

namespace ConsoleClient.Logic.PersonManagement;

public interface IPersonManager
{
    List<Person> GetAllAdults();
    List<Person> GetAllChildren();
    void Add(Person person);
}