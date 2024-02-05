using ConsoleClient;

namespace UnitTests
{
    class TestRepository : IPersonRepository
    {
        public List<Person> GetAllPersons()
        {
            return new List<Person>
            {
                new Person { Id = 1, Name = "Test1", Age = 18 },
                new Person { Id = 2, Name = "Test2", Age = 17 },
            };
        }
    }

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var repoStub = new TestRepository();
            //var personManager = new PersonManager(repoStub);

            //var actual = personManager.GetAllAdults().Count;

            //Assert.AreEqual(actual, 1);
        }
    }
}