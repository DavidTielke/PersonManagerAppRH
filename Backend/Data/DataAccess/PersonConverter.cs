using ConsoleClient.CrossCutting.DataClasses;

namespace ConsoleClient.Data.DataAccess;

public class PersonConverter : IPersonConverter
{
    public string ToCsv(Person person)
    {
        return $"{person.Id},{person.Name},{person.Age}";
    }
}