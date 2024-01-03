namespace ConsoleClient;

public interface IPersonParser
{
    List<Person> ParseFromCSV(List<string> lines);
}