using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.PersonManagement;

public interface IPersonLogicValidator
{
    public void AssertForAdd(Person person);
}