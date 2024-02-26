using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.Logic.PersonManagement;

public class PersonLogicValidator : IPersonLogicValidator
{
    public void AssertForAdd(Person person)
    {
        ArgumentNullException.ThrowIfNull(person);
        if (person.Name == "Maus")
        {
            throw new ArgumentException("Name Maus is forbidded", nameof(person.Name));
        }
    }
}