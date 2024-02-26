using ConsoleClient.CrossCutting.DataClasses;

namespace ConsoleClient.Logic.PersonManagement;

public interface IPersonLogicValidator
{
    public void AssertForAdd(Person person);
}