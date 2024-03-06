using DavidTielke.PersonManagerApp.Backend.Data.DataAccess;
using DavidTielke.PersonManagerApp.Backend.Data.FileStorage;
using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace Data2
{
    public class PersonMemRepository : IPersonRepository
    {
        public List<Person> GetAllPersons()
        {
            return new List<Person>
            {
                new() { Id = 1, Name = "Test1", Age = 17 },
                new() { Id = 2, Name = "Test2", Age = 18 },
            };
        }

        public void Insert(Person person)
        {
        }
    }
}
