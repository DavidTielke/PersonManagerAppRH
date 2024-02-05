namespace ConsoleClient;

public interface IPersonParser
{
    List<Person> ParseFromCSV(IEnumerable<string> lines);
}