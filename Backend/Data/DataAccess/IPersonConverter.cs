using ConsoleClient.CrossCutting.DataClasses;

namespace ConsoleClient.Data.DataAccess;

public interface IPersonConverter
{
    string ToCsv(Person person);
}