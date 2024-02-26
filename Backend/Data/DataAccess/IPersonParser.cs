using ConsoleClient.CrossCutting.DataClasses;

namespace ConsoleClient.Data.DataAccess;

public interface IPersonParser
{
    List<Person> ParseFromCSV(IEnumerable<string> lines);
}