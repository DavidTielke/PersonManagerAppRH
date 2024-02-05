namespace ConsoleClient;

public interface IFileLoader
{
    List<string> LoadAllLines(string path);
}