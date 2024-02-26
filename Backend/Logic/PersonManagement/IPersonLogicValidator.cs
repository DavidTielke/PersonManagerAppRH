using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.Logic.PersonManagement;

public interface IPersonLogicValidator
{
    public void AssertForAdd(Person person);
}