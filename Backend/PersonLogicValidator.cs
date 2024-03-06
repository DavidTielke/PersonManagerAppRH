using DavidTielke.PersonManagerApp.Backend.PersonManagement;
using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend;

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