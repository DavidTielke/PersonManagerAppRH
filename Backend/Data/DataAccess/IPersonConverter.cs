using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.Data.DataAccess;

public interface IPersonConverter
{
    string ToCsv(Person person);
}