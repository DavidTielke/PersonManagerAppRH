using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.Logic.PersonManagement;

public interface IPersonManager
{
    List<Person> GetAllAdults();
    List<Person> GetAllChildren();
    void Add(Person person);
}