using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.Data.DataAccess;

public interface IPersonDataValidator
{
    void AssertForInsert(Person person);
}