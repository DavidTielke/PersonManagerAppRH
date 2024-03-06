using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.Data.DataAccess;

public class PersonConverter : IPersonConverter
{
    public string ToCsv(Person person)
    {
        return $"{person.Id},{person.Name},{person.Age}";
    }
}