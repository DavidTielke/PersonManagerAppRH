using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.PersonManagement;

public interface IPersonManager
{
    List<Person> GetAllAdults();
    List<Person> GetAllChildren();
    void Add(Person person);
}