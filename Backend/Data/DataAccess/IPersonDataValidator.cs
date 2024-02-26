using ConsoleClient.CrossCutting.DataClasses;

namespace ConsoleClient.Data.DataAccess;

public interface IPersonDataValidator
{
    void AssertForInsert(Person person);
}