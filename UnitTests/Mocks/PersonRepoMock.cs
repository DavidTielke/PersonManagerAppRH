using DavidTielke.PersonManagerApp.Backend.Data.DataAccess;
using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace UnitTests.Mocks
{
    public class PersonRepoMock : IPersonRepository
    {
        public List<Person> Persons { get; set; } = new List<Person>();
        public List<Person> GetAllPersons()
        {
            return Persons;
        }

        public void Insert(Person person)
        {
            
        }
    }
}