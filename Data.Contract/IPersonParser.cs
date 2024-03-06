using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.Data.DataAccess;

public interface IPersonParser
{
    List<Person> ParseFromCSV(IEnumerable<string> lines);
}