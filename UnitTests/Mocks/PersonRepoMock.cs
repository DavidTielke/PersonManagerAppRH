using ConsoleClient.CrossCutting.DataClasses;
using ConsoleClient.Data.DataAccess;

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