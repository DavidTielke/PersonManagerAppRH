using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.Data.DataAccess;

public interface IPersonRepository
{
    List<Person> GetAllPersons();
    void Insert(Person person);
}